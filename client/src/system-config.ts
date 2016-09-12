// SystemJS configuration file, see links for more information
// https://github.com/systemjs/systemjs
// https://github.com/systemjs/systemjs/blob/master/docs/config-api.md

/***********************************************************************************************
 * User Configuration.
 **********************************************************************************************/
/** Map relative paths to URLs. */
const map: any = {
  'ng2-bootstrap': 'vendor/ng2-bootstrap',
  'moment': 'vendor/moment/moment.js',
  'jquery': 'vendor/jquery/dist/jquery.js',
  'angular2-local-storage': 'vendor/angular2-local-storage/local_storage.js',
  'bootstrap-datepicker': 'vendor/bootstrap-datepicker/dist/',
  'clockpicker-gh-pages': 'vendor/clockpicker-gh-pages/dist/',
  'ng2-select': 'vendor/ng2-select/',
  'lodash': 'https://unpkg.com/lodash@4.6.1/lodash.js',
  'angular2-datatable': 'vendor/angular2-datatable'
};

/** User packages configuration. */
const packages: any = {
  'ng2-bootstrap': {
    format: 'cjs',
    defaultExtension: 'js',
    main: 'ng2-bootstrap.js'
  },
  'angular2-local-storage': { defaultExtension: 'js' },
  'bootstrap-datepicker': { defaultExtension: 'js' },
  'jquery': { defaultExtension: 'js' },
  'clockpicker-gh-pages': { defaultExtension: 'js' },
  'moment': { defaultExtension: 'js' },
  'ng2-select': {
    format: 'cjs',
    defaultExtension: 'js',
    main: 'ng2-select.js'
  },
  'angular2-datatable': {defaultExtension: 'js'}
};

////////////////////////////////////////////////////////////////////////////////////////////////
/***********************************************************************************************
 * Everything underneath this line is managed by the CLI.
 **********************************************************************************************/
const barrels: string[] = [
  // Angular specific barrels.
  '@angular/core',
  '@angular/common',
  '@angular/compiler',
  '@angular/forms',
  '@angular/http',
  '@angular/router',
  '@angular/platform-browser',
  '@angular/platform-browser-dynamic',

  // Thirdparty barrels.
  'rxjs',

  // App specific barrels.
  'app',
  'app/shared',
  /** @cli-barrel */
];

const cliSystemConfigPackages: any = {};
barrels.forEach((barrelName: string) => {
  cliSystemConfigPackages[barrelName] = { main: 'index' };
});

/** Type declaration for ambient System. */
declare var System: any;

// Apply the CLI SystemJS configuration.
System.config({
  map: {
    '@angular': 'vendor/@angular',
    'rxjs': 'vendor/rxjs',
    'main': 'main.js'
  },
  packages: cliSystemConfigPackages
});

// Apply the user's configuration.
System.config({ map, packages });
