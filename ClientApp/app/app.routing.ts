import { HomeComponent } from './components/home/home.component';
import { Router, RouterModule } from '@angular/router';

export const Routing = RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: '**', redirectTo: 'home' }
        ]);