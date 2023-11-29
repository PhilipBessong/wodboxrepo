import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { WodoutPage } from './wodout.page';

const routes: Routes = [
  {
    path: '',
    component: WodoutPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class WodoutPageRoutingModule {}
