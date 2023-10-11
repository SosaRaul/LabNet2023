import { Component } from '@angular/core';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import {ShipperServiceService } from '../home/home.component';


@Component({
  selector: 'app-load-data',
  templateUrl: './load-data.component.html',
  styleUrls: ['./load-data.component.css']
})
export class LoadDataComponent {
  form! :FormGroup;
  

  constructor(private fb:FormBuilder,private shipperService: ShipperServiceService){
    this.form = this.fb.group({

      companyName: new FormControl('',Validators.required),
      phoneNumber: new FormControl('',[Validators.required])
   })
  }

  getErrorMessagePhone() {
    return this.form.value.phoneNumber.hasError('required') ? 'Not a valid phone Number' : '';
  }
  getErrorMessageCompany(){
    return (this.form.value.companyName.hasError('required')) ? 'You must enter a name' : ''
  }
  
  onClickCreateShipper(companyName :string , phone : string) {
    let dataShipper: any = {
      CompanyName : companyName,
      Phone : phone
    };
    this.shipperService.createShipper(dataShipper).subscribe()
  }

}
