import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'roundprice'
})
export class RoundpricePipe implements PipeTransform {

  transform(value: number, currency: string): string {
    const decimal = value - Math.floor(value);
    let r: string;
    if (decimal === 0) {
      r = this.setPriceWithCurrency(currency, Math.trunc(value));
    } else {
      r = this.setPriceWithCurrency(currency, value);
    }
    return r;
  }

  setPriceWithCurrency(currency: string, value: number): string {
    let r = '';
    switch (currency) {
      case 'EUR':
        r = value + '€';
        break;
      case 'USD':
        r =  'US$' + value;
        break;
      case 'AUD':
        r = 'AU$' + value;
        break;
    }

    return r;
  }

}
