import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PqrsComponent } from './components/pqrs/pqrs.component';
import { ListSolicitudComponent } from './components/pqrs/list-solicitud/list-solicitud.component';
import { SolicitudComponent } from './components/pqrs/solicitud/solicitud.component';
import { FooterComponent } from './components/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    PqrsComponent,
    ListSolicitudComponent,
    SolicitudComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
