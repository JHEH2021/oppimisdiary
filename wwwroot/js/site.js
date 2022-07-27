// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var poistaNappi = document.getElementById("delete");
poistaNappi.addEventListener('submit', (event) =>  {
    event.preventDefault();
    var choice = confirm("Oletko varma, että haluat poistaa aiheen?");
    if (choice) {
        deleteButton.submit();
    }
});

function myFunction() {
    document.getElementByClassName("form-control").onmouseover.backgroundColor = "lightblue";
}

/*document.getElementByClassName("form-control").addEventListener("mouseover", function () {
    document.getElementClassName("form-control").style.backgroundColor = "green";
});

document.getElementById("myID").addEventListener("mouseout", function () {
    document.getElementById("myID").style.backgroundColor = "red";
});*/