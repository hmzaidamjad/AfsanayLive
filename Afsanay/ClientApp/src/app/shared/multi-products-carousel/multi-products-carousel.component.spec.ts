import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MultiProductsCarouselComponent } from './multi-products-carousel.component';

describe('MultiProductsCarouselComponent', () => {
  let component: MultiProductsCarouselComponent;
  let fixture: ComponentFixture<MultiProductsCarouselComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MultiProductsCarouselComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MultiProductsCarouselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
