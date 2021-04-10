import { Component, OnInit } from '@angular/core';
import { CrickInsight } from '../models/crick-insight';
import { ApiserviceService } from '../services/apiservice.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  instightsByVenue:CrickInsight[]=[];
  instightsByBattingTeam:CrickInsight[]=[];
  instightsByBowlingTeam:CrickInsight[]=[];

  constructor(public apiService: ApiserviceService) {

  }

  ngOnInit() {
    this.getInsightsByVenue();
    this.getInstightsByBattingTeam();
  this.getInstightsByBowlingTeam();
    
  }
  getInsightsByVenue()
  {
    this.apiService.getInsights(1).subscribe(resp => {
      console.log(resp);
      this.instightsByVenue=resp;
    });
  }
  getInstightsByBattingTeam()
  {
    this.apiService.getInsights(2).subscribe(resp => {
      console.log(resp);
      this.instightsByBattingTeam=resp;
    });
  }

  getInstightsByBowlingTeam()
  {
    this.apiService.getInsights(3).subscribe(resp => {
      console.log(resp);
      this.instightsByBowlingTeam=resp;
    });
  }
}
