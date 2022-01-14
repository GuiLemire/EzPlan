import { Component, Input, OnInit } from '@angular/core';
import { JourneePlanifiee } from 'src/app/models/journeePlanifiee';
import { TachePlanifiee } from 'src/app/models/tachePlanifiee';

@Component({
  selector: 'app-journee-planifiee',
  templateUrl: './journee-planifiee.component.html',
  styleUrls: ['./journee-planifiee.component.css']
})
export class JourneePlanifieeComponent implements OnInit {
  @Input() journeePlanifiee! : JourneePlanifiee;

  constructor() { }

  ngOnInit(): void {
  }

}
