import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { WodDetailsPage } from './wod-details.page';

const routes: Routes = [
  {
    path: '',
    component: WodDetailsPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class WodDetailsPageRoutingModule {}
