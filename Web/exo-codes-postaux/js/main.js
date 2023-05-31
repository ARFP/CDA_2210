
/* const constante = "";
var variable1;
let variable2; */

// Télécharger une ressource distante

// option 1
// let xhr = new XMLHttpRequest();

// option2
// Utiliser l'API fetch de Javascript
fetch('https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json')
.then(response => response.json())
.then(function(json) {
    console.log(json);
})
.catch(function(error) {
    // traitement des exceptions (Error)
});

try {
    let response = await fetch('https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json');
    let json = await response.json();
    console.log(json);
} catch(error) {
    // traitement de l'erreur
}

//

class ZipCode 
{
    constructor()
    {
        this.datasource = "";
        this.zipcodes = [];
    }


    search(zipcode)
    {
        
    }
}
