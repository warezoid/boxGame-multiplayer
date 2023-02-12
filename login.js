/********** VARIABLES **********/
const form1 = document.querySelector(".form1")
const form2 = document.querySelector(".form2")

let playersArray = []
let id = 1



/********** CLEARING LOCAL STORAGE **********/
localStorage.clear()



/********** SUBMIT FUNCTION **********/
const submitFunction = (form, player) => {
    form.addEventListener("submit", (e) => {
        e.preventDefault()
        
        let textInput = e.target.elements[0].value
        let colorInput = e.target.elements[1].value
    
        if(textInput != "" && colorInput != "#000000" && colorInput != "#ffffff"){
            let playerObject = {
                id,
                name: textInput,
                color: colorInput
            }
    
            if(playersArray.length < 2){
                playersArray.push(playerObject)
                localStorage.setItem("players", JSON.stringify(playersArray))
                id++
            }
            else{
                location.reload()
            }

            e.target.elements[0].value = ""

            if(player === 1){
                e.target.elements[1].value = "#ff0000"

                form1.style.display = "none"
                form2.style.display = "block"
                submitFunction(form2, 2)
            }
            else if(player === 2){
                e.target.elements[1].value = "#0000ff"
                form2.style.display = "none"
                location.assign("index.html")
            }
        }
    })
}

submitFunction(form1, 1)





/********** MADE BY warezoid_ **********/