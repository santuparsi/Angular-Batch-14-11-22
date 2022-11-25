import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateDemo1Component } from './template-demo1.component';

describe('TemplateDemo1Component', () => {
  let component: TemplateDemo1Component;
  let fixture: ComponentFixture<TemplateDemo1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemplateDemo1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TemplateDemo1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
