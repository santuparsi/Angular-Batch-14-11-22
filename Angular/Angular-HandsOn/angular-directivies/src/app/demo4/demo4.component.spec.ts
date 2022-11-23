import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Demo4Component } from './demo4.component';

describe('Demo4Component', () => {
  let component: Demo4Component;
  let fixture: ComponentFixture<Demo4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Demo4Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Demo4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
