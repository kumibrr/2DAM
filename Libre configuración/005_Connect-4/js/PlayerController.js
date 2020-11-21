class PlayerController {
    constructor() {
        this.playerTurn = 1; //1 or 2
    }

    swapTurns(viewController) {
        if (this.playerTurn == 1) {
            this.playerTurn = 2;
            viewController.classList.replace('player1', 'player2');
        } else {
            this.playerTurn = 1
            viewController.classList.replace('player2', 'player1')
        }
    }

    /**
    * @returns {String} css class name of the player who is currently playing.
    */
    getPlayerClass() {
        if (this.playerTurn == 1) {
            return 'player1';
        } else {
            return 'player2';
        }
    }
}

