/*
    C -> CE => clear
    P -> % => percentage
    A -> + => add
    M -> - => minus
    D -> / => division
    T -> x => multiplication
    E -> = => equals
    f -> . => floating point
*/

let input = ''; //keys pressed before doing an operation
let ac = 0; //acumulator
const ESP = ['C', 'P', 'A', 'M', 'D', 'T', 'E'];

function register(ev) {
    if (ev.target.value == 'C') {
        input = '';
        ac = 0;
    }

    espCharCounter = 0;
    
    input += ev.target.value;
    
    ESP.forEach((char) => {
        if (input.indexOf(char) != -1) {
            espCharCounter++;
        }
    });
    if (espCharCounter > 1){
        console.log('operation')
    }
}


function main() {
    document.querySelector('.calc-buttons').addEventListener('click', (ev) => {
        register(ev);
    });
    ac = document.querySelector('acumulator');
}

window.addEventListener('load', main);