import { ComponentFixture, TestBed } from '@angular/core/testing';
import { WheatherForecastComponent } from './wheather-forecast.component';

describe('WheatherForecastComponent', () => {
  let component: WheatherForecastComponent;
  let fixture: ComponentFixture<WheatherForecastComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [WheatherForecastComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(WheatherForecastComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
