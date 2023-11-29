import { Component, OnInit } from '@angular/core';
import { Style, Workout } from 'src/app/models/wod.model';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { DataserviceService } from 'src/app/dataservice.service';
@Component({
  selector: 'app-wodout',
  templateUrl: './wodout.page.html',
  styleUrls: ['./wodout.page.scss'],
})
export class WodoutPage implements OnInit {

  workouts: Workout[] = []; // Define an array to store the retrieved workouts
  wodStyle: Style[] = [];
  videoHeight = '300px'; // Adjust the height as needed
  videoWidth = '400px'; 
  constructor(
    private route: ActivatedRoute,
    private dataService: DataserviceService,
    private http: HttpClient,
    
   
  ) {}

  ngOnInit() {
    const wodCat = 'WOD';
    // Get today's date in the format yyyy-MM-dd
    const today = new Date().toISOString().slice(0, 10);
    
    this.dataService.getWodworkouts(wodCat, today).subscribe((data) => {
      this.workouts = data; // Store the retrieved workouts in the array

      // Fetch style information for each workout and update the workouts array
      this.workouts.forEach((workout) => {
        this.dataService.getStyleById(workout.styleId).subscribe((style) => {
          // Add style information to each workout
          workout.styleName = style?.styleName;
          workout.styleDescription = style?.styleDescription;
        });
        if(workout.r1m1){
          workout.exe = this.dataService.getExerciseByName(workout.r1m1);
        }
        if (workout.r1m2) {
          workout.exeR1M2 = this.dataService.getExerciseByName(workout.r1m2);
        }
        if (workout.r1m3) {
          workout.exeR1M3 = this.dataService.getExerciseByName(workout.r1m3);
        }
        if (workout.r2m1) {
          workout.exeR2M1 = this.dataService.getExerciseByName(workout.r2m1);
        }
        if (workout.r2m2) {
          workout.exeR2M2 = this.dataService.getExerciseByName(workout.r2m2);
        }
        if (workout.r2m3) {
          workout.exeR2M3 = this.dataService.getExerciseByName(workout.r2m3);
        }
        if (workout.r3m1) {
          workout.exeR3M1 = this.dataService.getExerciseByName(workout.r3m1);
        }
        if (workout.r3m2) {
          workout.exeR3M2 = this.dataService.getExerciseByName(workout.r3m2);
        }
        if (workout.r3m3) {
          workout.exeR3M3 = this.dataService.getExerciseByName(workout.r3m3);
        }
        if (workout.r4m1) {
          workout.exeR4M1 = this.dataService.getExerciseByName(workout.r4m1);
        }
        if (workout.r4m2) {
          workout.exeR4M2 = this.dataService.getExerciseByName(workout.r4m2);
        }
        if (workout.r4m3) {
          workout.exeR4M3 = this.dataService.getExerciseByName(workout.r4m3);
        }
      });
      
    });

    
  }

}
