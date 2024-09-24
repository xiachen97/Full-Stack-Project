import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UserService } from './services/user-service';
import {  map } from 'rxjs';
import { IUser } from './contracts/user.interface';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'angular-client';
  userService: UserService;
  public userList: IUser[] = [];
  constructor(userService: UserService ){
    this.userService = userService;
  }
  ngOnInit(): void { 
    var obs = this.userService.getUsers().pipe(map((users: any) => {
      this.userList = users;
    }));
    setTimeout(() => {
      obs.subscribe();
    }, 1000);
  }
}
