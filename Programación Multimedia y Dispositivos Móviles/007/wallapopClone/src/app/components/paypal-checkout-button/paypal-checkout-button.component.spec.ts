import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaypalCheckoutButtonComponent } from './paypal-checkout-button.component';

describe('PaypalCheckoutButtonComponent', () => {
  let component: PaypalCheckoutButtonComponent;
  let fixture: ComponentFixture<PaypalCheckoutButtonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaypalCheckoutButtonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaypalCheckoutButtonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
