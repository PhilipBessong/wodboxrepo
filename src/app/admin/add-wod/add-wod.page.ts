import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Workout, Style, Exercise } from 'src/app/models/wod.model';
import { DataserviceService } from 'src/app/dataservice.service';
import { HttpClient } from '@angular/common/http';
import { NavController, ToastController } from '@ionic/angular';

@Component({
  selector: 'app-add-wod',
  templateUrl: './add-wod.page.html',
  styleUrls: ['./add-wod.page.scss'],
})
export class AddWodPage implements OnInit {
  workouts: Workout[] = [];
  newWorkout: Workout = {
    id: 0,
    wodCat: '',
    styleId: 0,
    rounds: 0,
    mpr: 0,
    r1m1: '',
    r1m2: '',
    r1m3: '',
    r1sets: 0,
    r1move: 0,
    r1rest: 0,
    r2m1: '',
    r2m2: '',
    r2m3: '',
    r2sets: 0,
    r2move: 0,
    r2rest: 0,
    r3m1: '',
    r3m2: '',
    r3m3: '',
    r3sets: 0,
    r3move: 0,
    r3rest: 0,
    r4m1: '',
    r4m2: '',
    r4m3: '',
    r4sets: 0,
    r4move: 0,
    r4rest: 0,
    daDate: '',
  };
  
  styles: Style[]=[];
  moves: Exercise[]=[];

  mprs: number = 0;
  selectedNumber: number = 0;

  constructor(
    private navCtrl: NavController, // Inject NavController
    private toastController: ToastController,
    private router: Router, private dataService: DataserviceService, private http: HttpClient) {}

  ngOnInit() {
 
    this.loadStyles();
    this.loadMoves();
  }

  loadStyles() {
    // Call the getAllWodStyles() function from your data service
    this.styles = this.dataService.getAllWodStyles();
  }
  loadMoves(){
    this.moves = this.dataService.getAllMoves();
  }



  createWod() {
    // Create a new instance of Workout
    const currentDate = new Date();
    this.newWorkout.daDate = currentDate.toISOString();

    console.log('Data to be sent to the API:', this.newWorkout);



    // Call the API service to add the workout
    this.dataService.createWod(this.newWorkout).subscribe(
      async (response) => {
        // Show a success message using a toast
        const toast = await this.toastController.create({
          message: 'Workout added successfully!',
          duration: 2000, // Duration in milliseconds
          position: 'top', // Position of the toast
        });
        toast.present();

        // Navigate to a different page (e.g., the list of workouts)
        this.router.navigate(['/view-wods']); // Adjust the destination page URL

        // Reset the form and clear fields after a successful addition
        this.resetForm();
      },
      (error) => {
        console.error('Error adding workout', error);
        // Handle error, show an error message, etc.
      }
    );
  }
  
  // Helper method to reset the form after submission
  resetForm() {
    this.newWorkout = {
      id: 0,
      wodCat: '',
      styleId: 0,
      rounds: 0,
      mpr: 0,
      r1m1: '',
      r1m2: '',
      r1m3: '',
      r1sets: 0,
      r1move: 0,
      r1rest: 0,
      r2m1: '',
      r2m2: '',
      r2m3: '',
      r2sets: 0,
      r2move: 0,
      r2rest: 0,
      r3m1: '',
      r3m2: '',
      r3m3: '',
      r3sets: 0,
      r3move: 0,
      r3rest: 0,
      r4m1: '',
      r4m2: '',
      r4m3: '',
      r4sets: 0,
      r4move: 0,
      r4rest: 0,
      daDate: '',
    };

    this.selectedNumber = 0;
    this.mprs = 0;

    // You can reset other form-related variables if needed
  }
}
