import {Injectable} from '@angular/core'
import {HttpClient} from '@angular/common/http'
import {Pizza} from './pizza'
<<<<<<< HEAD
=======
import {Observable} from  'rxjs';
import { HttpHeaders } from '@angular/common/http';




>>>>>>> developerBranch

@Injectable({
    providedIn: 'root'
})

export class PizzaService{

<<<<<<< HEAD
constructor(private http: HttpClient){ }

getPizzas(){
    return this.http.get<Pizza>("https://vmanpizza-vmanpizzalive.azurewebsites.net/api/Serve");
    
}


}
=======
    
constructor(private http: HttpClient){

    
}
    

getPizzas(pizzas: Pizza[]) : Observable<Pizza>{

    return  this.http.get<Pizza>("http://localhost:51105/api/Serve", { headers: new HttpHeaders({'Accept': 'application/json','Content-Type':  'application/json'  })})
    

}
          
}
>>>>>>> developerBranch