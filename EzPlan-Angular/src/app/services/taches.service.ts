import { Injectable } from '@angular/core';
import { Tache } from '../models/tache';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TachesService {
  private URL = "https://localhost:44350/EzPlanApi/";
  constructor(private http: HttpClient) { }

  getTacheByUtilisateurID(): Observable<Tache[]> {
    let response = this.http.get<Tache[]>("https://localhost:44350/EzPlanApi/getTaches/1");
    return response;
  }
}
