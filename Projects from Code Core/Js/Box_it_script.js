// Box it Spring

//the first lie
const box_length = 9;

function drawLine2( bottomLines){

    let result2 = '\u250f';
    for (let y= 0; y< bottomLines; y++) {
        result2 =  result2 + '\u2501' 
        
        
    }

    result2 = result2 + '\u2513'
    return result2;
    
    }
   

   
 //drawBarsAround Function
 function drawBarsAround(name){
    return '\u2503' + name + '\u2503';
 }


    //the second/middle line
    function drawLine1( middleLines){

        let result1 = '\u2523';
        for (let j = 0; j < middleLines; j++) {
            result1 = result1 + '\u2550'
            
        }
        result1 = result1 + '\u252b'
        return result1;
        
        }
        
    
    
        
        

    //the third line
function drawLine( topLines){

let result = '\u2517';
for (let i = 0; i < topLines; i++) {
    result = result + '\u2501'
    
}
result = result + '\u251b'
return result;

}

;

//box it function
//writting a function which would split an array and would insert each element with a box 

function boxIt (){
    console.log(drawLine2,drawBarsAround,drawLine1, drawBarsAround,drawLine)
    
}

//add the name
// function name (){


// let Arr = string ['a','b','c','d']
// return (split.Arr (1)) = drawBarsAround
//  console.log(drawBarsAround)
// }
//the first lie

//calling the top line

//let arr = ['a','bb','ccc','dddd','fffff'];
let arr = process.argv.slice(2)
console.log(process.argv.slice(2));


let max_length=0;
arr.forEach(element=>{
    if (element.length>max_length) {
        max_length =element.length;
    }
})

console.log(drawLine2(max_length))

arr.forEach((element,index)=>{
    const left = max_length - element.length;
    console.log(drawBarsAround(element + " ".repeat(left)))

    
    //have to add if then so if it is the last element in the array
    // it would not console.log the middle line
    
    //calling the midlle line 
    if (index!==arr.length-1) {
        console.log(drawLine1(max_length))
    } 
    

})

//have to write a function that would count the length in name 
//and -it from the maxx lenght which would be box.length



//the bottom line
console.log(drawLine(max_length))