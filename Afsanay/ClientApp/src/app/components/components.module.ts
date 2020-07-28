import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { NouisliderModule } from 'ng2-nouislider';
import { JwBootstrapSwitchNg2Module } from 'jw-bootstrap-switch-ng2';
import { RouterModule, Routes } from '@angular/router';

import { BasicelementsComponent } from './basicelements/basicelements.component';
import { NavigationComponent } from './navigation/navigation.component';
import { TypographyComponent } from './typography/typography.component';
import { NucleoiconsComponent } from './nucleoicons/nucleoicons.component';
import { ComponentsComponent } from './components.component';
import { NotificationComponent } from './notification/notification.component';
import { NgbdModalComponent } from './modal/modal.component';
import { NgbdModalContent } from './modal/modal.component';
import { ImageCardComponent } from 'app/shared/image-card/image-card.component';
import { MultiProductsCarouselComponent } from 'app/shared/multi-products-carousel/multi-products-carousel.component';
import { MatCardModule } from '@angular/material/card';
import { MDBBootstrapModule } from 'angular-bootstrap-md';

const routes: Routes = [ { path: 'product-list', component: ImageCardComponent } ];
@NgModule({
	imports: [
		CommonModule,
		FormsModule,
		NgbModule,
		NouisliderModule,
		RouterModule,
		JwBootstrapSwitchNg2Module,
		MatCardModule,
		MDBBootstrapModule.forRoot(),
		RouterModule.forChild(routes)
	],
	declarations: [
		ComponentsComponent,
		BasicelementsComponent,
		NavigationComponent,
		TypographyComponent,
		NucleoiconsComponent,
		NotificationComponent,
		NgbdModalComponent,
		NgbdModalContent,
		ImageCardComponent,
		MultiProductsCarouselComponent
	],
	entryComponents: [ NgbdModalContent ],
	exports: [ ComponentsComponent ]
})
export class ComponentsModule {}
