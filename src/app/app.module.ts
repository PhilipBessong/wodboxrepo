import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { IonicModule, IonicRouteStrategy } from '@ionic/angular';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AlertController } from '@ionic/angular';

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule,FormsModule, // Add this line
  ReactiveFormsModule, HttpClientModule, IonicModule.forRoot(), AppRoutingModule],
  providers: [{ provide: RouteReuseStrategy, useClass: IonicRouteStrategy }, [AlertController]],
  bootstrap: [AppComponent],
})
export class AppModule {}
