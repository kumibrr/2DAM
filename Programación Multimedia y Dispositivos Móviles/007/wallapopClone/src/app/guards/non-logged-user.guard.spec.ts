import { TestBed } from '@angular/core/testing';

import { NonLoggedUserGuard } from './non-logged-user.guard';

describe('NonLoggedUserGuard', () => {
  let guard: NonLoggedUserGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(NonLoggedUserGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
