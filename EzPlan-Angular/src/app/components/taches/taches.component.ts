import { Component, OnInit } from '@angular/core';
import { TachesService } from 'src/app/services/taches.service';
import { Tache } from '../../models/tache';

@Component({
  selector: 'app-taches',
  templateUrl: './taches.component.html',
  styleUrls: ['./taches.component.css']
})
export class TachesComponent implements OnInit {

  taches?: Tache[];

  constructor(private tachesService: TachesService) { }

  ngOnInit(): void {
    this.getTaches();
  }

  async getTaches(){
    this.taches = await this.tachesService.getTacheByUtilisateurID().toPromise();
  }

}
