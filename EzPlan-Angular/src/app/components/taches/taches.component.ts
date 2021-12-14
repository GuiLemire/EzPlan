import { Component, OnInit } from '@angular/core';
import { Tache } from '../../models/tache';

@Component({
  selector: 'app-taches',
  templateUrl: './taches.component.html',
  styleUrls: ['./taches.component.css']
})
export class TachesComponent implements OnInit {

  taches?: Tache[];

  constructor() { }

  ngOnInit(): void {
  }

}
