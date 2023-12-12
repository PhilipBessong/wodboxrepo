import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DataserviceService } from 'src/app/dataservice.service';
@Component({
  selector: 'app-complete-reset',
  templateUrl: './complete-reset.page.html',
  styleUrls: ['./complete-reset.page.scss'],
})
export class CompleteResetPage  {
  email: string = '';
  resetToken: string= '';
  newPassword: string= '';
  constructor(private dataService: DataserviceService, private route: ActivatedRoute, private router: Router) {
    this.route.params.subscribe((params) => {
      this.email = params['email'];
    });}

    completeResetPassword() {
      this.dataService.completeResetPassword(this.email, this.resetToken, this.newPassword).subscribe(
        () => {
          // Password reset successful, you can redirect to login or another page
          this.router.navigate(['/login']);
        },
        (error) => {
          console.error(error);
          // Handle error, e.g., show an alert
        }
      );
    }

}
