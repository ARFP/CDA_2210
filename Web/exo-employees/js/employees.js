import { Db } from "./db.js";
import {Employee} from "./employee.js"

class Employees 
{
    constructor()
    {
        this.employeesCollection = [];
        this.sortOrder = true; // true = ordre croissant / false = ordre décroissant
    }

    async getEmployees()
    {
        let employeeToAdd = await Db.fetchData('https://arfp.github.io/tp/web/frontend/employees/employees.json');
        for(let employee of employeeToAdd.data)
        {
            this.employeesCollection.push(new Employee(employee));
        }

        return this.employeesCollection;
    }

    deleteEmployee(id)
    {
        this.employeesCollection=this.employeesCollection.filter(emp=>emp.id!=id);
    }

    duplicateEmployee(id)
    {
        let employee = this.employeesCollection.find(emp=>emp.id==id);

        let maxId = Math.max.apply(Math, this.employeesCollection.map(function(emp) { return emp.id }));

        if(employee instanceof Employee)
        {
            let newEmployee  = new Employee(employee)
            newEmployee.id = ++maxId;
            // employee.id = maxId + 1; // equivalent de la ligne précédente
            this.employeesCollection.push(newEmployee);
        }
    }
    
    sortBySalary()
    {
        this.employeesCollection.sort((a, b) => a.employee_salary - b.employee_salary);

        if(!this.sortOrder) {
            this.employeesCollection.reverse();
        }

        this.sortOrder = !this.sortOrder;
    }
}

export {Employees};