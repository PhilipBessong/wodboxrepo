import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ViewWodsPage } from './view-wods.page';

const routes: Routes = [
  {
    path: '',
    component: ViewWodsPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ViewWodsPageRoutingModule {}
