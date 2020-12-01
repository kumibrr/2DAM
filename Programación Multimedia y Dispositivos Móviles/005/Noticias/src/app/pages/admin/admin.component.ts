import { BlogEntry } from './../../class/BlogEntry';
import { NewsService } from './../../services/news.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  constructor(public newsService: NewsService) { }

  ngOnInit(): void {}

}
