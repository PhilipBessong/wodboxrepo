import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ViewWodsPageRoutingModule } from './view-wods-routing.module';

import { ViewWodsPage } from './view-wods.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ViewWodsPageRoutingModule
  ],
  declarations: [ViewWodsPage]
})
export class ViewWodsPageModule {}
