console.log('toto');

const pokemon = require('pokemon');
// import pokemon from 'pokemon';

const collection = pokemon.all('ja');

for(let pok of collection) {
    console.log(pok);
}
