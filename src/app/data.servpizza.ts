import {Injectable} from '@angular/core'
import {HttpClient} from '@angular/common/http'
import {Pizza} from './pizza'

@Injectable({
    providedIn: 'root'
})

export class PizzaService{

constructor(private http: HttpClient){ }

getPizzas(){
    return this.http.get<Pizza>("http://localhost:51105/api/Serve");
    
}


}
