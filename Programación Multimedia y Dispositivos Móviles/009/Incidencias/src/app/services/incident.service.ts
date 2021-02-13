import { Incident } from './../interfaces/interfaces';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IncidentService {

  public incidences: Array<Incident> = new Array(0);

  constructor(private http: HttpClient) {
    this.http.get<Array<Incident>>('./../assets/incidences.json').subscribe(ob => {
      this.incidences = ob;
    });
  }


}
