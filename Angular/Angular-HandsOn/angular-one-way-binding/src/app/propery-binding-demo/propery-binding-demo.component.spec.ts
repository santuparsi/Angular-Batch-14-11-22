import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProperyBindingDemoComponent } from './propery-binding-demo.component';

describe('ProperyBindingDemoComponent', () => {
  let component: ProperyBindingDemoComponent;
  let fixture: ComponentFixture<ProperyBindingDemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProperyBindingDemoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProperyBindingDemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
