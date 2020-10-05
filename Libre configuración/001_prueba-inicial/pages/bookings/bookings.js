const myURL = '/assets/bookings.xml';

class Book {
    constructor(place, bookingDate, bookedDate, room, price) {
        this.place = place;
        this.bookingDate = new Date(bookingDate);
        this.bookedDate = new Date(bookedDate);
        this.room = room;
        this.price = price;
    }
}

const bookArr = new Array();

function getDataFromXML(url) {
    return new Promise((resolve, reject) => {
        let xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {

        if (this.readyState === 4 && this.status === 200) {
            resolve(xhttp.responseXML);
        }
    }
    xhttp.open("GET", url);
    xhttp.send();
    })
    
}

function representData() {
    
    tableContainer = document.querySelector('.content');
    const headerElements = ['Lugar', 'Fecha', 'Fecha de compra', 'Habitacion', 'Precio'];
    const table = document.createElement('table');
    const header = document.createElement('tr');
    headerElements.forEach(element => {
        const thr = document.createElement('th');
        thr.textContent = element;
        header.appendChild(thr);
    });
    table.appendChild(header);

    bookArr.forEach(element => {
        tRow = document.createElement('tr');
        tdPlace = document.createElement('td');
        tdPlace.textContent = element.place;
        tRow.appendChild(tdPlace);
        tdBookingDate = document.createElement('td');
        tdBookingDate.textContent = element.bookingDate;
        tRow.appendChild(tdBookingDate);
        tdBookedDate = document.createElement('td');
        tdBookedDate.textContent = element.bookedDate;
        tRow.appendChild(tdBookedDate);
        tdRoom = document.createElement('td');
        tdRoom.textContent = element.room;
        tRow.appendChild(tdRoom);
        tdPrice = document.createElement('td');
        tdPrice.textContent = element.price;
        tRow.appendChild(tdPrice);
        table.appendChild(tRow);
    });
    tableContainer.appendChild(table);
}

function main() {
    getDataFromXML(myURL)
    .then(r => {
        bookings = r.getElementsByTagName('booking');
        for (let i = 0; i < bookings.length; i++) {
            const element = bookings[i];
            place = element.getElementsByTagName('place')[0].textContent;
            bookingDate = element.getElementsByTagName('booking_date')[0].textContent;
            bookedDate = element.getElementsByTagName('booked_date')[0].textContent;
            room = element.getElementsByTagName('room')[0].textContent;
            price = element.getElementsByTagName('price')[0].textContent;

            const booking = new Book(place, bookingDate, bookedDate, room, price);
            bookArr.push(booking);
        }
        representData();
    });
}

window.addEventListener('load', main);