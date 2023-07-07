class CerealsTable{
    constructor(_cerealsCollection){
        this.cerealsCollection=_cerealsCollection;
        this.tbody = document.getElementById("tbody");
        this.nbElement = document.getElementById("nbElement");
        this.caloriesAverage = document.getElementById("caloriesAverage");
    }
    generateTable(){
        this.tbody.innerHTML="";
        for(let cereal of this.cerealsCollection.data){
            let trTemp=this.generateRow(cereal)
            this.tbody.appendChild(trTemp);
        }
        this.countElement();
        this.calcAvgCal();
    }
    generateRow(cereal){
        let tr = document.createElement("tr");
        for(let val of cereal.getValues()){
            let cellTemp = this.generateCell(val);
            tr.appendChild(cellTemp);
        }
        let cellTemp = this.generateCell("❌");
        cellTemp.classList.add("delButton");
        cellTemp.addEventListener("click",()=>{
            this.cerealsCollection.delRow(cereal.id);
            this.generateTable();
        });
        tr.appendChild(cellTemp);
        return tr;
    }
    generateCell(value){
        let td = document.createElement("td");
        td.textContent=value;
        td.classList.add("valueTableCereals");
        return td;
    }  
    countElement(){
        this.nbElement.innerHTML=this.cerealsCollection.data.length + " Elements";
    }
    calcAvgCal(){
        const length = this.cerealsCollection.data.length;
        this.caloriesAverage.innerHTML= "Moyenne Calories <br>" + this.cerealsCollection.data.reduce((acc, val) => {
            return acc + (val.calories/length);
        }, 0).toFixed(0);
     };
}
export {CerealsTable}