import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AddIncidencePage } from './add-incidence.page';

const routes: Routes = [
  {
    path: '',
    component: AddIncidencePage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AddIncidencePageRoutingModule {}
