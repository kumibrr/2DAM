import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./tabs/tabs.module').then(m => m.TabsPageModule)
  },
  {
    path: 'add-incidence',
    loadChildren: () => import('./pages/add-incidence/add-incidence.module').then( m => m.AddIncidencePageModule)
  },
  {
    path: 'incidence-detail',
    loadChildren: () => import('./pages/incidence-detail/incidence-detail.module').then( m => m.IncidenceDetailPageModule)
  }
];
@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
