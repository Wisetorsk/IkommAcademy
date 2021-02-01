let canvas = document.getElementById("canvas");
let wWidth = 600;
let wHeight = 600;
let xPos = wWidth/2;
let yPos = wHeight/2;
let xDir = 1;
let yDir = 1;
let xVel = 10;
let yVel = 25;
let bounceModX = 0.9;
let bounceModY = 0.9;

ctx = canvas.getContext("2d");
ctx.canvas.width = wWidth;
ctx.canvas.height = wHeight;
ctx.setLineWidth = 10;
let i = setInterval(animate, 50);

function animate() {
    ctx.clearRect(0, 0, 600, 600);
    ctx.beginPath();
    ctx.fillRect(xPos, yPos, 50, 50);
    xVel *= ((xPos + xVel) > wWidth - 50 || (xPos + xVel) < 0) ? -1 : 1;
    yVel *= ((yPos + yVel) > wHeight - 50|| (yPos + yVel) < 0) ? -1 : 1;
    xPos += xVel;
    yPos += yVel;
}