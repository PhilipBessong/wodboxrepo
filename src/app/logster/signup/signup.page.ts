import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.page.html',
  styleUrls: ['./signup.page.scss'],
})
export class SignupPage implements OnInit {

  constructor(private http: HttpClient, private router: Router) { }
  name: string = '';
  email: string = '';
  password: string = '';
  ngOnInit() {
  }
  signUp() {
    const user = {
      name: this.name,
      email: this.email,
      password: this.password,
      role: 'Client',
    };

    this.http.post<any>('https://localhost:7013/api/Users', user).subscribe(
      (response) => {
        console.log('User signed up successfully', response);
        // Redirect to login or another page
        this.router.navigate(['/wodcat']);
      },
      (error) => {
        console.error('Error signing up', error);
      }
    );
  }
}
