import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/app/environments/environment';
import { Observable  } from 'rxjs';
import { ResponseDto } from 'src/app/core/models/ResponseDto';
import { Shipper } from 'src/app/core/models/shipper';
@Injectable({
  providedIn: 'root'
})
export class ShipperServiceService {
  apiUrl: string = environment.apilab
  
  constructor(private http: HttpClient) {

  }

  getShippers():Observable<ResponseDto[]>{
    let url = `${this.apiUrl}/Shipper`;
    return this.http.get<ResponseDto[]>(url);
  }

  deleteShippers(id: number){
    let url = `${this.apiUrl}/Shipper/`+ id;
    console.log(url)
    return this.http.delete(url)
  }

  updateShipper(id: number,bodyUpdated : Shipper){
    let url = `${this.apiUrl}/Shipper/`+ id;
    return this.http.put(url,bodyUpdated);
  }

}
