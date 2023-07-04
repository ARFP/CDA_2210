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
document.getElementById("inputSearch").addEventListener("input",(e)=>{
        CerealsEvent.searchCereal(e.target.value);
        cerealsTable.generateTable();
});
document.getElementById("categoriesSelect").addEventListener("change",(e)=>{
    CerealsEvent.sortCategory(e.target.value);
    cerealsTable.generateTable();
});
let inputList = document.querySelectorAll('#cerealsNs input[type="checkbox"]');
inputList.forEach(i=>{i.addEventListener("click",(e)=>{
    let letters =[]; 
    inputList.forEach(c=>{
        if(c.checked){
            letters.push(c.id);
        }
    });
    console.log(letters);
    CerealsEvent.sortNutriscore(letters);
    cerealsTable.generateTable();
    })
});