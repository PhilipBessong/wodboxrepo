import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { DataserviceService } from 'src/app/dataservice.service';
@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.page.html',
  styleUrls: ['./reset-password.page.scss'],
})
export class ResetPasswordPage {
  email: string = '';

  constructor(
    private http: HttpClient,
    private dataService: DataserviceService,
    private router: Router
  ) {}

  resetPassword() {
    this.dataService.resetPassword(this.email).subscribe(
      () => {
        this.router.navigate(['/complete-reset', { email: this.email }]);
      },
      (error) => {
        console.error(error);
        // Handle error, e.g., show an alert
      }
    );
  }
}
