


// const BACKEND_URL = "http://localhost:5000";  //keept to http as https 5001 didn't fetch

// async function loadInitialToDos() {
//   const res = await fetch(`${BACKEND_URL}/ToDoItems`);  //todoitems Camel
//   const data = await res.json();
//   data.forEach(renderToDo);
// }

const url="http://localhost:5000";

async function LoadMovieChoice(){
    const result = await fetch(`${url}/movies`);
    const data = await result.json();
    console.log(data);
}

LoadMovieChoice();