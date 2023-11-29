import { ComponentFixture, TestBed } from '@angular/core/testing';
import { WodoutPage } from './wodout.page';

describe('WodoutPage', () => {
  let component: WodoutPage;
  let fixture: ComponentFixture<WodoutPage>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(WodoutPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
