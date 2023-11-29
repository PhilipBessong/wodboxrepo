import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { AddWodPageRoutingModule } from './add-wod-routing.module';

import { AddWodPage } from './add-wod.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    AddWodPageRoutingModule
  ],
  declarations: [AddWodPage]
})
export class AddWodPageModule {}
