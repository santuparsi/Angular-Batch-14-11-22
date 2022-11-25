import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReactiveDemo2Component } from './reactive-demo2.component';

describe('ReactiveDemo2Component', () => {
  let component: ReactiveDemo2Component;
  let fixture: ComponentFixture<ReactiveDemo2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReactiveDemo2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReactiveDemo2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
