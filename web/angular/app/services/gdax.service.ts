import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

@Injectable()
export class GdaxService {

  constructor(private http: Http) { }

  listAccounts(): Promise<any> {
    return this.http.get('api/gdax')
      .toPromise()
      .then(response => console.log(response))
      .catch(this.handleError);

  }

  handleError(error: any) {
    console.log('error');
  }

}
