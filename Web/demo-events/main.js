const toto = document.getElementById('toto');
const titi = document.getElementById('titi');
const h1 = document.getElementById('title');


toto.addEventListener('click', (e) => {
    h1.classList.toggle("toto");
});

titi.addEventListener('click', (e) => {
    h1.classList.toggle("titi");
});