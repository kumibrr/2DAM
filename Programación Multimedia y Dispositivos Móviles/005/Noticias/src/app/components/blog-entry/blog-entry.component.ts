import { NewsService } from './../../services/news.service';
import { BlogEntry } from './../../class/BlogEntry';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-blog-entry',
  templateUrl: './blog-entry.component.html',
  styleUrls: ['./blog-entry.component.css']
})
export class BlogEntryComponent implements OnInit {

  @Input() entry?: BlogEntry;

  constructor(private newsService: NewsService) { }

  ngOnInit(): void {
  }

  deleteEntry(): void {
    this.newsService.deleteEntry(this.entry);
  }

}
