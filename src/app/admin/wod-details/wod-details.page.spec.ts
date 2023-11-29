import { ComponentFixture, TestBed } from '@angular/core/testing';
import { WodDetailsPage } from './wod-details.page';

describe('WodDetailsPage', () => {
  let component: WodDetailsPage;
  let fixture: ComponentFixture<WodDetailsPage>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(WodDetailsPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
