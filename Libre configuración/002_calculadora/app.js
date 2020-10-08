
function register(ev) {
    console.log(ev.target.value);
}


function main() {
    document.querySelectorAll('button').forEach((item) => {
        item.addEventListener('click', (ev) => {register(ev)});
    });
}

window.addEventListener('load', main);