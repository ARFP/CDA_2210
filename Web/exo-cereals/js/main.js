import { CerealsCollection } from "./CerealsCollection.js";

let test = new CerealsCollection();
await test.loadData();
console.log(test);