//Welcome to TodoCLI!
// ---------------------
// (v) View - (n) New - (cX) Complete - (dX) Delete - (q) Quit

function intro(){
    console.log(
        '\x1b[36m%s\x1b[0m',
        "\n ___________________________________________________________",
)
    console.log(
        '\x1b[36m%s\x1b[0m',
        "\n                     Welcome to TodoCLI!                    ",
    )
    console.log(
        '\x1b[36m%s\x1b[0m',
        "\n ___________________________________________________________",
)
    console.log(    
        '\x1b[36m%s\x1b[0m',
        "\n (v) View - (n) New - (cX) Complete - (dX) Delete - (q) Quit"
    )
    console.log(
        '\x1b[36m%s\x1b[0m',
        " ___________________________________________________________",
)
    console.log(

    )
}
intro();

let todoitem = [];
const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
})
getUserInput();

function getUserInput(){
    readline.question('Command: ', function(answer) {
        if(answer == 'v'){ //view
            if (todoitem.length === 0){
                console.log('Empty list!')
                intro();
                getUserInput();
            }
            else {
                for(var i=0; i<todoitem.length; i++){
                    numericVal = i+1
                    if (todoitem[i].completed == false){
                        console.log(numericVal + " [] " + todoitem[i].item)
                    } else {
                        console.log(numericVal + " [✓] " + todoitem[i].item)
                    }
                    
                }
                intro();
                getUserInput();
            }
        } 
        else if(answer == 'n'){
            readline.question("New task: ", function(item){
                todoitem.push({item: item, completed:false})
                intro();
                getUserInput();
            })
        }
        else if(answer[0] == 'c'){
            if(answer.length == 1){
                console.log("No task found, please enter a valid task number")
                intro();
                getUserInput();
            } else{
                var location = answer.substring(1, answer.length)
                if(isNaN(location) == true){
                    console.log("Invalid input")
                } else {
                    location = parseInt(location) 
                    if (location > todoitem.length){
                        console.log("Task does not exist")
                    } else if(location<0) {
                        console.log("Input is negative")
                    } else {
                        console.log("Completed \"" + todoitem[location-1].item + "\"")
                        todoitem[location-1].completed = true
                    }
                }
                intro();
                getUserInput();
            }
        }
        else if(answer[0] == 'd'){
            if(answer.length == 1){
                console.log("No task found, please enter a valid task number")
                intro();
                getUserInput();
            } else{
                var location = answer.substring(1, answer.length)
                if(isNaN(location) == true){
                    console.log("Invalid input")
                } else {
                    location = parseInt(location) 
                    if (location > todoitem.length){
                        console.log("Task does not exist")
                    } else if(location<0) {
                        console.log("Input is negative")
                    } else {
                        console.log("Deleted \"" + todoitem[location-1].item + "\"")
                        todoitem.splice(location-1, 1);
                    }
                }
                intro();
                getUserInput();
            }
            
        } else if(answer == 'q'){
            console.log("See you soon!")
            process.exit()
        } else {
            console.log("Please enter a valid menu command")
            intro();
            getUserInput();
        }
    })
}
