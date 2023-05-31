// importation de la classe ZipCode présente dans le fichier ZipCode.js
import { ZipCode } from './ZipCode.js';

// sélection de l'élément HTML dont l'id est égal à "zipcode"
let zipcodeInput = document.getElementById('zipcode');

const zipcodes = new ZipCode();
zipcodes.load();

console.log(zipcodeInput); // affiche l'élément dans la console
console.log(zipcodeInput.name); // affiche un attribut de l'élément

// Création d'un évènement 
// https://developer.mozilla.org/en-US/docs/Web/API/EventTarget/addEventListener
zipcodeInput.addEventListener('keyup', (event) => {
    var reg = new RegExp('^[0-9]{5}$');
    // event.target = élément qui a déclenché l'évènement 
    let value = event.target.value; 

    if(reg.test(value)) {
        console.log(value);
        // rechercher si le code postal existe 
        zipcodes.search(value); // appel de la méthode "search" de la classe "ZipCode"
        console.log(zipcodes);
    }
});
