import { FlightCollection } from "./FlightCollection.js";
import { FlightUi } from "./FlightUi.js";


// création de l'instance qui gère la collection de données
let flightCollection = new FlightCollection();

// chargement des données
await flightCollection.loadData();

// création de l'instance qui gère la mise à jour de l'interface.
// on y injecte la collection de données
let flightUi = new FlightUi(flightCollection);

// génération initiale du tableau HTML à partir des données de flightCollection
flightUi.generateTable();


// For the Ref
console.log('JE SUIS PILOTE');
