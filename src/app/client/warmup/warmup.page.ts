import { Component, OnInit } from '@angular/core';
import { DatePipe } from '@angular/common';
import { Style, Workout, Exercises, Exercise } from 'src/app/models/wod.model';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { NavController } from '@ionic/angular';
import { DataserviceService } from 'src/app/dataservice.service';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';

@Component({
  selector: 'app-warmup',
  templateUrl: './warmup.page.html',
  providers: [DatePipe],
  styleUrls: ['./warmup.page.scss'],
})
export class WarmupPage implements OnInit {
  workouts: Workout[] = []; // Define an array to store the retrieved workouts
  wodStyle: Style[] = [];
  exercises: Exercises[]=[];
  videoUrl: SafeResourceUrl | undefined;
  videoHeight = '300px'; // Adjust the height as needed
  videoWidth = '400px';
  constructor(
    private route: ActivatedRoute,
    private dataService: DataserviceService,
    private http: HttpClient,
    private datePipe: DatePipe,
    private sanitizer: DomSanitizer
  ) {}

  ngOnInit() {
    const wodCat = 'Warm Up';
    // Get today's date in the format yyyy-MM-dd
    const today = new Date().toISOString().slice(0, 10);

    this.dataService.getWorkoutsByCriteria(wodCat, today).subscribe((data) => {
      this.workouts = data; // Store the retrieved workouts in the array

      // Fetch style information for each workout and update the workouts array
      this.workouts.forEach((workout) => {
        this.dataService.getStyleById(workout.styleId).subscribe((style) => {
          // Add style information to each workout
          workout.styleName = style?.styleName;
          workout.styleDescription = style?.styleDescription;
        });


        //begin showing workouts from r1 if they exit within the retrieved worout.

        if (workout.r1m1) {
          const exeName = workout.r1m1;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
            workout.exe = exercises;
          });
        }
        if (workout.r1m2) {
          const exeName = workout.r1m2;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR1M2 = exercises;
        });
        }
        if (workout.r1m3) {
          const exeName = workout.r1m3;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR1M3 = exercises;
        });
        }
        if (workout.r2m1) {
          const exeName = workout.r2m1;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR2M1 = exercises;
        });
        }
        if (workout.r2m2) {
          const exeName = workout.r2m2;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR2M2 = exercises;
        });
        }
        if (workout.r2m3) {
          const exeName = workout.r2m3;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR2M3 = exercises;
        });
        }
        if (workout.r3m1) {
          const exeName = workout.r3m1;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR3M1 = exercises;
        });
        }
        if (workout.r3m2) {
          const exeName = workout.r3m2;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR3M2 = exercises;
        });
        }
        if (workout.r3m3) {
          const exeName = workout.r3m3;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR3M3 = exercises;
        });
        }
        if (workout.r4m1) {
          const exeName = workout.r4m1;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR4M1 = exercises;
        });
        }
        if (workout.r4m2) {
          const exeName = workout.r4m2;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR4M2 = exercises;
        });
        }
        if (workout.r4m3) {
          const exeName = workout.r4m3;
          this.dataService.getExebyname(exeName).subscribe((exercises) => {
          workout.exeR4M3 = exercises;
        });
        }
      });
    });
  }
}
