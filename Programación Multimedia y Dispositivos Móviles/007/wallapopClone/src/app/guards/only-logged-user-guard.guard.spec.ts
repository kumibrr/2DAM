import { TestBed } from '@angular/core/testing';

import { OnlyLoggedUserGuardGuard } from './only-logged-user-guard.guard';

describe('OnlyLoggedUserGuardGuard', () => {
  let guard: OnlyLoggedUserGuardGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(OnlyLoggedUserGuardGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
