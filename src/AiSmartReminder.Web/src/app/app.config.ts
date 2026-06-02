import { APP_INITIALIZER, ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideHttpClient, withInterceptors } from '@angular/common/http';

import { routes } from './app.routes';
import { EnvironmentValidatorService } from './services/environment-validator.service';
import { authInterceptor, httpErrorInterceptor } from './core';

function initializeEnvironment(validator: EnvironmentValidatorService): () => void {
  return () => validator.validate();
}

export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideRouter(routes),
    provideHttpClient(withInterceptors([authInterceptor, httpErrorInterceptor])),
    {
      provide: APP_INITIALIZER,
      useFactory: initializeEnvironment,
      deps: [EnvironmentValidatorService],
      multi: true,
    },
  ],
};
