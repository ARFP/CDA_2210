import { Db } from "./db.js";

class Employees 
{
    constructor()
    {
        this.employeesCollection = [];
    }

    async getEmployees()
    {
        this.employeesCollection = await Db.fetchData('https://arfp.github.io/tp/web/frontend/employees/employees.json');
        return this.employeesCollection;
    }

    /* Ajouter les méthodes pour rechercher, supprimer et dupliquer un employé dans employeesCollection */
}