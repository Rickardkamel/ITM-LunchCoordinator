import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { CORE_DIRECTIVES } from '@angular/common';
import { FORM_DIRECTIVES } from '@angular/forms';
import { LunchService } from '../lunch.service';
import { DataTableDirectives } from 'angular2-datatable/datatable';
import { ILunch } from '../../interface';


// import {WelcomeComponent} from '../welcome/welcome.component';

@Component({
    moduleId: module.id,
    selector: 'app-lunch-list',
    templateUrl: 'lunch-list.component.html',
    directives: [
        CORE_DIRECTIVES,
        FORM_DIRECTIVES,
        CORE_DIRECTIVES,
        FORM_DIRECTIVES,
        DataTableDirectives,
    ],
})

export class LunchListComponent implements OnInit {
    private data: any[];
    @Output() lunchSelected = new EventEmitter<ILunch>();
    constructor(private lunchService: LunchService) {
    }

    ngOnInit() {

        this.lunchService.getLunches()
            .subscribe(x => this.data = x);
    }

    onSelected(lunch: ILunch) {
        this.lunchSelected.emit(lunch);
        console.log(lunch);
    }


}
