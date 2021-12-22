import { Injectable } from '@angular/core';
import { Tache } from '../models/tache';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TachesService {
  private URL = "http://ezplan.calendrierdesemis.com/";
  constructor(private http: HttpClient) { }

  getTacheByUtilisateurID(): Observable<Tache[]> {
    let response = this.http.get<Tache[]>(this.URL + "EzPlanApi/getTaches/289");
    return response;
  }
}
