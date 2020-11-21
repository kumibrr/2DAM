class BoardController {
    constructor(columns, rows) {
        this.board = new Array(columns);
        for (let i = 0; i < this.board.length; i++) {
            this.board[i] = new Array(rows).fill(0);
        }
    }

    /**
    * Inserts the chip into the board.
    * @param {Number} column - The column where the chip was placed.
    * @param {Number} playerID - The cell where the chip was inserted.
    * @returns {Number} - The cell that's been filled.
    * @returns {Number} -1 - If the column is full.
    */
    insertChip (column, player) {
        const freeCells = this.FreeCellsInColumn(column) - 1;
        if (freeCells != -1) {
            this.board[column][freeCells] = player;
        }
        return freeCells;
    }

    FreeCellsInColumn(column) {
        let freeCells = this.board[column].length;
        for (let i = this.board[column].length - 1; i >= 0; i--) {
            if (this.board[column][i] != 0) {
                freeCells--;
            }
        }
        if (freeCells > 0) {
            return freeCells;
        } else {
            return 0;
        }
    }

    isBoardFull() {
        let isFull = true;
        this.board.forEach(column => {
            column.forEach(cell => {
                if (cell == 0) {
                    isFull = false;
                }
            })
        });
        return isFull;
    }

    getRow(row) {
        let r = [];
        for (let i = 0; i < this.board[0].length - 1; i++) {
            const element = this.board[i][row];
            r[i] = element;
        }
        return r
    }

    getDiagonalFromLeftToRight(column, row) {
        // This code below is an awful way to w̶a̶s̶t̶e̶ enjoy a friday night.
        // Please enjoy.
        let r = [];
        let vector = [column, row];
        if (vector[1] != 5) {
            vector[1] = vector[0] + vector[1];
            vector[0] = vector[0] - vector[0];
        }
        // Checks if the given coordinates are in at least a 4-length diagonal 
        // (gives false positives but whatever It's friday 2am).
        if (this.board.length - vector[0] >= 4) {
            if (this.board[column].length - vector[1] - 1 <= 2) {
                for (let i = vector[0], j = vector[1]; i < this.board.length; i++, j--) {
                    r.push(this.board[i][j]);
                }
            }
        }
        return r;
    }


    /**TODO:
    getDiagonalFromRightToLeft(column, row) {
        // This code below is an awful way to w̶a̶s̶t̶e̶ enjoy a friday night.
        // Please enjoy.
        let r = [];
        let vector = [column, row];
        if (vector[1] != 5) {
            vector[1] = vector[0] + vector[1];
            vector[0] = vector[0] - vector[0];
        }
        // Checks if the given coordinates are in at least a 4-length diagonal 
        // (gives false positives but whatever It's friday 2am).
        if (this.board.length - vector[0] >= 4) {
            if (this.board[column].length - vector[1] - 1 <= 2) {
                for (let i = vector[0], j = vector[1]; i < this.board.length; i++, j--) {
                    r.push(this.board[i][j]);
                }
            }
        }
        return r;
    }
    */


    /**
    * This function checks if the game state has ended by checking the last chip that was added.
    * @param {Number} column - The column where the chip was placed.
    * @param {Number} placedCell - The cell where the chip was inserted.
    * @returns {Number} 0 - If there's no winner yet.
    * @returns {Number} -1 - If the game ended in a tie.
    * @returns {Number} player - The playerId who won.
    */
    checkWinner(column, placedCell) {
        console.log(this.getDiagonalFromLeftToRight(Number(column) , Number(placedCell)));
        // console.log(placedCell);

        return 0;
    }
}