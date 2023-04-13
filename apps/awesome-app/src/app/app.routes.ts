import { Route } from "@angular/router";
import { WheatherForecastComponent } from "./wheather-forecast/wheather-forecast.component";

export const appRoutes: Route[] = [{
    path:"weather-forecast", component: WheatherForecastComponent
}];
