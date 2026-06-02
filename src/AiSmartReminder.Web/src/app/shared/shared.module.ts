import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSnackBarModule } from '@angular/material/snack-bar';

import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { TruncatePipe } from './pipes/truncate.pipe';

const MATERIAL_MODULES = [
  MatButtonModule,
  MatCardModule,
  MatInputModule,
  MatFormFieldModule,
  MatIconModule,
  MatToolbarModule,
  MatSnackBarModule,
];

@NgModule({
  imports: [
    CommonModule,
    ...MATERIAL_MODULES,
    LoadingSpinnerComponent,
    TruncatePipe,
  ],
  exports: [
    CommonModule,
    ...MATERIAL_MODULES,
    LoadingSpinnerComponent,
    TruncatePipe,
  ],
})
export class SharedModule {}
