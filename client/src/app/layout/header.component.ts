import {ROUTER_DIRECTIVES } from '@angular/router';
import { Component } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'app-header',
    templateUrl: 'header.component.html',
    directives: [ROUTER_DIRECTIVES],
})
export class HeaderComponent {

    constructor() { }


}
