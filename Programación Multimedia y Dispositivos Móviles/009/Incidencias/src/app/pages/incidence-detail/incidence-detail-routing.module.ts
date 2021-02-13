import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { IncidenceDetailPage } from './incidence-detail.page';

const routes: Routes = [
  {
    path: '',
    component: IncidenceDetailPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class IncidenceDetailPageRoutingModule {}
