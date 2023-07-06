import { Flight } from "./Flight.js";
import { Db } from "./db.js";

/**
 * Gère la collection de vols
 * @authors mdevoldere, grognone
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

        // valeur par défaut du sens de tri, si initialisé en true asc sinon desc
        this.sortedAsc = true;
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

    /**
     * tri la collection par l'attribut flight_duration
     */
    sortByDuration(){
        // fonction trie la collection en ordre croissant
        this.data = this.data.sort(
            (a,b) => a.flight_duration - b.flight_duration
        )

        // si le boleen sortedAsc est evalué à faux, alors on inverse le tri
        if (!this.sortedAsc){
            this.data.reverse()
        }

        //on inverse le boleen comme cela le tri s'inversera au prochain clic
        this.sortedAsc = !this.sortedAsc;
    }

    /**
     * Filtre les données du tableau en fonction d'une recherche sur le nom de la compagnie
     * @param {String} val  valeur à rechercher
     */
    async searchByCompany(val)
    {
        await this.loadData();
        val = val.trim();
        if(val.length > 0)
        {
            val = val.toLowerCase()
            this.data = this.data.filter(flight => flight.airline_name.toLowerCase().includes(val));
            console.log(val);
        }   
    }
}

export { FlightCollection }