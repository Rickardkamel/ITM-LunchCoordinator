import { Component, OnInit, Input } from '@angular/core';

// INTERFACE
import { ILunch } from '../../interface';

@Component({
  moduleId: module.id,
  selector: 'app-lunch-detail',
  templateUrl: 'lunch-detail.component.html'
})
export class LunchDetailComponent implements OnInit {
  @Input() selectedLunch: ILunch;

  constructor() {}

  ngOnInit() {
  }

}
