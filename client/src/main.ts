import { bootstrap } from '@angular/platform-browser-dynamic';
import { enableProdMode} from '@angular/core';
import { AppComponent, environment } from './app/';
import {HTTP_PROVIDERS} from '@angular/http';
import {APP_ROUTER_PROVIDERS} from './app/app.routes';
import {disableDeprecatedForms, provideForms} from '@angular/forms';
import { GlobalVariableService } from './app/shared/global-variable.service';
if (environment.production) {
  enableProdMode();
}

bootstrap(AppComponent, [
  APP_ROUTER_PROVIDERS,
  GlobalVariableService,
  HTTP_PROVIDERS, disableDeprecatedForms(),
  provideForms(),
]);

