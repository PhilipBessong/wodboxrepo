import { Component, OnInit } from '@angular/core';
import { Workout } from 'src/app/models/wod.model';
import { AlertController } from '@ionic/angular'; // Import AlertController
import { DataserviceService } from 'src/app/dataservice.service';

@Component({
  selector: 'app-wod-details',
  templateUrl: './wod-details.page.html',
  styleUrls: ['./wod-details.page.scss'],
})
export class WodDetailsPage implements OnInit {
  workout: Workout[] = [];
  constructor(private alertController:AlertController, private dataService: DataserviceService ) { }

  ngOnInit() {
  }
  isDeleting = false;
async confirmDelete(id: number) {
  const alert = await this.alertController.create({
    header: 'Confirm Delete',
    message: 'Are you sure you want to delete this workout?',
    buttons: [
      {
        text: 'Cancel',
        role: 'cancel',
        handler: () => {
          // User canceled, do nothing
        },
      },
      {
        text: 'Delete',
        handler: () => {
          // Set isDeleting flag to true
          this.isDeleting = true;

          // User confirmed, call the deleteWorkout function
          this.deleteWorkout(id);
        },
      },
    ],
  });

  await alert.present();
}

deleteWorkout(id: number) {
  // Make an API call to delete the workout
  this.dataService.deleteWod(id).subscribe(
    () => {
      // Remove the deleted workout from the local array
      this.workout = this.workout.filter((workout) => workout.id !== id);
    },
    (error) => {
      console.error('Error deleting workout', error);
    }
  ).add(() => {
    // Set isDeleting flag back to false after the API call is complete
    this.isDeleting = false;
  });
}

}
