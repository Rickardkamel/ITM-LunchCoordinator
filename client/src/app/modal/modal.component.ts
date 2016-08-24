import { Component, ViewChild, AfterViewInit } from '@angular/core';
import {ROUTER_DIRECTIVES, Router} from '@angular/router';
import {MODAL_DIRECTIVES, BS_VIEW_PROVIDERS} from 'ng2-bootstrap/ng2-bootstrap';
import {CORE_DIRECTIVES, FORM_DIRECTIVES, NgClass} from '@angular/common';
import {ModalDirective} from 'ng2-bootstrap/components/modal/modal.component';
import {BUTTON_DIRECTIVES } from 'ng2-bootstrap/ng2-bootstrap';
import {SELECT_DIRECTIVES} from 'ng2-select';


@Component({
    moduleId: module.id,
    selector: 'app-modal',
    templateUrl: 'modal.component.html',
    directives: [MODAL_DIRECTIVES,
        CORE_DIRECTIVES,
        ROUTER_DIRECTIVES,
        FORM_DIRECTIVES,
        NgClass,
        BUTTON_DIRECTIVES,
        SELECT_DIRECTIVES],
    viewProviders: [
        BS_VIEW_PROVIDERS,
    ],
})

export class ModalComponent implements AfterViewInit {

    userObject = { name: '', city: '' };

    @ViewChild('staticModal') public staticModal: ModalDirective;

    constructor(private router: Router) {
    }

    public showModal(): void {
        this.staticModal.show();
    }

    public hideModal(): void {
        this.staticModal.hide();
        window.localStorage.setItem('userObject', JSON.stringify(this.userObject));
        this.router.navigate(['show-lunch']);
    }

    ngAfterViewInit(): any {
        this.showModal();
    }
}
