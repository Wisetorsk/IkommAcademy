class GameOfLife {

    constructor(xCells, yCells, width, height, domElement) {
        this.xCells = xCells;
        this.yCells = yCells;
        this.width = width;
        this.height = height;
        this.cells = new Array(xCells);
        this.dom = domElement;
        this.sheet = document.styleSheets[0];
        this.sheet.insertRule('cell {width: ${this.width}px; height: ${this.height}px}');
        this.sheet.insertRule(); //Insert rule to get the correct dimetions of cells in the page
    }

    CreateCellsCollection() {
        for (var i = 0; i < this.xCells; i++) {
            this.cells[i] = new Array(yCells);
        }
    }

    FillCells() {
        for (var i = 0; i < this.xCells; i++) {
            for (var j = 0; j < this.yCells; j++) {
                this.cells[i][j] = new Cell(i, j);
            }
        }
    }

    InsertGameDivs() {
        for (var row in this.cells) {
            for (var cell in row) {
                const cellElement = document.createElement('div');
                cellElement.classList.add((cell.alive) ? "alive" : "dead", "cell");
                cellElement.setAttribute("x", cell.x);
                cellElement.setAttribute("y", cell.y);
                dom.appendChild(cellElement);
            }
        }
    }

    OneStep() {
        // Runs the simulation one step at a time. 
        UpdateDivs();
    }

    UpdateDivs() {
        // Updates the divs on screen according to the state of the cells.
        for (var i = 0; i < this.xCells; i++) {
            for (var j = 0; j < this.yCells; j++) {
                document.getElementById();
            }
        }
    }

    UpdateSingle(x, y) {

    }
}