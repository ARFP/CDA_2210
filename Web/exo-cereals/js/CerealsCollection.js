import {Cereal} from "./Cereal.js";
import { db } from "./db.js";
class CerealsCollection{
    constructor(){
        this.data=[]
    }
    async loadData(){
        let temp = await db.getDB("/cereals.json");
        this.data = temp["data"];
        this.data = this.data.map(c=>new Cereal(c));
    }
}
export {CerealsCollection}