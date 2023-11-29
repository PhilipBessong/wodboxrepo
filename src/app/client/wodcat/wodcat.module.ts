import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { WodcatPageRoutingModule } from './wodcat-routing.module';

import { WodcatPage } from './wodcat.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    WodcatPageRoutingModule
  ],
  declarations: [WodcatPage]
})
export class WodcatPageModule {}
