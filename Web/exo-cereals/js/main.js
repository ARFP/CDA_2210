import { CerealsCollection } from "./CerealsCollection.js";
import { CerealsTableTbody } from "./CerealsTableTbody.js";

let cerealsCollection = new CerealsCollection();
await cerealsCollection.loadData();

let cerealsTableTbody = new CerealsTableTbody(cerealsCollection);
cerealsTableTbody.generateTable();
let sortDirection = true;
function generateClickEvent(e){
    if(typeof(cerealsCollection.data[0][e.target.dataset.name])!="string"){
        cerealsCollection.data.sort((x,y)=>x[e.target.dataset.name]-y[e.target.dataset.name]);
    }
    else{
        cerealsCollection.data.sort((x,y)=>x[e.target.dataset.name].localeCompare(y[e.target.dataset.name]));
    }

    if(sortDirection){
        cerealsCollection.data.reverse();
    }
    sortDirection=!sortDirection;
    
    cerealsTableTbody.generateTable();
}

let head=document.querySelectorAll(".keys");
for(let h of head){
    h.addEventListener("click",(e)=>{
        generateClickEvent(e);
    })
}