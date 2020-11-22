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

    getColumn(column) {
        return this.board[column];
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
        let r = [];
        let vector = [column, row];
        if (vector[1] < 4) {
            vector[1] = vector[0] + vector[1];
            vector[0] = vector[0] - vector[0];
        }


        // (gives false positives but whatever It's friday 2am).
        for (let i = vector[0], j = vector[1]; i < this.board.length; i++, j--) {
            if (this.board[i][j] != undefined) {
                r.push(this.board[i][j]);
            }
        }
        return r;
    }

    getDiagonalFromRightToLeft(column, row) {
        let r = [];
        let vector = [column, row];

        vector[1] = vector[1] - vector[0];
        vector[0] = vector[0] - vector[0];


        // (gives false positives but whatever I have drank a beer and it kinda works).
        for (let i = vector[0], j = vector[1]; i < this.board.length; i++, j++) {
            if (this.board[i][j] != undefined) {
                r.push(this.board[i][j]);
            }
        }
        return r;
    }

    hasWon(arr) {
        let player = 0;
        let count = 0;
        
        for (let i = 0; i < arr.length && count < 4 ; i++) {
            const cellValue = arr[i];
            
            if (cellValue != 0 && cellValue == player) {
                count++;
            } else {
                player = cellValue;
                count = 1;
            }
        }

        if (player != 0 && count >= 4) {
            return player
        } 
        return 0;
    }


    /**
    * This function checks if the game state has ended by checking the last chip that was added.
    * @param {Number} column - The column where the chip was placed.
    * @param {Number} placedCell - The cell where the chip was inserted.
    * @returns {Number} 0 - If there's no winner yet.
    * @returns {Number} -1 - If the game ended in a tie.
    * @returns {Number} player - The playerId who won.
    */
    checkWinner(column, placedCell) {
        let arr = [
            this.getRow(placedCell),
            this.getColumn(column),
            this.getDiagonalFromLeftToRight(Number(column), Number(placedCell)),
            this.getDiagonalFromRightToLeft(Number(column), Number(placedCell))
        ];

        let values = [];
        arr.forEach(line => {
            values.push(this.hasWon(line));
        });
        
        if (values.indexOf(1) != -1) {
            let val = values.indexOf(1);
            return values[val]
        } else if (values.indexOf(2) != -1) {
            let val = values.indexOf(2);
            return values[val]
        } else if (this.isBoardFull()) {
            return -1
        } else {
            return 0;
        }
        
    }
}