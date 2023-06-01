const counter = document.getElementById('counter');
const reset = document.getElementById('empty');
const field = document.getElementById('field');

let interval = undefined;

const maFonction = () => {

    if(counter.value > 0) {
        let img = document.createElement('img');
        img.src = "./img/flower1.svg";
        field.appendChild(img);
    } 
    else if (counter.value == 0) {
        clearInterval(interval);
    }
}

counter.addEventListener('change', function() {

    if(interval != undefined) {
        clearInterval(interval);
    }
    interval = setInterval(maFonction, 1000/counter.value);
    
    
});
