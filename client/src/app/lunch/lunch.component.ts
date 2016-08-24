import { Component, OnInit } from '@angular/core';
import { LunchDetailComponent } from './lunch-detail/lunch-detail.component';
import { LunchListComponent } from './lunch-list/lunch-list.component';

// INTERFACE
import { ILunch } from '../interface';



@Component({
    moduleId: module.id,
    selector: 'app-lunch',
    templateUrl: 'lunch.component.html',
    directives: [
        LunchListComponent,
        LunchDetailComponent
    ]
})
export class LunchComponent implements OnInit {
    selectedLunch: ILunch;
    
    constructor() { }

    ngOnInit() { }

}