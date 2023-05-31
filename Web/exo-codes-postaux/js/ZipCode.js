class ZipCode 
{
    // constructeur Javascript
    constructor()
    {
        this.datasource = "https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json";
        this.zipcodes = [];
    }

    /**
     * Charge des données distantes et stocke le résultat dans l'attribut this.zipcodes
     * https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch
     */
    async load() {
        try {
            let response = await fetch(this.datasource);
            this.zipcodes = await response.json();
            console.log(this.zipcodes);
            console.log(this.zipcodes[0]);
        } catch(error) {
            // traitement de l'erreur
        }
    }


    /** 
     * Recherche des éléments dans la collection this.zipcodes
     * https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/filter
     * @param {int|string} zipcode le code postal ou nom de ville à rechercher
     */
    search(zipcode)
    {
        let result = [];

        /*for(let city of this.zipcodes) {
            if(city.codePostal == zipcode) {
                result.push(city);
                console.log(result);
            }
        }*/

        // la ligne suivante effectue le même traitement que le for ci-dessus
        result = this.zipcodes.filter(city => city.codePostal == zipcode);
        
        console.log(result);

        this.fillUi(result);


    }

    fillUi(result) 
    {
        //let element = document.getElementById('result');
        let element = document.querySelector('#result');
        element.innerHTML = ""; // réinitialisation du contenu

        for(let city of result) {
            //element.innerHTML = "<li>"+ city.NomCommune+"</li>";

            let li = document.createElement('li'); // création d'un élément <li>
            li.innerText = city.nomCommune + " " + city.codeCommune; // ajout de contenu dans l'élément <li> créé
            element.appendChild(li); // ajout de l'élément <li> crée dans l'élément #result
        }

    }


}

export { ZipCode }