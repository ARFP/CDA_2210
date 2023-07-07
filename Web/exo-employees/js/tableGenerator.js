class TableGenerator
{
    constructor(employeeTable)
    {
        this.employees = employeeTable;
        this.tBody = document.getElementById("tableBody");
    }

    //generer body
    generateBody()
    {
        this.tBody.innerHTML="";
        for(let employee of this.employees.employeesCollection)
        {
            let row = document.createElement('tr');
            this.tBody.appendChild(row);
            this.generateCell(row,employee.id);
            this.generateCell(row,employee.employee_name);
            this.generateCell(row,employee.email);
            this.generateCell(row,employee.monthlySalary);
            this.generateCell(row,employee.yearOfBirth);
            this.generateCellButton(row,employee);
        }
    }

    //Fonction pour générer les celule avec les donnée d'un employé
    generateCell(row,data)
    {
        let cell = document.createElement('td');
        cell.textContent=data;
        row.appendChild(cell);
    }
    
    //Fonction pour générer la celule contenant les 2 boutons action
    generateCellButton(row,employee)
    {
        //Création d'une cellule
        let cell = document.createElement('td');

        //Création du bouton Duplicate
        let buttonDuplicate=document.createElement("button");
        buttonDuplicate.textContent="Duplicate";
        buttonDuplicate.dataset.id=employee.id;
        buttonDuplicate.addEventListener("click",(e) => this.duplicateEmployee(e));

        //Création du bouton Delete
        let buttonDelete=document.createElement("button");
        buttonDelete.textContent="Delete";
        buttonDelete.dataset.id=employee.id;
        buttonDelete.addEventListener("click",(e)=>this.deleteEmployee(e));

        //Ajout des boutons dans la cellule
        cell.appendChild(buttonDuplicate);
        cell.appendChild(buttonDelete);

        //Ajout de la cellule dans la ligne
        row.appendChild(cell);
    }

    //Fonction pour dupliquer un employé
    duplicateEmployee(e)
    {
        this.employees.duplicateEmployee(e.target.dataset.id);
        this.generateBody();
    }

    //Fonction pour supprimer un employé
    deleteEmployee(e)
    {
        this.employees.deleteEmployee(e.target.dataset.id);
        this.generateBody();
    }

    //generer footer

}

export {TableGenerator};