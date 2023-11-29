import { Component, OnInit } from '@angular/core';
import { DataserviceService } from '../dataservice.service';

import { HttpClient } from '@angular/common/http';
import { Exercise, User,  } from '../models/wod.model';
@Component({
  selector: 'app-user',
  templateUrl: './user.page.html',
  styleUrls: ['./user.page.scss'],
})
export class UserPage implements OnInit {
  users: User[] = [];
  newUser: User = {
    userId: 0,
    name: '',
    email: '',

    password: '',
   role: '',
  };
  exes: Exercise[] = [];
 
  constructor(private dataService: DataserviceService, private http: HttpClient) { }

  ngOnInit() {
    this.dataService.getExercises().subscribe((data) => {
      this.exes = data;
    });
    
    this.loadUsers();
  }

  
  loadUsers() {
    this.dataService.getUsers().subscribe(
      (data) => {
        this.users = data;
      },
      (error) => {
        console.error('Error loading users', error);
      }
    );
  }

  addUser(data: User) {
    this.http.post('https://localhost:7013/api/Users', data).subscribe((result)=>{
      console.warn("result",result)
    })
    console.warn(data)
  }

}
