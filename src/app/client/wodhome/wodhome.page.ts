import { Component, OnInit } from '@angular/core';
import { Workout } from 'src/app/models/wod.model';
import { DataserviceService } from 'src/app/dataservice.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-wodhome',
  templateUrl: './wodhome.page.html',
  styleUrls: ['./wodhome.page.scss'],
})
export class WodhomePage implements OnInit {
  constructor(private route: ActivatedRoute,private dataService: DataserviceService) { }

  ngOnInit() {
  
  }



}
