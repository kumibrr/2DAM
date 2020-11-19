const playerController = new PlayerController();
const boardController = new BoardController(5, 6);

function insertChip(ev) {
    const columnClicked = ev.target.attributes['value'].value;
    cellToFill = boardController.insertChip(columnClicked, playerController.playerTurn);
}

function main() {
    const boardView = document.getElementsByClassName('board')[0];
    boardView.addEventListener('click', ev => {
        insertChip(ev);
        playerController.swapTurns(boardView);
    });
    
}

window.addEventListener('load', main);