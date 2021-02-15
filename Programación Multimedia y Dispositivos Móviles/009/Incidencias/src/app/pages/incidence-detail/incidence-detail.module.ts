import { LOCALE_ID, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import localeEs from '@angular/common/locales/es';
import { registerLocaleData } from '@angular/common';
registerLocaleData(localeEs, 'es');

import { IonicModule } from '@ionic/angular';

import { IncidenceDetailPageRoutingModule } from './incidence-detail-routing.module';

import { IncidenceDetailPage } from './incidence-detail.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    IncidenceDetailPageRoutingModule
  ],
  declarations: [IncidenceDetailPage],
  providers: [{provide: LOCALE_ID, useValue: 'es'}]
})
export class IncidenceDetailPageModule {}
