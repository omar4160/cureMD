import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TodoComponent } from './todo/todo.component';

const routes: Routes = [
  {path:'',component:TodoComponent},
  {path: 'contact', loadChildren: () => import('./contact-us/contact-us.module').then(m => m.ContactUsModule) }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
