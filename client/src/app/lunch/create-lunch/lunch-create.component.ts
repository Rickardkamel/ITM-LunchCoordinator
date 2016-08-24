import { Component, OnInit } from '@angular/core';
import {REACTIVE_FORM_DIRECTIVES, FORM_DIRECTIVES, FormGroup, FormControl} from '@angular/forms';
import {CORE_DIRECTIVES} from '@angular/common';
import {TimepickerComponent} from 'ng2-bootstrap';
declare var $: any;

@Component({
    moduleId: module.id,
    selector: 'app-lunch-create',
    templateUrl: 'lunch-create.component.html',
    directives: [
        REACTIVE_FORM_DIRECTIVES,
        TimepickerComponent,
        CORE_DIRECTIVES,
        FORM_DIRECTIVES,
    ]
})

export class LunchCreateComponent implements OnInit {

    createForm: FormGroup;
    submittedData: any;
    constructor() { }

    submit(): any {
        this.submittedData = {
            restaurant: this.createForm.value.restaurant,
            time: this.createForm.value.date + ' ' + this.createForm.value.time
        };
        console.log(JSON.stringify(this.submittedData));
    }

    ngOnInit(): any {
        this.createForm = new FormGroup({
            restaurant: new FormControl(),
            date: new FormControl(),
            time: new FormControl(),
        });

        $('#sandbox-container .calendar').datepicker({
            language: 'sv',
            todayHighlight: true,
        }).on('changeDate', e => {

            $('.calendar').closest('.form-group')
                .next('.form-group')
                .find('.sequence')
                .css({ 'visibility': 'visible' })
                .hide()
                .fadeIn('slow');

            $('#date').val(e.format('yyyy-mm-dd'));
            this.createForm.value.date = e.format('yyyy-mm-dd');
        });

        $('.clockpicker').clockpicker({
            autoclose: true,
            donetext: 'Välj',
            afterDone: function () {
            }
        });
        $('.clockpicker').on('change', () => {

            $('.clockpicker').closest('.form-group')
                .next('.form-group')
                .find('.sequence')
                .css({ 'visibility': 'visible' })
                .hide()
                .fadeIn('slow');

            this.createForm.value.time = $('#time').val();
        });

        function fakeValidator(event) {
            let $element = $(event.target);
            if ($element.val().length >= 1) {
                $element.addClass('valid');
            } else {
                $element.removeClass('valid');
            }
        }

        function enableNextElement(event) {
            let $element = $(event.target);
            if ($element.hasClass('valid')) {
                $element.closest('.form-group')
                    .next('.form-group')
                    .find('.sequence')
                    .removeAttr('hidden')
                    .fadeIn('slow');
            }
        }

        $(document).ready(function () {
            $('.sequence').on('change blur keyup', fakeValidator);
            $('.sequence').on('change blur keyup', enableNextElement);
        });
    }
}
