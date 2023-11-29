import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Workout } from 'src/app/models/wod.model';
import { DataserviceService } from 'src/app/dataservice.service';
import { ModalController } from '@ionic/angular';
import { WodDetailsPage } from '../wod-details/wod-details.page';
import { ToastController } from '@ionic/angular';
import { AlertController } from '@ionic/angular'; // Import AlertController
@Component({
  selector: 'app-view-wods',
  templateUrl: './view-wods.page.html',
  styleUrls: ['./view-wods.page.scss'],
})
export class ViewWodsPage implements OnInit {
  constructor(
    private router: Router,
    private dataService: DataserviceService,
    private toastController: ToastController,
    private alertController: AlertController,
    private modalController: ModalController
  ) {}
  deleteWorkout(workoutId: number): void {
    this.dataService.deleteWorkout(workoutId).subscribe(
      () => {
        // Handle successful deletion
        console.log('Workout deleted successfully.');
        // Navigate back to the same page to refresh
        this.router.navigate(['/view-wods']);
      },
      (error) => {
        // Handle the error if the deletion fails
        console.error('Error deleting workout:', error);
      }
    );
  }

  ngOnInit() {
    this.loadWods();
  }

  ////////////////////////////
  todaAddwod() {
    this.router.navigate(['/add-wod']);
  }
  todaAdduser() {
    this.router.navigate(['/add-user']);
  }

  workout: Workout[] = [];
  loadWods() {
    this.dataService.getAllWods().subscribe((workout) => {
      this.workout = workout;
    });
  }

 


}
