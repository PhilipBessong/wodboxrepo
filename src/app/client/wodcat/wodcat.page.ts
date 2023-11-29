import { Component, OnInit } from '@angular/core';
import { DataserviceService } from 'src/app/dataservice.service';
import { Workout } from 'src/app/models/wod.model';
import { NavController } from '@ionic/angular';
import { Router } from '@angular/router';
@Component({
  selector: 'app-wodcat',
  templateUrl: './wodcat.page.html',
  styleUrls: ['./wodcat.page.scss'],
})
export class WodcatPage implements OnInit {
  workouts: Workout[] = [];
  constructor(
    private dataService: DataserviceService, private router: Router) { }
    
  ngOnInit() {
  }
  logout() {
  this.router.navigate(['/login'])
  }
  //async
   toWarmup() {
   
   this.router.navigate(['/warmup']);
  }
}
