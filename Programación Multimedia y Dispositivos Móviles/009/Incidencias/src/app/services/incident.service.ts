import { Incident } from './../interfaces/interfaces';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

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

  addIncidence(level: number, title: string, description: string) {
    // simulación de post...
    const incidence = {
      id: 0,
      title,
      hasBeenSolved: false,
      description,
      dateSubmitted: new Date(),
      dateSolved: null,
      level
    };
    this.incidences = [incidence, ...this.incidences];
  }

  getFromId(id: number): Incident {
    let r: Incident = null;
    this.incidences.forEach(incidence => {
      if (incidence.id === id) {
        r = incidence;
      }
    });
    return r;
  }

  toggleSolved(id: number){
    this.incidences.forEach(incidence => {
      if (incidence.id === id) {
        if (incidence.hasBeenSolved) {
          incidence.hasBeenSolved = false;
        } else {
          incidence.hasBeenSolved = true;
        }
      }
      console.log(incidence);
    });
  }

}
