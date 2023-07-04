import {Cereal} from "./Cereal.js";
import { db } from "./db.js";
class CerealsCollection{
    constructor(){
        this.data=[]
    }
    async loadData(){
        let temp = await db.getDB("/cereals.json");
        this.data = temp["data"];
       // this.data = temp.data; // Equivalent de la ligne précedente
        this.data = this.data.map(c=>new Cereal(c));
    }
    delRow(cerealId){
        this.data = this.data.filter(d=>d.id != cerealId);
    }
}
export {CerealsCollection}