import { TestBed, async } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { CustomerComponent } from './customer/customer.component';
<<<<<<< HEAD
import { LoginComponent } from './customer/login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
=======
import { HttpClientModule } from '@angular/common/http';
>>>>>>> developerBranch
describe('AppComponent', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            imports: [
                RouterTestingModule,
                HttpClientModule,
<<<<<<< HEAD
                FormsModule
            ],
            declarations: [
                AppComponent,
                CustomerComponent,
                LoginComponent
=======
            ],
            declarations: [
                AppComponent,
                CustomerComponent
>>>>>>> developerBranch
            ],
        }).compileComponents();
    }));
    it('should create the app', () => {
        const fixture = TestBed.createComponent(AppComponent);
        const app = fixture.debugElement.componentInstance;
        expect(app).toBeTruthy();
    });
    it('should assign WELCOME title to page'), () => {
        const fixture = TestBed.createComponent(AppComponent);
        const app = fixture.debugElement.nativeElement;
        expect(app.querySelector('#Locator h1').textContent).toEqual('WELCOME');
    };
});
//# sourceMappingURL=app.component.spec.js.map