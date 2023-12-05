import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  {
    path: 'folder/:id',
    loadChildren: () => import('./folder/folder.module').then( m => m.FolderPageModule)
  },
  {
    path: 'view-wods',
    loadChildren: () => import('./admin/view-wods/view-wods.module').then( m => m.ViewWodsPageModule)
  },
  {
    path: 'add-wod',
    loadChildren: () => import('./admin/add-wod/add-wod.module').then( m => m.AddWodPageModule)
  },
  {
    path: 'login',
    loadChildren: () => import('./logster/login/login.module').then( m => m.LoginPageModule)
  },
  {
    path: 'signup',
    loadChildren: () => import('./logster/signup/signup.module').then( m => m.SignupPageModule)
  },
  {
    path: 'wodhome',
    loadChildren: () => import('./client/wodhome/wodhome.module').then( m => m.WodhomePageModule)
  },
  {
    path: 'wodcat',
    loadChildren: () => import('./client/wodcat/wodcat.module').then( m => m.WodcatPageModule)
  },
  {
    path: 'warmup',
    loadChildren: () => import('./client/warmup/warmup.module').then( m => m.WarmupPageModule)
  },
  {
    path: 'wodout',
    loadChildren: () => import('./client/wodout/wodout.module').then( m => m.WodoutPageModule)
  },
  {
    path: 'user',
    loadChildren: () => import('./user/user.module').then( m => m.UserPageModule)
  },
  {
    path: 'wod-details',
    loadChildren: () => import('./admin/wod-details/wod-details.module').then( m => m.WodDetailsPageModule)
  },
  {
    path: 'wodgo',
    loadChildren: () => import('./client/wodgo/wodgo.module').then( m => m.WodgoPageModule)
  },
  {
    path: 'modal-content',
    loadChildren: () => import('./client/modal-content/modal-content.module').then( m => m.ModalContentPageModule)
  },
  {
    path: 'wodon',
    loadChildren: () => import('./client/wodon/wodon.module').then( m => m.WodonPageModule)
  },
  {
    path: 'add-user',
    loadChildren: () => import('./admin/add-user/add-user.module').then( m => m.AddUserPageModule)
  },
  {
    path: 'reset-password',
    loadChildren: () => import('./logster/reset-password/reset-password.module').then( m => m.ResetPasswordPageModule)
  },

  
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
