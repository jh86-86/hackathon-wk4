const url="http://localhost:5000";

let matOpt = document.querySelector("#Matrix-optn");
let hangOpt = document.querySelector("#TheHangover-optn");
let titanicOpt = document.querySelector("#Titanic-optn");
let mySelect = document.querySelector("#mySelect");
let boxDescription = document.querySelector("#descPTag");

mySelect.addEventListener("onchange", fillDescription);

function fillDescription(description){
    console.log(description)
    boxDescription.innerHTML = description;
}

async function LoadMovieChoiceOne(){
    const result = await fetch(`${url}/movies/1`);
    const data = await result.json();
    const mat = data.title;
    const matDec = data.description;
    console.log(matDec);
    matOpt.innerHTML = mat;
    fillDescription(matDec);
}

async function LoadMovieChoiceTwo(){
    const result = await fetch(`${url}/movies/2`);
    const data = await result.json();
    const hangover = data.title;
    const hangDec = data.description;
    console.log(hangDec);
    hangOpt.innerHTML = hangover;
    fillDescription(hangDec); 
}

async function LoadMovieChoiceThree(){
    const result = await fetch(`${url}/movies/3`);
    const data = await result.json();
    const titanic = data.title;
    const titDec = data.description;   
    console.log(titDec);
    titanicOpt.innerHTML = titanic;
    fillDescription(titDec);
}

LoadMovieChoiceOne();

LoadMovieChoiceTwo();

LoadMovieChoiceThree();
