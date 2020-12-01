import { NewsService } from './../../services/news.service';
import { Component, OnInit } from '@angular/core';
import { BlogEntry } from 'src/app/class/BlogEntry';

@Component({
  selector: 'app-add-entry',
  templateUrl: './add-entry.component.html',
  styleUrls: ['./add-entry.component.css']
})
export class AddEntryComponent implements OnInit {

  constructor(private newsService: NewsService) { }

  ngOnInit(): void {
  }

  submitEntry(title: string, body: string): void {
    this.newsService.addEntry(new BlogEntry(title, body));
  }

}
