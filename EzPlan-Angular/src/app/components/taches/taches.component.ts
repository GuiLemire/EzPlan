import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { lastValueFrom } from 'rxjs';
import { TachesService } from 'src/app/services/taches.service';
import { Tache } from '../../models/tache';

@Component({
  selector: 'app-taches',
  templateUrl: './taches.component.html',
  styleUrls: ['./taches.component.css']
})
export class TachesComponent implements OnInit {

  taches?: Tache[];

  @Output() notifierTacheID = new EventEmitter<number>();

  constructor(private tachesService: TachesService) { }

  ngOnInit(): void {
    this.getTaches();
  }

  async getTaches() {
    const taches$ = this.tachesService.getTacheByUtilisateurID();
    this.taches = await lastValueFrom(taches$);
  }

  modifierTache(tacheID? : number) {
    this.notifierTacheID.emit(tacheID);
  }

}
