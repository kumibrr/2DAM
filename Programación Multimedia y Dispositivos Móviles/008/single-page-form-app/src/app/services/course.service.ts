import { Course } from './../model/Course.model';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  private courses: Course[] = [new Course('Curso guapo de angular', 3), new Course('Curso de assembly x86_64', 4)];
  private observableOfCourse = of(this.courses);

  constructor() { }

  getCourses(): Observable<Course[]> {
    return this.observableOfCourse;
  }

  addCourse(title: string, score: number): void {
    this.courses.push(new Course(title, score));
  }

  removeCourse(course: Course): void {
    this.courses.splice(this.courses.indexOf(course), 1);
  }
}
