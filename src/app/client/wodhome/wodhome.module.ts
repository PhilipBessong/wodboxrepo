import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { WodhomePageRoutingModule } from './wodhome-routing.module';

import { WodhomePage } from './wodhome.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    WodhomePageRoutingModule
  ],
  declarations: [WodhomePage]
})
export class WodhomePageModule {}
