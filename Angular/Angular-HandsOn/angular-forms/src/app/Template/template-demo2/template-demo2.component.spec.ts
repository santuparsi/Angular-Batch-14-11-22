import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateDemo2Component } from './template-demo2.component';

describe('TemplateDemo2Component', () => {
  let component: TemplateDemo2Component;
  let fixture: ComponentFixture<TemplateDemo2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemplateDemo2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TemplateDemo2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
