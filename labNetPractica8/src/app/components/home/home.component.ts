import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Shipper } from 'src/app/core/models/shipper';
import {MatPaginator} from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { ShipperServiceService } from '../services/shipper.service.service';
import { elementAt } from 'rxjs';


const ELEMENT_DATA: Shipper[] = [
  {ShipperID: 1, CompanyName: 'Hydrogen', Phone: '1.0079'},

];

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent implements AfterViewInit{

  displayedColumns: string[] = ['shipperID', 'companyName', 'phone','actions'];
  listShippers!:Shipper[];
  dataSource = new MatTableDataSource(this.listShippers)
  
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  
  constructor(private _shipperService: ShipperServiceService){
   
  }
  
  ngOnInit():void{
    this.getAllShippers();
  }
  
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  deleteShipper(id: number){
    this._shipperService.deleteShippers(id).subscribe()
    console.log(id)
  }

  updateShipper(id: number):void {

  }

  createShipper(companyName: string, phone: string):void {

  }

  getAllShippers(){
    this._shipperService.getShippers().subscribe({
      next:(result) =>{
        console.log(result);
       this.listShippers = result as Shipper[];
       this.dataSource = new MatTableDataSource(result as Shipper[]) 
      },
      error:(e) => {
        console.log(e);
      }
      
    })
  }
}
