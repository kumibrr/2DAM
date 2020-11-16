import { TestBed } from '@angular/core/testing';

import { ChuckJokesService } from './chuck-jokes.service';

describe('ChuckJokesService', () => {
  let service: ChuckJokesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ChuckJokesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
