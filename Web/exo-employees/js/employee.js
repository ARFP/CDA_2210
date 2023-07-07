class Employee
{
    constructor(employee)
    {
        Object.assign(this,employee);
        this.email = this.generateEmail();
        this.yearOfBirth = this.calculateYearOfBirth();
        this.monthlySalary = this.calculateMonthlySalary();
    }

    //generer Email
    generateEmail()
    {
        let name = this.employee_name.split(' ');
        let firstLetter = this.employee_name[0];
        let lastName = name[1];
        
        return (firstLetter + "." + lastName + "@email.com").toLowerCase();
    }

    //generer Annee de naissance
    calculateYearOfBirth()
    {
        let date = new Date().getFullYear();
        let yearOfBirth = date - this.employee_age;
        return yearOfBirth;
    }

    //Calculer salaire mensuel
    calculateMonthlySalary()
    {
        let monthlySalary = this.employee_salary/12;
        return monthlySalary.toFixed(2);
    }
}
export {Employee};