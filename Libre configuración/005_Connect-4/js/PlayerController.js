class PlayerController {
    constructor() {
        this.playerTurn = 1; //1 or 2
    }

    swapTurns(boardView) {
        if (this.playerTurn == 1) {
            this.playerTurn = 2;
            boardView.classList.replace('player1', 'player2');
        } else {
            this.playerTurn = 1
            boardView.classList.replace('player2', 'player1')
        }
    }
}

