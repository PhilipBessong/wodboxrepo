import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { WodDetailsPageRoutingModule } from './wod-details-routing.module';

import { WodDetailsPage } from './wod-details.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    WodDetailsPageRoutingModule
  ],
  declarations: [WodDetailsPage]
})
export class WodDetailsPageModule {}
