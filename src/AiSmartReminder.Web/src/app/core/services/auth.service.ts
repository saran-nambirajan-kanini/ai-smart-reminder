import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

const TOKEN_KEY = 'auth_token';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  login(_credentials: { email: string; password: string }): Observable<boolean> {
    // Stub: replace with actual API call that returns a token
    localStorage.setItem(TOKEN_KEY, 'stub-token');
    return of(true);
  }

  logout(): void {
    localStorage.removeItem(TOKEN_KEY);
  }

  isAuthenticated(): boolean {
    return !!this.getToken();
  }

  getToken(): string | null {
    return localStorage.getItem(TOKEN_KEY);
  }
}
