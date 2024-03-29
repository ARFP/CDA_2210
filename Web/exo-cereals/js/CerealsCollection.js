import {Cereal} from "./Cereal.js";
import { db } from "./db.js";
class CerealsCollection{
    static updateFilter = () => {};

    constructor(){
        this.initialData=[]
        this.data=[];
    }

    async loadData(){
        let temp = await db.getDB("/cereals.json");
        this.initialData = temp["data"];
       // this.data = temp.data; // Equivalent de la ligne précedente
        this.initialData = this.initialData.map(c=>new Cereal(c));
        this.data = Array.from(this.initialData);
    }
    delRow(cerealId){
        this.initialData = this.initialData.filter(d=>d.id != cerealId);
        this.data = Array.from(this.initialData);
        CerealsCollection.updateFilter();
    }
    searchCereal(value){
        this.data = this.initialData.filter(c=>c.name.toLowerCase().includes(value.toLowerCase()));
    }
    sortCategory(value){
        switch(value){
            case "1":
                this.data = this.data.filter(c=>c.sodium<50);
                break;
            case "2":
                this.data = this.data.filter(c=>c.sugars<1);
                break;
            case "3":
                this.data = this.data.filter(c=>c.vitamins>=25 && c.fiber>=10);
                break;
            default:
                this.data = Array.from(this.data);
                break;
        }
    }
    sortNutriscore(letters){
        if(letters.length>0){
            this.data = this.data.filter(c=>letters.includes(c.ns));
        }
        else{
            this.data = Array.from(this.data);
        }
    }

    applyAllFilters(cerealName, cerealCategory, selectedNS)
    {
        this.searchCereal(cerealName);
        this.sortCategory(cerealCategory);
        this.sortNutriscore(selectedNS);
    }
}



export { CerealsCollection } 