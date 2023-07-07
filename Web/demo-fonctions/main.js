const h1 = document.getElementById('titre');

// Ceci est une fonction
function ajouterTitre(nouveauTitre)
{
    h1.textContent = nouveauTitre;
}

const ajouterTitre2 = function(nouveauTitre) 
{
    h1.textContent = nouveauTitre;
}

const ajouterTitre3 = (nouveauTitre) => 
{
    h1.textContent = nouveauTitre;
}

h1.addEventListener("click", function(event) {
    // code
})

h1.addEventListener("click", (event) => { 
    // code
    h1.dataset.gerard = "nicolas";
    console.log(event);
    console.log(event.target);
    console.log(event.target.id);
    console.log(event.target.dataset);
    console.log(event.target.dataset.gerard);
    console.log(event.target.dataset["toto"]);
})