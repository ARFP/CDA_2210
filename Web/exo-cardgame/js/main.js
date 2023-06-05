import { Card } from "./Card.js";
import { Cards } from "./Cards.js";

const cards = new Cards("https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json");
await cards.getCards();

const myThead = document.getElementById("myThead");
const myTbody = document.getElementById("myTbody");

function createTable()
{
    for(let card of cards.cardsCollection)
    {
        /* creer une ligne pour le tableau */
        let row = document.createElement('tr');

        for(let data of card.getValues())
        {
            /* creer une cellule pour le tableau */
            let cell = document.createElement('td');

            /* ajoute le nom de la carte à la cellule */
            cell.textContent = data;

            /* ajoute la cellule à la ligne */
            row.appendChild(cell);
        }

        /* ajoute la ligne à mytbody */
        myTbody.appendChild(row);
    }

    createTableHeader();
    createTableFooter();// a tester
}



/* Fonction pour creer une entete */
function createTableHeader(){
    let myCard = cards.getFirst();

    let row2 = document.createElement("tr");
    for(let data of myCard.getKeys())
    {
        // creer une cellule pour le tableau
        let cell = document.createElement('th');

        // ajoute le nom de la carte à la cellule
        cell.textContent = data;

        // ajoute la cellule à la ligne
        row2.appendChild(cell);
    }
    myThead.appendChild(row2);
}


function createTableFooter(){
    console.log(cards.getHigherArmorCard());
}

createTable();