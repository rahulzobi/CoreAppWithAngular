import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { Observable } from 'rxjs';
import { User } from '../../models/user';
import { UserService } from '../../services/user.service';

declare var $: any;

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  lstUser = [];

  constructor(private userService: UserService, public router: Router) { }

  ngOnInit() {
    this.GetAllUsers();
  }

  GetAllUsers()
  {
    this.userService.GetAllUsers()
      .subscribe(
        response => {
          this.lstUser = response;
        },
        error => {
          console.log(error);
          if(error.status == 400)
          {
            alert(error);
          }
        });
  }

}
