import { Component, OnInit } from '@angular/core';
import { lastValueFrom } from 'rxjs';
import { TachesService } from 'src/app/services/taches.service';
import { Tache } from '../../models/tache';
import * as CONST from '../../constantes';

@Component({
  selector: 'app-taches',
  templateUrl: './taches.component.html',
  styleUrls: ['./taches.component.css']
})
export class TachesComponent implements OnInit {

  taches?: Tache[] = [{ tacheID: 0, nom: '', dureeApproximative: 0, dureeMaxConsecutive: 0, niveauDeStress: 0 }];
  state: string = 'liste';
  tacheID: number = -1;

  constructor(private tachesService: TachesService) { }

  ngOnInit(): void {
    this.getTaches()
  }

  private async getTaches() {
    const categories$ = this.tachesService.getTachesByUtilisateurID(CONST.utilisateurID);
    this.taches = await lastValueFrom(categories$);
  }

  creerTache() {
    this.tacheID = -1;
    this.state = 'nouvelle-tache';
  }

  ajouterNouvelleTache(tache: Tache) {
    if (!this.isNomTacheDejaUtilise(tache)) {
      this.tachesService.creerTache(CONST.utilisateurID, tache);
      alert("La tache " + tache.nom + " a été ajoutée avec succès.")
      this.getTaches();
    } else {
      alert("La tache " + tache.nom + " existe déjà.")
    }
  }

  isNomTacheDejaUtilise(tache: Tache) {
    for (let singleTache of this.taches!) {
      if (tache.nom === singleTache.nom) {
        return true
      }
    }
    return false
  }

  afficherTache(tacheID?: number) {
    this.tacheID = tacheID!;
    this.state = 'modifier-tache'
  }

  retourListe() {
    this.state = 'liste';
    setTimeout(() => {
      this.getTaches();
    }, 1000);
  }

}


