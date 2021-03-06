import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { Order } from 'src/app/dto/Order';
import { Subdivision } from 'src/app/dto/Subdivision';
import { EmployeeService } from 'src/app/employes/shared/employee.service';
import { SubdivisionService } from '../shared/subdivision.service';


@Component({
  selector: 'app-create-subdivision',
  templateUrl: './subdivision-create.component.html',
  styleUrls: ['./subdivision-create.component.css']
})

/** order create component*/
export class CreateSubdivisionComponent implements OnInit {
  error: string = "";
  employes: Employee[] = [];
  subdivision: Subdivision = {} as Subdivision;
  selectedEmployee: number = 0;
  isError: boolean = false;
  order: Order = {} as Order;

  constructor(
    private router: Router,
    private employeeService: EmployeeService,
    private subdivisionService: SubdivisionService
  ) { }

  ngOnInit() {
    this.getEmployes();
  }

  addSubdivision(create: NgForm) {
    const newSubdivision = <Subdivision>{
      name: create.value.name,
      supervisorId: this.selectedEmployee
    };
    if (newSubdivision.name == "" || newSubdivision.supervisorId == undefined) { 
      this.isError = true;
      return;
    }
    
    this.subdivisionService.addSubdivision(newSubdivision).subscribe( () => this.router.navigate(['subdivisions/']), error => this.error = error.message);
  }

  getEmployes(): void {
    this.employeeService.getEmployes().subscribe(employes => this.employes = employes, error => this.error = error.message );
  }
}
