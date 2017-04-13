import { Router, RouterModule } from '@angular/router';

import { VehicleFormComponent } from './vehicleForm.component';
import { VehicleComponent } from './vehicle.component';

export const VehicleRouting = RouterModule.forChild([
            { path: 'vehicles', component: VehicleComponent },
            { path: 'vehicles/new', component: VehicleFormComponent }
        ]);