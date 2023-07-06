/**
 * Gère la mise à jour de l'interface Utilisateur (Ui)
 */
class FlightUi 
{
    /**
     * Constructeur
     * @param {FlightCollection} _collection une instance de FlightCollection
     */
    constructor(_collection)
    {
        // la collection de données à manipuler
        this.collection = _collection;

        // sélection de l'élément tbody du document HTML courant
        this.tbody = document.getElementById('flightsBody');
    }

    /**
     * Génère le TBODY à partir des données de la collection 'this.collection'
     */
    generateTable() 
    {
        this.tbody.innerHTML = ""; // on vide le tableau 

        // pour chaque élément de la collection, on crée une ligne de tableau HTML
        this.collection.data.forEach(f => {
            let tr = this.generateRow(f); // création d'une ligne du tableau HTML
            this.tbody.appendChild(tr); // insertion de la ligne dans le tbody courant 
        });

       /* 
            // Version alternative
            // ne permet pas d'accéder au "this". 
            // conclusion : ça ne fonctionne pas !
            this.collection.data.forEach(function(f) {
            let tr = this.generateRow(f); // création d'une ligne du tableau HTML
            this.tbody.appendChild(tr); // insertion de la ligne dans le tbody courant
        });*/
    }

    /**
     * Génère une ligne du tableau HTML.
     * Une ligne correspond à un vol
     * @param {Flight} _flight le vol à afficher
     * @returns 
     */
    generateRow(_flight)
    {
        let tr = document.createElement('tr'); // création d'un élément <tr>

        // pour chaque valeur d'un vol, on crée une cellule
        _flight.getValues().forEach(val => {
            let td = this.generateCell(val); // création d'une cellule de tableau
            tr.appendChild(td); // ajout de la cellule à la ligne courante
        });

        return tr;
    }

    /**
     * Génère une cellule du tableau HTML
     * @param {String|Number} _val la valeur à insérer dans la cellule
     * @returns 
     */
    generateCell(_val)
    {
        let td = document.createElement('td'); // création d'un élément <td> (cellule de tableau)

        td.textContent = _val; // ajout de la valeur à la cellule

        return td;
    }
}

export { FlightUi }