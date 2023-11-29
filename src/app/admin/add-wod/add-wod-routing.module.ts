import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AddWodPage } from './add-wod.page';

const routes: Routes = [
  {
    path: '',
    component: AddWodPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AddWodPageRoutingModule {}
