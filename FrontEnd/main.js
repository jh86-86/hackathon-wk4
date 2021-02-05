


// const BACKEND_URL = "http://localhost:5000";  //keept to http as https 5001 didn't fetch

// async function loadInitialToDos() {
//   const res = await fetch(`${BACKEND_URL}/ToDoItems`);  //todoitems Camel
//   const data = await res.json();
//   data.forEach(renderToDo);
// }

const url="http://localhost:5000";

let matOpt= document.querySelector("#Matrix-optn");
let mySelect= document.querySelector("#mySelect");
let boxDescription=document.querySelector("#decPTag");

mySelect.addEventListener("onchange", fillDescription);

function fillDescription(description){
    console.log(description)
   boxDescription.innerHTML=description;
}

async function LoadMovieChoice(){
    const result = await fetch(`${url}/movies/1`);
    const data = await result.json();
    const mat= data.title;
    const matDec= data.description;
    console.log(matDec);
    matOpt.innerHTML=mat;
    fillDescription(matDec);
}

let hangOpt= document.querySelector("#TheHangover-optn");


async function LoadMovieChoiceTwo(){
    const result = await fetch(`${url}/movies/2`);
    const data = await result.json();
    const hangover= data.title;
    const hangDec= data.description;
    

}

async function LoadMovieChoiceThree(){
    const result = await fetch(`${url}/movies/3`);
    const data = await result.json();
    const titanic= data.title;
    const titDescription= data.description;

    

}

LoadMovieChoice();


LoadMovieChoiceTwo();

LoadMovieChoiceThree();
