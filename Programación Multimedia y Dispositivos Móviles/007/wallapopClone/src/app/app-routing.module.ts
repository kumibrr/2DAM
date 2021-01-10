import { ProductComponent } from './pages/product/product.component';
import { NonLoggedUserGuard } from './guards/non-logged-user.guard';
import { OnlyLoggedUserGuardGuard } from './guards/only-logged-user-guard.guard';
import { MainPageComponent } from './pages/main/main.component';
import { LoginComponent } from './pages/login/login.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'main', pathMatch: 'full' },
  {
    path: '',
    canActivate: [NonLoggedUserGuard],
    children: [
      { path: 'login', component: LoginComponent},
    ]
  },
  {
    path: '',
    canActivate: [OnlyLoggedUserGuardGuard],
    children: [
      { path: 'main', component: MainPageComponent},
      { path: 'product', component: ProductComponent}
    ]
  },
  { path: '**', redirectTo: 'main', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
