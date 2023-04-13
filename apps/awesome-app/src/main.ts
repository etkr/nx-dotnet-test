import { bootstrapApplication } from "@angular/platform-browser";
import {
  provideRouter,
  withEnabledBlockingInitialNavigation,
} from "@angular/router";
import { appRoutes } from "./app/app.routes";
import { AppComponent } from "./app/app.component";
import { HttpClientModule } from "@angular/common/http";
import { importProvidersFrom } from "@angular/core";
import { BASE_PATH } from "@nx-dotnet-test/generated/awesome-api-types";

bootstrapApplication(AppComponent, {
  providers: [provideRouter(appRoutes, withEnabledBlockingInitialNavigation() ), importProvidersFrom(HttpClientModule), { provide: BASE_PATH, useValue: 'http://localhost:5251' }],
}).catch((err) => console.error(err));
