import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { AddIncidencePageRoutingModule } from './add-incidence-routing.module';

import { AddIncidencePage } from './add-incidence.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    IonicModule,
    AddIncidencePageRoutingModule
  ],
  declarations: [AddIncidencePage]
})
export class AddIncidencePageModule {}
