class BoardController {
    constructor(columns, rows) {
        this.board = new Array(columns);
        this.board.fill(new Array(rows).fill(0));
    }

    insertChip (column, player) {
        // returns -1 if no free cells in the column. Else returns the cell that's been filled
        const columnModel = this.board[column];

        if (this.FreeCellsInColumn != 0) {
            columnModel.push(player);
            
        } else {
            return -1;
        }
    }

    FreeCellsInColumn(column) {
        return 0;
    }

    isBoardFull() {
        return false;
    }

    checkWinner() {
        // returns 0 if no winner yet. Else returns player.
        return 0;
    }
}