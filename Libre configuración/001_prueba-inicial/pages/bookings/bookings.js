const myURL = '/assets/bookings.xml';

class book {
    book(place, bookingDate, bookedDate, room, price) {
        this.place = place;
        this.bookingDate = bookingDate;
        this.bookedDate = bookedDate;
        this.room = room;
        this.price = price;
    }
}

function getDataFromXML() {
    let xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState === 4 && this.status === 200) {
            console.log(this.response);
        }
    }
    xhttp.open("GET", myURL);
    xhttp.send();
}


function main() {
    getDataFromXML();
}

window.addEventListener('load', main);