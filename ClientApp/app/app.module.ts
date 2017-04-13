import { NgModule } from '@angular/core';
import { UniversalModule } from 'angular2-universal';

import { Routing } from './app.routing';
import { VehicleRouting } from './components/vehicle/vehicle.routing';
import { VehilceModule } from './components/vehicle/vehicle.module';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';


@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        VehilceModule,
        VehicleRouting,
        Routing
    ]
})
export class AppModule {
}
