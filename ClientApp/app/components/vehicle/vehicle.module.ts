import { VehicleService } from './vehicle.service';
import { VehicleFormComponent } from './vehicleForm.component';
import { VehicleComponent } from './vehicle.component';
import { FormsModule, ReactiveFormsModule, FormBuilder, FormGroup } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common'; 


@NgModule({
    imports: [
        FormsModule,
        CommonModule,
        ReactiveFormsModule
    ],
    declarations: [
        VehicleComponent,
        VehicleFormComponent
    ],
    exports: [
        VehicleComponent
    ],
    providers: [
        VehicleService
    ]
})
export class VehilceModule {

}