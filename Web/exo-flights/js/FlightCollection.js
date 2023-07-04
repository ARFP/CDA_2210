import { Flight } from "./Flight.js";
import { Db } from "./db.js";

/**
 * Gère la collection de vols
 */
class FlightCollection
{
    /**
     * Constructeur
     * initialise le tableau de données
     */
    constructor()
    {
        this.data = [];
    }

    /**
     * Chargement des données de la collection
     */
    async loadData() 
    {
        this.data = await Db.getData("https://arfp.github.io/tp/web/frontend/flights/flights.json");

        // console.log(this.data);

        // pour chaque élément de la collection, on crée une instance de Flight
        this.data = this.data.map(f => new Flight(f));
    }
}

export { FlightCollection }