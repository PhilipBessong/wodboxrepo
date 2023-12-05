import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpErrorResponse  } from '@angular/common/http';
@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.page.html',
  styleUrls: ['./reset-password.page.scss'],
})
export class ResetPasswordPage implements OnInit {

  email: string = '';

  constructor(private http: HttpClient) {}

  resetPassword() {
    const resetRequest = { email: this.email };
    this.http.post('http://localhost:7013/api/Users/reset-password', resetRequest)
      .subscribe(response => {
        console.log('Password reset token sent successfully', response);
      }, (error: HttpErrorResponse) => {
        console.error('Error sending reset token:', error);
      });
  }

  ngOnInit() {
  }

}
