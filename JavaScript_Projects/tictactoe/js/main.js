let activePlayer = 'X';
let selectedSquares = [];

function placeXOrO(squareNumber) {      // Places X or O in a square 
    if (!selectedSquares.some(element => element.includes(squareNumber))) {
        let select = document.getElementById(squareNumber);
        if (activePlayer === 'X') {
            select.style.backgroundImage = 'url("./images/x.png")';
        }
        else {
            select.style.backgroundImage = 'url("./images/o.png")';
        }
        selectedSquares.push(squareNumber + activePlayer);
        checkWinConditions();
        if (activePlayer === 'X') {     //Changes active player
            activePlayer = 'O';
        }
        else {
            activePlayer = 'X';
        }
        audio('./audio/place.mp3');    // Plays placement audio
        if(activePlayer === 'O') {
            disableClick();     // Disables clicking while program selects a square
            setTimeout(function (){ computersTurn(); }, 1000)   // Waits one second before computer places an image and allows clicking
        }
        return true;
    }

    function computersTurn() {      // Selects random square, gives some impression of ai when there is none
        let success = false;
        let pickASquare;
        while(!success) {
            pickASquare = String(Math.floor(Math.random() * 9));
            if (placeXOrO(pickASquare)){
                placeXOrO(pickASquare);
                success = true;
            };
        }
    }
}

function checkWinConditions() {     // This function searches for win conditions
    if (arrayIncludes('0X', '1X', '2X')) { drawWinLine(50, 100, 558, 100) }
    else if (arrayIncludes('3X', '4X', '5X')) { drawWinLine(50, 304, 558, 304) }
    else if (arrayIncludes('6X', '7X', '8X')) { drawWinLine(50, 508, 558, 508) }
    else if (arrayIncludes('0X', '3X', '6X')) { drawWinLine(100, 50, 100, 558) }
    else if (arrayIncludes('1X', '4X', '7X')) { drawWinLine(304, 50, 304, 558) }
    else if (arrayIncludes('2X', '5X', '8X')) { drawWinLine(508, 50, 508, 558) }
    else if (arrayIncludes('6X', '4X', '2X')) { drawWinLine(100, 508, 510, 90) }
    else if (arrayIncludes('0X', '4X', '8X')) { drawWinLine(100, 100, 520, 520) }
    else if (arrayIncludes('0O', '1O', '2O')) { drawWinLine(50, 100, 558, 100) }
    else if (arrayIncludes('3O', '4O', '5O')) { drawWinLine(50, 304, 558, 304) }
    else if (arrayIncludes('6O', '7O', '8O')) { drawWinLine(50, 508, 558, 508) }
    else if (arrayIncludes('0O', '3O', '6O')) { drawWinLine(100, 50, 100, 558) }
    else if (arrayIncludes('1O', '4O', '7O')) { drawWinLine(304, 50, 304, 558) }
    else if (arrayIncludes('2O', '5O', '8O')) { drawWinLine(508, 50, 508, 558) }
    else if (arrayIncludes('6O', '4O', '2O')) { drawWinLine(100, 508, 510, 90) }
    else if (arrayIncludes('0O', '4O', '8O')) { drawWinLine(100, 100, 520, 520) }
    else if (selectedSquares.length >= 9) {     // Checks for tie
        audio('./audio/tie.mp3');
        setTimeout(function () { resetGame(); }, 1000);     // Sets a delay before resetGame is called
    }
    //This checks if an array has fulfilled the win condition
    function arrayIncludes(squareA, squareB, squareC) {
        const a = selectedSquares.includes(squareA)
        const b = selectedSquares.includes(squareB)
        const c = selectedSquares.includes(squareC)
        if (a === true && b === true && c === true) {return true}
    }

}

function disableClick() {       // This disables clicking from the player for 1 second
    body.style.pointerEvents = 'none';
    setTimeout(function () {body.style.pointerEvents = 'auto';}, 1000);
}

function audio(audioURL) {      // Plays specified audio when called 
    let audio = new Audio(audioURL);
    audio.play();
}

function drawWinLine(coordX1, coordY1, coordX2, coordY2) {  //This uses HTML to draw winning lines
    const canvas = document.getElementById('win-lines')
    const c = canvas.getContext('2d');
    let x1 = coordX1,
        x2 = coordX2,
        y1 = coordY1,
        y2 = coordY2,
        x = x1,
        y = y1;

    function animateLineDrawing() {     // Animates line drawing
        const animationLoop = requestAnimationFrame(animateLineDrawing);
        c.clearRect(0, 0, 608, 608)
        c.beginPath();
        c.moveTo(x1, y1)
        c.lineTo(x, y)
        c.lineWidth = 10;
        c.strokeStyle = "rgba(70, 255, 33, .8)";
        c.stroke();
        if (x1 <= x2 && y1 <= y2) {
            if (x < x2) {x += 10;}
            if (y < y2) {y += 10;}
            if (x >= x2 && y >= y2) {cancelAnimationFrame(animationLoop);}
        }
        if (x1 <= x2 && y1 >= y2) {
            if (x < x2) {x += 10;}
            if (y > y2) {y -= 10;}
            if (x >= x2 && y <= y2) {cancelAnimationFrame(animationLoop);}
        }
    }
    function clear() {      // Clears canvas after win line is drawn
        const animationLoop = requestAnimationFrame(clear);
        c.clearRect(0, 0, 608, 608);
        cancelAnimationFrame(animationLoop);
    }
    
    disableClick();     // While sound is playing, clicking disabled
    audio('./audio/winGame.mp3');
    animateLineDrawing();
    setTimeout(function () {clear(); resetGame();}, 1000);      //Resets game after a second and reenables clicking
}

function resetGame() {  // Resets game 
    for (let i = 0; i < 9; i++) {
        let square = document.getElementById(String(i))
        square.style.backgroundImage = ''
    }
    selectedSquares = [];
}