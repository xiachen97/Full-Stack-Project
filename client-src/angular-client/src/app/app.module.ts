import { BrowserModule } from '@angular/platform-browser';
import { NgModule, provideZoneChangeDetection } from '@angular/core';
import { AppComponent } from './app.component';
import { UserService } from './services/user-service';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideHttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
@NgModule({
  imports: [
    BrowserModule,
    CommonModule
  ],
  declarations: [
    AppComponent
],
  providers:[provideZoneChangeDetection({ eventCoalescing: true }), provideRouter(routes), provideHttpClient(), {provide: UserService}],
  bootstrap: [AppComponent]
})
export class AppModule { }