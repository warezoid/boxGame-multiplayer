/********** VARIABLES **********/
const playerOneBox = document.querySelector(".playerOneBox")
const playerTwoBox = document.querySelector(".playerTwoBox")

const randomGameBox = document.querySelector(".randomGameBox")

const playerOneScore = document.querySelector(".playerOneScore")
const playerTwoScore = document.querySelector(".playerTwoScore")

const playerOneName = document.querySelector(".playerOneName")
const playerTwoName = document.querySelector(".playerTwoName")

let playerOneScoreVar = 0
let playerTwoScoreVar = 0

let playerOneX = 0
let playerOneY = 0

let playerTwoX = 0
let playerTwoY = 0

let randomBoxX = 0
let randomBoxY = 0



/********** SET DATA FROM LOGIN FORM **********/
const setPlayers = () => {
    let playerArray = JSON.parse(localStorage.getItem("players"))

    playerOneName.innerText = playerArray[0].name
    playerTwoName.innerText = playerArray[1].name

    if(playerArray[0].color !== playerArray[1].color ){
        playerOneBox.style.backgroundColor = playerArray[0].color
        playerTwoBox.style.backgroundColor = playerArray[1].color 
    }
}

setPlayers()



/********** GENERATING RANDOMBOX POSITION **********/
const randomBoxPosition = () => {
    randomBoxX = (Math.floor(Math.random() * 18)) * 50
    randomBoxY = (Math.floor(Math.random() * 18)) * 50

    randomGameBox.style.left = `${randomBoxX}px`
    randomGameBox.style.top = `${randomBoxY}px`
}

randomBoxPosition() 



/********** PLAYERS MOVEMENT - ADDEVENTLISTENER **********/
window.addEventListener("keydown", (e) => {
    moveFunction(e.key)
    checkWinFunction()
    outOfBorderFunction()
})



/********** PLAYERS MOVEMENT - FUNCTION **********/
const moveFunction = (value) => {
    switch(value){
        /********** PLAYER 1 MOVEMENT **********/
        case "a":
            playerOneX -= 50
            stylesFunction(playerOneBox, "x", playerOneX)
            break

        case "d":
            playerOneX += 50
            stylesFunction(playerOneBox, "x", playerOneX)
            break

        case "w":
            playerOneY -= 50
            stylesFunction(playerOneBox, "y", playerOneY)
            break

        case "s":
            playerOneY += 50
            stylesFunction(playerOneBox, "y", playerOneY)
            break

        /********** PLAYER 2 MOVEMENT **********/
        case "ArrowLeft":
            playerTwoX -= 50
            stylesFunction(playerTwoBox, "x", playerTwoX)
            break

        case "ArrowRight":
            playerTwoX += 50
            stylesFunction(playerTwoBox, "x", playerTwoX)
            break

        case "ArrowUp":
            playerTwoY -= 50
            stylesFunction(playerTwoBox, "y", playerTwoY)
            break

        case "ArrowDown":
            playerTwoY += 50
            stylesFunction(playerTwoBox, "y", playerTwoY)
            break
    }
}



/********** SET POSITION FUNCTION **********/
const stylesFunction = (player, position, value) => {
    if(position == "x"){
        player.style.left = `${value}px`
    }
    else if(position == "y"){
        player.style.top = `${value}px`
    }
}



/********** CHECKING WIN **********/
const checkWinFunction = () => {
    if(playerOneX === randomBoxX && playerOneY === randomBoxY){
        playerOneScoreVar++
        playerOneScore.innerText = playerOneScoreVar
        randomBoxPosition()
    }
    else if(playerTwoX === randomBoxX && playerTwoY === randomBoxY){
        playerTwoScoreVar++
        playerTwoScore.innerText = playerTwoScoreVar
        randomBoxPosition()
    }
}



/********** OUT OF BORDER FUNCTION **********/
const outOfBorderFunction = () => {
    /********** PLAYER 1 BORDER **********/
    if(playerOneX >= 1900){
        playerOneX = 0
        stylesFunction(playerOneBox, "x", playerOneX)
        checkWinFunction()
    }
    else if(playerOneX < 0){
        playerOneX = 1850
        stylesFunction(playerOneBox, "x", playerOneX)
        checkWinFunction()
    }
    else if(playerOneY >= 900){
        playerOneY = 0
        stylesFunction(playerOneBox, "y", playerOneY)
        checkWinFunction()
    }
    else if(playerOneY < 0){
        playerOneY = 850
        stylesFunction(playerOneBox, "y", playerOneY)
        checkWinFunction()
    }

    /********** PLAYER 2 BORDER **********/
    if(playerTwoX >= 1900){
        playerTwoX = 0
        stylesFunction(playerTwoBox, "x", playerTwoX)
        checkWinFunction()
    }
    else if(playerTwoX < 0){
        playerTwoX = 1850
        stylesFunction(playerTwoBox, "x", playerTwoX)
        checkWinFunction()
    }
    else if(playerTwoY >= 900){
        playerTwoY = 0
        stylesFunction(playerTwoBox, "y", playerTwoY)
        checkWinFunction()
    }
    else if(playerTwoY < 0){
        playerTwoY = 850
        stylesFunction(playerTwoBox, "y", playerTwoY)
        checkWinFunction()
    }
}





/********** MADE BY warezoid_ **********/