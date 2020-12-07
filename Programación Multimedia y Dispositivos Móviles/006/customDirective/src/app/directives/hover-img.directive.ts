import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appHoverImg]',
})

export class HoverImgDirective {

  @HostListener('mouseover')
  onMouseOver() {
    this.el.nativeElement.src = './../assets/2.png';
    this.el.nativeElement.style = 'border: 1em solid green';
  }

  @HostListener('mouseout')
  onMouseOut() {
    this.el.nativeElement.src = './../assets/1.png';
    this.el.nativeElement.style = 'border: none';
  }
  constructor(private el: ElementRef) { }

}
