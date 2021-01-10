import { Component, ElementRef, Input, OnInit, Renderer2, ViewChild } from '@angular/core';

@Component({
  selector: 'app-image-gallery',
  templateUrl: './image-gallery.component.html',
  styleUrls: ['./image-gallery.component.css']
})
export class ImageGalleryComponent implements OnInit {

  @ViewChild('prevBtn', {static: false, read: ElementRef}) prevBtn: ElementRef | undefined;
  @ViewChild('nextBtn', {static: false, read: ElementRef}) nextBtn: ElementRef | undefined;
  @ViewChild('galleryPosition', {static: false, read: ElementRef}) galleryPosition: ElementRef | undefined;

  @Input() imageArray: Array<string> = [];

  public galleryIndex = 0;
  public galleryLength = 0;

  constructor(private renderer2: Renderer2) { }

  ngOnInit(): void {
    this.galleryLength = this.imageArray.length;
  }

  mouseOverGallery(): void {
    this.renderer2.removeClass(this.prevBtn?.nativeElement, 'no-visibility');
    this.renderer2.removeClass(this.nextBtn?.nativeElement, 'no-visibility');
    this.renderer2.removeClass(this.galleryPosition?.nativeElement, 'no-visibility');
    console.log(this.imageArray[0]);
  }

  mouseLeaveGallery(): void {
    this.renderer2.addClass(this.prevBtn?.nativeElement, 'no-visibility');
    this.renderer2.addClass(this.nextBtn?.nativeElement, 'no-visibility');
    this.renderer2.addClass(this.galleryPosition?.nativeElement, 'no-visibility');
  }

}
