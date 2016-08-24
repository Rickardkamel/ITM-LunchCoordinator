import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { GlobalVariableService } from '../shared/global-variable.service';

import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';

@Injectable()
export class LunchService {
    private apiUrl = this.globalVariableService.apiUrl;

    constructor(private _http: Http,
                     private globalVariableService: GlobalVariableService) { }

    getLunches() {
        return this._http.get(this.apiUrl + 'lunch')
            .map((response: Response) => response.json())
            .do(data => console.log('All: ' +  JSON.stringify(data)));
    }
}
