import { BlogEntry } from './../class/BlogEntry';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NewsService {

  constructor() { }

  public entries: BlogEntry[] = [new BlogEntry('Un lorem entra perfe', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed id velit at sapien eleifend imperdiet semper eu libero. Duis nec sollicitudin nisl. Vivamus scelerisque nisl ac sollicitudin tincidunt. Proin condimentum est sed erat viverra, nec aliquet nulla lobortis. Maecenas vitae hendrerit felis. Sed scelerisque dignissim justo at iaculis. Vestibulum mi velit, pellentesque in risus id, accumsan auctor massa. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ultrices, mi vel rhoncus feugiat, nunc lectus accumsan felis, eget accumsan nulla sapien nec massa. Aenean sit amet elit mollis, tincidunt est eget, malesuada risus. Phasellus turpis risus, faucibus quis mollis volutpat, malesuada ut neque. Aliquam in velit purus. Maecenas sed elementum ligula. Integer eget justo non enim ultrices accumsan ac eu nunc. Maecenas et sem quis quam dignissim tincidunt. Sed faucibus urna eget quam faucibus, sit amet eleifend purus eleifend.')];

  addEntry(entry: BlogEntry): void {
    this.entries.push(entry);
  }

  deleteEntry(entry?: BlogEntry): void {
    if (entry !== undefined) {
      this.entries.splice(this.entries.indexOf(entry), 1);
    }
  }
}
