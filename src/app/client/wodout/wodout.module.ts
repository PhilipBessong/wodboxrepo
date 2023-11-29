import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { WodoutPageRoutingModule } from './wodout-routing.module';

import { WodoutPage } from './wodout.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    WodoutPageRoutingModule
  ],
  declarations: [WodoutPage]
})
export class WodoutPageModule {}
