import {Employees} from "./employees.js";
import { TableGenerator } from "./tableGenerator.js";

let employee = new Employees();
await employee.getEmployees();
console.log(employee.employeesCollection);

let employeeTable = new TableGenerator(employee);
employeeTable.generateBody();


const sortButton = document.getElementById('sortSalary');

sortButton.addEventListener("click", () => {
    employee.sortBySalary();
    employeeTable.generateBody();
});

