import { CerealsCollection } from "./CerealsCollection.js";
import { CerealsTable } from "./CerealsTable.js";
import {CerealsEvent} from "./CerealsEvent.js";

let cerealsCollection = new CerealsCollection();

CerealsEvent.cerealsCollection = cerealsCollection;

await cerealsCollection.loadData();

let cerealsTable = new CerealsTable(cerealsCollection);
cerealsTable.generateTable();

let head=document.querySelectorAll(".keys");

for(let h of head){
    h.addEventListener("click",(e)=>{
        CerealsEvent.columnSortEvent(e);
        cerealsTable.generateTable();
    })
}

let inputSearch = document.getElementById("inputSearch");
let categoriesSelect = document.getElementById("categoriesSelect")
let inputList = document.querySelectorAll('#cerealsNs input[type="checkbox"]');

CerealsCollection.updateFilter = () =>
{
    let letters =[]; 
    inputList.forEach(c=>{
        if(c.checked){
            letters.push(c.id);
        }
    });
    cerealsCollection.applyAllFilters(inputSearch.value, categoriesSelect.value, letters)
    cerealsTable.generateTable();
}

inputSearch.addEventListener("input",CerealsCollection.updateFilter);

categoriesSelect.addEventListener("change",CerealsCollection.updateFilter);

inputList.forEach(i=>i.addEventListener("click",CerealsCollection.updateFilter));
