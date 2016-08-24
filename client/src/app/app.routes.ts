import { LunchCreateComponent } from './lunch/create-lunch/lunch-create.component';
import { LunchComponent } from './lunch/lunch.component';
import { provideRouter, RouterConfig } from '@angular/router';

export const routes: RouterConfig = [
    {
        path: 'create-lunch',
        component: LunchCreateComponent
    },
    {
        path: 'show-lunch',
        component: LunchComponent,
        // children: [
        //     {
        //         path:'',
        //         component: ''
        //     }
        // ]
    },

];

export const APP_ROUTER_PROVIDERS = [
    provideRouter(routes)
];