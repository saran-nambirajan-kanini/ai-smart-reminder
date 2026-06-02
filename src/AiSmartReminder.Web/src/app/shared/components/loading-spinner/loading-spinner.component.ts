import { Component, Input } from '@angular/core';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

@Component({
  selector: 'app-loading-spinner',
  standalone: true,
  imports: [MatProgressSpinnerModule],
  template: `
    <div class="loading-spinner-container">
      <mat-spinner [diameter]="diameter"></mat-spinner>
    </div>
  `,
  styles: [`
    .loading-spinner-container {
      display: flex;
      justify-content: center;
      align-items: center;
      padding: 16px;
    }
  `],
})
export class LoadingSpinnerComponent {
  @Input() diameter = 40;
}
