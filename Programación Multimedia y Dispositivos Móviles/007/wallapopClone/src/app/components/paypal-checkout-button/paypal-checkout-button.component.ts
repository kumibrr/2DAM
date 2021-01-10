import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-paypal-checkout-button',
  templateUrl: './paypal-checkout-button.component.html',
  styleUrls: ['./paypal-checkout-button.component.css']
})
export class PaypalCheckoutButtonComponent implements OnInit {

  private amount: number = 0;

  paypalConfig: any = {
    env: 'sandbox',
    client: {
      sandbox: ''
    },
    commit: true,
    payment: (data: any, actions: any) => {
      return actions.payment.create({
        payment: {
          transactions: [
            { amount: { total: this.amount, currency: 'EUR' } }
          ]
        }
      });
    },
    onAuthorize: (data: any, actions: any) => {
      return actions.payment.execute().then(payment => {
        console.log('g3t pagado');
      });
    }
  };

  constructor() { }

  ngOnInit(): void {
  }

}
