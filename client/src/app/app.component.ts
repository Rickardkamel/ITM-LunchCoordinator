import { ROUTER_DIRECTIVES } from '@angular/router'
import { Component, ViewContainerRef } from '@angular/core';
import { LunchComponent } from './lunch/lunch.component';
import { LunchCreateComponent } from './lunch/create-lunch/lunch-create.component';
import { ModalComponent } from './modal/modal.component';
import { HeaderComponent } from './layout/header.component';
import { LunchService } from './lunch/lunch.service';
import 'rxjs/rx';
    // <app-modal></app-modal>
@Component({
    moduleId: module.id,
    selector: 'app-start',
    template: `
        <app-header>
        </app-header>
        <router-outlet></router-outlet>
    `,
    directives: [
                LunchComponent,
                LunchCreateComponent,
                HeaderComponent,
                ModalComponent,
                ROUTER_DIRECTIVES,
                ],
    providers: [
        LunchService
    ]
})

export class AppComponent {
    pageName: string = 'Created by Rickard Kamel';

    public constructor(private viewContainerRef: ViewContainerRef) {
    }


}
