import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import { DataserviceService } from 'src/app/dataservice.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {
  email: string = '';
  password: string = '';
  private jwtHelper: JwtHelperService = new JwtHelperService();

  constructor(
    private router: Router,
    private dataService: DataserviceService,
    private http: HttpClient
  ) {}

  ngOnInit() {}

  login() {
    const credentials = { email: this.email, password: this.password, role: 'Admin' };

    this.http
      .post<any>('https://https://wodbox.appspot.com/api/Users/login', credentials)
      .subscribe(
        (response) => {
          localStorage.setItem('token', response.token);
          console.log('Server Response:', response);
          if (response.token) {
            const decodedToken = this.jwtHelper.decodeToken(response.token);
            console.log('Decoded Token:', decodedToken);
            if (this.jwtHelper.isTokenExpired(response.token)) {
              console.error('Token is expired');
            } else {
              console.log('Token is valid and not expired');

              const role = decodedToken.role;
              this.redirectToDashboard(role);
            }
          } else {
            console.error('Invalid token');
          }
        },
        (error) => {
          console.error('Login failed', error);
        }
      );
  }

  redirectToDashboard(role: string) {
    if (role === 'Admin') {
      // Redirect to Admin Dashboard
      this.router.navigate(['/view-wods']);
    } else if (role === 'Client') {
      // Redirect to Client Dashboard
      this.router.navigate(['/wodcat']);
    } else {
      console.error('Invalid login details');
    }
  }
}
