import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CompleteResetPageRoutingModule } from './complete-reset-routing.module';

import { CompleteResetPage } from './complete-reset.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CompleteResetPageRoutingModule
  ],
  declarations: [CompleteResetPage]
})
export class CompleteResetPageModule {}
