class Life {
    constructor(xCells, yCells, width, height, domElement) {
        this.xCells = xCells;
        this.yCells = yCells;
        this.width = width;
        this.height = height;
        this.CellWidth = Math.floor(this.width / this.xCells);
        this.CellHeight = Math.floor(this.height / this.yCells);
        this.cells = [];
        this.dom = domElement;
        this.sheet = document.styleSheets[0];
        this.rules = this.sheet.cssRules || this.sheet.rules;
        this.Setup();
    }

    Setup() {
        this.FillCells();
        this.BuildBoard();
        let styles = `.cell {box-sizing: border-box; border: 1px solid black; width: ${this.CellWidth}px; height: ${this.CellHeight}px;}`;
        styles += ` .gameWrapper {display: grid; grid-template-columns: repeat(${this.xCells}, ${this.CellWidth}px);}`;
        this.InsertStyles(styles);
        this.rawCells = [...this.dom.childNodes];
        this.GetState();
    }

    FillCells() {
        for (var i = 0; i < this.xCells; i++) {
            var row = [];
            for (var j = 0; j < this.yCells; j++) {
                row.push('D');
            }
            this.cells.push(row);
        }
    }


    InsertStyles(styles) {
        let css = document.createElement('style');
        css.type = 'text/css';
        if (css.styleSheet) {
            css.styleSheet.cssText = styles;
        } else {
            css.appendChild(document.createTextNode(styles));
        }
        document.getElementsByTagName("head")[0].appendChild(css);
    }

    GetSurroundingCells(x, y) { // Old code
        let cellList = [];
        for (let i = -1; i < 2; i++) {
            for (let j = -1; j < 2; j++) {
                try {
                    if (i != 0 || j != 0) {
                        if (this.cells[parseInt(x + i)][parseInt(y + j)]) {
                            cellList.push(this.cells[parseInt(x + i)][parseInt(y + j)]);
                        }
                    }
                } catch {

                }
            }
        }
        return cellList;
    }

    GetState() {
        //Gets the cells from the view and translates it into the cells element
        
        for (let c of this.rawCells) {
            this.cells[parseInt(c.getAttribute('x'))][parseInt(c.getAttribute('y'))] = c.classList.contains('alive') ? 'A' : 'D';
        }
    }

    SetState() {
        //Pushes the this.cells state to the view page
        for (var c of this.rawCells) {
            c.classList.remove('alive');
            c.classList.remove('dead');
            c.classList.add(this.cells[parseInt(c.getAttribute('x'))][parseInt(c.getAttribute('y'))] == 'A' ? 'alive' : 'dead');
        }
    }

    OneStep() {
        var newState = [];
        for (var i = 0; i < this.xCells; i++) {
            var row = [];
            for (var j = 0; j < this.yCells; j++) {
                let surrounding = this.GetSurroundingCells(i, j);
                row.push(this.LiveOrDie(this.cells[i][j], surrounding) ? 'A' : 'D');
            }
            newState.push(row);
        }
        this.cells = newState;
    }

    LiveOrDie(self, neighbors) {
        let alive = 0;
        for (var n of neighbors) {
            if (n == 'A') {
                alive++;
            }
        }

        if (self == 'A') {
            if (alive < 2) {
                return false;
            } else if (alive >= 2 && alive < 4) {
                return true;
            } else {
                return false;
            }
        } else {
            if (alive == 3) {
                return true;
            } else {
                return false;
            }
        }
    }

    BuildBoard() {
    let html = '';
    for (let i of [...Array(this.xCells).keys()]) {
        for (let j of [...Array(this.yCells).keys()]) {
            html += this.InsertCell(i, j);
        }
    }
    this.dom.innerHTML = html;
    }

    InsertCell(x, y) {
        return `<div class="cell dead" x="${x}" y="${y}" onclick="setCell(this)"></div>`
    }

}

function setCell(element) {
    if (element.classList.contains('dead')) {
        element.classList.add('alive');
        element.classList.remove('dead');
    } else {
        element.classList.add('dead');
        element.classList.remove('alive');
    }
}

String.prototype.replaceAt = function (index, replacement) {
    if (index >= this.length) {
        return this.valueOf();
    }

    var chars = this.split('');
    chars[index] = replacement;
    return chars.join('');
}