import { Component, OnInit } from '@angular/core';

import { GdaxService } from './services/gdax.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app works!';

  constructor(private gdax: GdaxService) { }

  ngOnInit(): void {
    this.gdax.listAccounts().then(response => {
      console.log(response);
    })
  }

}
