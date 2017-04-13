import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class VehicleService {
    private _url = "http://localhost:56843/api/";

    constructor(private _http: Http) {
    }

    getMakes() {
        return this._http.get(this._url + "makes")
            .map(res => res.json());
    }
    
    getFeatures() {
        return this._http.get(this._url + "features")
            .map(res => res.json());
    }
}