import { NewsService } from './../../services/news.service';
import { BlogEntry } from './../../class/BlogEntry';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-blog-entry',
  templateUrl: './blog-entry.component.html',
  styleUrls: ['./blog-entry.component.css']
})
export class BlogEntryComponent implements OnInit {

  @Input() entry?: BlogEntry;
  @Output() delete = new EventEmitter<BlogEntry>();

  constructor() { }

  ngOnInit(): void {
  }

  deleteEntry(): void {
    this.delete.emit(this.entry);
  }

}
