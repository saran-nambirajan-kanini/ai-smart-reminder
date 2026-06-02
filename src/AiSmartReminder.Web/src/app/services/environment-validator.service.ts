import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Environment } from '../../environments/environment.model';

@Injectable({
  providedIn: 'root',
})
export class EnvironmentValidatorService {
  validate(): void {
    const errors = this.getMissingRequiredValues(environment);

    if (errors.length > 0) {
      const message = `[EnvironmentValidator] Missing required environment configuration:\n${errors.map((e) => `  - ${e}`).join('\n')}`;
      console.error(message);
      throw new Error(message);
    }
  }

  private getMissingRequiredValues(env: Environment): string[] {
    const errors: string[] = [];
    const requiredStringFields: Array<keyof Environment> = ['apiBaseUrl', 'appName'];

    for (const field of requiredStringFields) {
      const value = env[field];
      if (value === undefined || value === null || (typeof value === 'string' && value.trim() === '')) {
        errors.push(`"${String(field)}" is required but not configured.`);
      }
    }

    return errors;
  }
}
