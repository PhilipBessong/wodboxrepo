import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User, UserType } from 'src/app/models/wod.model';
import { DataserviceService } from 'src/app/dataservice.service';
import { HttpClient } from '@angular/common/http';
import { NavController, ToastController } from '@ionic/angular';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.page.html',
  styleUrls: ['./add-user.page.scss'],
})
export class AddUserPage   {
  constructor(
    private navCtrl: NavController, // Inject NavController
    private toastController: ToastController,
    private router: Router,
    private dataService: DataserviceService,
    private http: HttpClient
  ) {}

  user = {
    name: '',
    email: '',
    password: '',
    role: '',
  };

  
  addUser() {
    // Create a new instance of Workout

   

    // Call the API service to add the workout
    this.http.post<any>('https://wodvidservice@wodbox-407204.iam.gserviceaccount.com/api/Users', this.user).subscribe(
      async (response) => {
        // Show a success message using a toast
        const toast = await this.toastController.create({
          message: 'User added successfully!',
          duration: 2000, // Duration in milliseconds
          position: 'top', // Position of the toast
        });
        toast.present();

        // Navigate to a different page (e.g., the list of workouts)
        this.router.navigate(['/view-wods']); // Adjust the destination page URL

        // Reset the form and clear fields after a successful addition
      
      },
      (error) => {
        console.error('Error adding User', error);
        // Handle error, show an error message, etc.
      }
    );
  }
  
}
