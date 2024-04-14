import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatTableModule} from '@angular/material/table';
import { FormsModule } from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import { KolcsonzokComponent } from './kolcsonzok/kolcsonzok.component';

import { MatButtonModule } from '@angular/material/button';
import { KolcsonzesekComponent } from './kolcsonzesek/kolcsonzesek.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    KolcsonzesekComponent,
    KolcsonzokComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule,
    HttpClientModule,
    FormsModule,
    MatButtonModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
