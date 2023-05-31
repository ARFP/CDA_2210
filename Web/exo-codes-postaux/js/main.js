import { ZipCode } from './ZipCode.js';

// ajouts des évènements de l'interface utilisateur

let zipcodeInput = document.getElementById('zipcode');

console.log(zipcodeInput); // affiche l'élément dans la console
console.log(zipcodeInput.name); // affiche un attribut de l'élément

zipcodeInput.addEventListener('keyup', (event) => {
    var reg = new RegExp('^[0-9]{5}$');
    let value = event.target.value; // event.target )= élément qui a déclanché l'évènement

    if(reg.test(value)) {
        console.log(value);
        // rechercher si le code postal existe 
        zipcodes.search(value);
        console.log(zipcodes);
    }
});


const zipcodes = new ZipCode();
zipcodes.load();
