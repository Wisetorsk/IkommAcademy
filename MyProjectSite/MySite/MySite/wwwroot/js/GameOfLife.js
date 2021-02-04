class GameOfLife {

    constructor(xCells, yCells, width, height, domElement) {
        this.xCells = xCells;
        this.yCells = yCells;
        this.width = width;
        this.height = height;
        this.cells = new Array(xCells);
        this.dom = domElement;
        this.sheet = document.styleSheets[0];
        this.Setup();
    }

    Setup() {
        this.sheet.insertRule(`cell {width: ${Math.floor(this.width/this.xCells)}px; height: ${Math.floor(this.height/this.yCells)}px}`, 0);
        //this.sheet.insertRule(); //Insert rule to get the correct dimetions of cells in the page
        this.CreateCellsCollection();
        this.FillCells();
        this.InsertGameDivs();
    }

    CreateCellsCollection() {
        for (var i = 0; i < this.xCells; i++) {
            this.cells[i] = new Array(this.yCells);
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
        for (var row of this.cells) {
            for (var cell of row) {
                const cellElement = document.createElement('div');
                cellElement.classList.add((cell.alive) ? "alive" : "dead", "cell");
                //cellElement.id = `x${cell.x}y${cell.y}`;
                let attX = document.createAttribute("x");
                attX.value = cell.x;
                let attY = document.createAttribute("y");
                attY.value = cell.y;
                cellElement.setAttributeNode(attX);
                cellElement.setAttributeNode(attY);
                this.dom.appendChild(cellElement);
            }
        }
    }

    GetNeighbors(cell) {
        let xBase = cell.x;
        let yBase = cell.y;
    }

    OneStep() {
        // Runs the simulation one step at a time. 
        UpdateDivs();
        var nextFrame = new Array(this.xCells);
        for (var i = 0; i < nextFrame.length; i++) {
            nextFrame[i] = new Array(this.yCells);
        }
    }

    UpdateDivs() {
        // Updates the divs on screen according to the state of the cells.
        for (var i = 0; i < this.xCells; i++) {
            for (var j = 0; j < this.yCells; j++) {
                this.UpdateSingle(i, j);
            }
        }
    }

    UpdateSingle(x, y) {

    }
}