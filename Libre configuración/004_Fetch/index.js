class transaction {
    constructor(date, concept, quantity) {
        this.date = new Date(date);
        this.concept = concept;
        this.quantity = quantity;
    }
}

let movements = [];
const weekdays = ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'];
const months = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'];

function getMovements() {
    fetch('recordedMovements.json')
    .then(r => r.json())
    .then((data) => {
        movements = [];
        data.forEach(element => {
            movements.push(new transaction(element.date, element.concept, element.quantity));
        });
        console.log(movements);
        renderDataHTML();
    }, e => {
        console.log(e);
    });
}

function renderDataHTML() {
    let table = document.createElement('table');
    table.classList.add('table', 'table-light', 'myTable');
    let thead = document.createElement('thead');
    thead.classList.add('thead-light');
    let tr = document.createElement('tr');
    let th = document.createElement('th');
    th.textContent = 'Fecha';
    tr.appendChild(th);
    th = document.createElement('th');
    th.textContent = 'Concepto'
    tr.appendChild(th);
    th = document.createElement('th');
    th.classList.add('endRow');
    th.textContent = 'Importe';
    tr.appendChild(th);
    thead.appendChild(tr);
    table.appendChild(thead);

    let td;
    movements.forEach(element => {
        tr = document.createElement('tr');
        td = document.createElement('td')
        td.textContent = formatDateES(element.date);
        tr.appendChild(td);
        td = document.createElement('td')
        td.textContent = element.concept;
        tr.appendChild(td);
        td = document.createElement('td')
        td.classList.add('endRow');
        td.textContent = element.quantity + "€";
        tr.appendChild(td);
        
        table.appendChild(tr);
    });

    let tcont = document.getElementsByClassName('movementTable')[0];
    tcont.firstChild.remove();
    tcont.appendChild(table)
    toggleSpinner();
}

function formatDateES(date) {
    return weekdays[date.getDay()] + ', ' + date.getDate() + ' de ' + months[date.getMonth()];
}

function toggleSpinner() {
    document.getElementsByClassName('loadMovements')[0].toggleAttribute('hidden');
    
}

function main() {
    let btn = document.getElementsByClassName('getMovements')[0].addEventListener('click', () => {
        toggleSpinner();
        getMovements();
    });
}

window.addEventListener('load', main);