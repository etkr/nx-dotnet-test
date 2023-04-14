import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';
import { ApiModule, WeatherForecast, WeatherForecastService } from '@nx-dotnet-test/generated/awesome-api-types';

@Component({
  selector: 'nx-dotnet-test-wheather-forecast',
  standalone: true,
  imports: [CommonModule, ApiModule],
  templateUrl: './wheather-forecast.component.html',
  styleUrls: ['./wheather-forecast.component.scss'],
})
export class WheatherForecastComponent {  
  
  public weatherForecasts$: Observable<Array<WeatherForecast>>;

  constructor(private weatherForecastService: WeatherForecastService) {
    this.weatherForecasts$ = weatherForecastService.getWeatherForecast();
  }
}
