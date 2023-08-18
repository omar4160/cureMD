import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContactComponent } from './contact/contact.component';
import { ContactUsRoutingModule } from './contact-us-routing.module';


@NgModule({
  declarations: [
    ContactComponent
  ],
  imports: [
    CommonModule,
    ContactUsRoutingModule
  ]
})

export class ContactUsModule { }

