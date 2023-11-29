import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { WodhomePage } from './wodhome.page';

const routes: Routes = [
  {
    path: '',
    component: WodhomePage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class WodhomePageRoutingModule {}
