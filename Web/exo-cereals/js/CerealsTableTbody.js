class CerealsTableTbody{
    constructor(_cerealsCollection){
        this.cerealsCollection=_cerealsCollection;
        this.tbody = document.getElementById("tbody");
    }
    generateTable(){
        this.tbody.innerHTML="";
        for(let cereal of this.cerealsCollection.data){
            let trTemp=this.generateRow(cereal)
            this.tbody.appendChild(trTemp);
        }
    }
    generateRow(cereal){
        let tr = document.createElement("tr");
        for(let val of cereal.getValues()){
            let cellTemp = this.generateCell(val);
            tr.appendChild(cellTemp);
        }
        tr.appendChild(this.generateCell("❌"))
        return tr;
    }
    generateCell(value){
        let td = document.createElement("td");
        td.textContent=value;
        td.classList.add("valueTableCereals");
        return td;
    }  
}
export {CerealsTableTbody}