import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutingModule } from './app.routing';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppComponent } from './app.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { FooterComponent } from './shared/footer/footer.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { ComponentsModule } from './components/components.module';
import { ExamplesModule } from './examples/examples.module';
import { ImageCardComponent } from './shared/image-card/image-card.component';
import { MatSliderModule } from '@angular/material/slider';
import { ListProductsComponent } from './shared/list-products/list-products.component';

const routes: Routes = [ { path: 'product-list', component: ListProductsComponent } ];

@NgModule({
	declarations: [ AppComponent, NavbarComponent, FooterComponent, ListProductsComponent ],
	imports: [
		BrowserModule,
		BrowserAnimationsModule,
		MatCardModule,
		MatButtonModule,
		NgbModule,
		FormsModule,
		RouterModule,
		ComponentsModule,
		ExamplesModule,
		AppRoutingModule,
		MatSliderModule,
		ReactiveFormsModule,
		RouterModule.forRoot(routes)
	],
	providers: [],
	bootstrap: [ AppComponent ]
})
export class AppModule {}
