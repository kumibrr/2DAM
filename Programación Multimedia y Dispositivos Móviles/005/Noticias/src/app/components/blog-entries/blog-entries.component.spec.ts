import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BlogEntriesComponent } from './blog-entries.component';

describe('BlogEntriesComponent', () => {
  let component: BlogEntriesComponent;
  let fixture: ComponentFixture<BlogEntriesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BlogEntriesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BlogEntriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
