import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  imports: [ RouterModule, CommonModule],
  providers: [],
  selector: 'nx-dotnet-test-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'awesome-app';
}
