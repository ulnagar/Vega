import { Component, OnInit } from '@angular/core';
import { FormsModule, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { VehicleService } from './vehicle.service';

@Component({
    selector: 'vehicle-form',
    templateUrl: './vehicleForm.component.html'
})
export class VehicleFormComponent implements OnInit {
    form: FormGroup;
    title = "New Vehicle";

    makes = [];
    models = [];
    features = [];

    constructor(fb: FormBuilder, private _service: VehicleService) {
        this.form = fb.group({
            Make: ['', Validators.required],
            Model: ['', Validators.required],
            Registered: ['', Validators.required],
            Features: [],
            Contact: fb.group({
                Name: ['', Validators.required],
                Phone: ['', Validators.required],
                Email: ['', Validators.required]
            })
        });
    }

    ngOnInit() {
        this._service.getMakes().subscribe(response => this.makes = response);
        this._service.getFeatures().subscribe(response => this.features = response);
    }

    onSelectMake(){
        var makeIndex = this.form.get('Make').value;
        var selectedMake = this.makes.find(make => make.id == makeIndex);
        this.models = selectedMake.models;
    }

    onFeatureChange(value){
        var currentSelected = [];
        currentSelected = this.form.get('Features').value;

        var newSelected = currentSelected;
        if (currentSelected == null){
            newSelected = [ value ];
        } else if (currentSelected.indexOf(value) == -1) {
            newSelected.push(value);
        } else {
            newSelected.splice(currentSelected.indexOf(value), 1);
        }
        
        this.form.get('Features').setValue(newSelected);
    }

    save(){
        console.log(this.form.value);
    }
}