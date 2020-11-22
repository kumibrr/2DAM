let playerController = new PlayerController();
let boardController = new BoardController(5, 6);

let gameState = 0;

function insertChip(ev) {
    const columnClicked = ev.target.attributes['value'].value;
    cellToFill = boardController.insertChip(columnClicked, playerController.playerTurn);
    console.log(ev);
    if (cellToFill != -1) {
        ev.target.children[cellToFill].classList.replace('empty', playerController.getPlayerClass());
        
        let updatedGameState = boardController.checkWinner(columnClicked, cellToFill);
        
        gameState = updatedGameState;
    }
}

function handleGameStateChange() {
    if (gameState != 0) {
        const parent = document.getElementsByClassName('win')[0];

        if (gameState != -1) {
            let h1 = document.createElement('h1');
            h1.textContent = 'Ha ganado el jugador ' + gameState;
            parent.appendChild(h1);
        } else {
            let h1 = document.createElement('h1');
            h1.textContent = 'No ha ganado nadie :/';
            parent.appendChild(h1);
        }
    }
}

function main() {
    const boardView = document.getElementsByClassName('board')[0];
    boardView.addEventListener('click', ev => {
        if (gameState == 0) {
            insertChip(ev);
            playerController.swapTurns(boardView);
            handleGameStateChange();
        }
    });

    const newGame = document.getElementsByClassName('buttons')[0];

    newGame.addEventListener('click', (ev) => {
        if (ev.target.classList.value.includes('1p')) {
            location.reload();
        } else if (ev.target.classList.value.includes('2p')) {
            location.reload();
        }
    });
    
}

window.addEventListener('load', main);