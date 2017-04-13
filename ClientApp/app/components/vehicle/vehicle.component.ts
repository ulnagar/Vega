import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'vehicle',
    templateUrl: './vehicle.component.html'
})
export class VehicleComponent {

    constructor(private _router: Router) {
        
    }

    newVehicle() {
        this._router.navigate(['vehicles/new']);
    }
}