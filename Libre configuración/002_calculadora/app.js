/*
    C -> CE => clear
    P -> % => percentage
    A -> + => add
    M -> - => minus
    D -> / => division
    T -> x => multiplication
    E -> = => equals
*/

let inputString = '';
let input = []; //keys pressed before doing an operation
let ac;
const ESP = ['C', 'P', 'A', 'M', 'D', 'T', 'E'];
let retrievedESP = [];

function register(ev) {
    if (ev.target.value == 'C') {
        input = [];
        inputString = '';
        retrievedESP = [];
        ac.textContent = '';
    } else {
        canPushInput = true;
        ESP.forEach((char) => {
            if (ev.target.value.includes(char)) {
                retrievedESP.push(char);
                input.push(inputString);
                canPushInput = false;
                ac.textContent = '';
                inputString = '';
            } 
        });
    
        if (canPushInput) {
            inputString += ev.target.value;
            ac.textContent += ev.target.value;
            if (inputString.length > 15) {
                ac.textContent = ac.textContent.substring(1);
            }
        }
        
        if (retrievedESP.length > 1) {
           let result = calc(retrievedESP.reverse(), input.reverse());
           ac.textContent = result;
           if (result != 'ERROR') {
            input = [];
            inputString = result;
            retrievedESP = [];
           }
           console.log(input);
        }
    }
    
}

function calc(retrievedESPreversed, inputReversed) {
    console.log(inputReversed);
    console.log(retrievedESPreversed);

    let x = inputReversed.pop();
    let symbol = retrievedESP.pop();
    let y = inputReversed.pop();

    let result;
    switch (symbol) {
        case 'P': //percentage
            
            break;
        case 'A': //add
            result = +x + +y;
            break;
        case 'M': //minus
            result = x - y;
            break;
        case 'D': //division
            result = x / y;
            break;
        case 'T': //multiplication
            result = x * y;
            break;
        case 'E': //equals
            if (y != ''){
                result = y;
            } else {
                result = x;
            }
            break;
        default:
            result = 'ERROR';
            break;
    }
    if (isNaN(result)) {
        result = 'ERROR';
    }
    return result;
}


function main() {
    document.querySelector('.calc-buttons').addEventListener('click', (ev) => {
        register(ev);
    });
    ac = document.querySelector('.acumulator');
}

window.addEventListener('load', main);