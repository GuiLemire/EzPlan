import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Mon planning';
  subTitle = '';
  tacheID = -1;

  changerPage(page : string) {
    this.title = page;
    this.subTitle = '';
  }

  modifierTache(tacheID : number) {
    this.subTitle = 'Modifier tâche'
    this.tacheID = tacheID;
  }

  nouvelleTache() {
    this.subTitle = 'Nouvelle tâche'
    this.tacheID = -1;
  }

}

