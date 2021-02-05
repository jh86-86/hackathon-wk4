


// const BACKEND_URL = "http://localhost:5000";  //keept to http as https 5001 didn't fetch

// async function loadInitialToDos() {
//   const res = await fetch(`${BACKEND_URL}/ToDoItems`);  //todoitems Camel
//   const data = await res.json();
//   data.forEach(renderToDo);
// }



async function LoadMovieChoice(){
    const url="http://localhost:5000";
    const result=await fetch(`${url}/Movies`);
    const data= await result.json();
    console.log(data);
}

LoadMovieChoice();