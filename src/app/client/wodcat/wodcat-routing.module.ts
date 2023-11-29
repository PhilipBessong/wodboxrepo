import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { WodcatPage } from './wodcat.page';

const routes: Routes = [
  {
    path: '',
    component: WodcatPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class WodcatPageRoutingModule {}
