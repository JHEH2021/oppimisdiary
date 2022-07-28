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

function annaOhjeita() {
    alert("Tällä sivuilla voit seurata oppimistasi ja asettaa tavoiteita. \nALOITA UUSI AIHE voit syöttää lomakkeelle sen pyytämiä tietoja ja tallentaa ne. \nVoit myös palata tarkistamaan ja muokkaamaan niitä myöhemmin. \n\"KIRJOITA MUISTIINPANO\" voi lisätä matkan varrella ideoitasi ja ajatuksiasi liittyen jonkin aiheen opiskeluun.");
}

var count = 0;
function changeColor() {
    setTimeout("showColorChange()", 500);
}
function showColorChange() {
    var bg = new Array("red", "darkblue", "sky", "yellow", "blue", "pink", "green");
    var txt = new Array("black", "white", "green", "blue", "pink", "red", "yellow");
    if (count <= 6) {
        document.getElementById("divChangeColor").style.backgroundColor = bg[count++];
        document.getElementById("txtChangeColor").style.color = txt[count++];
        setTimeout("showColorChange()", 500);
    }
    else {
        count = 0;
        changeColor();
    }
}
function changeBackground(color) {
    document.getElementsByClassName("form-control").style.background = color;
}

document.addEventListener("onmouseover", function () { changeBackground('gray') });

function bgChange(bg) {
    document.getElementsByClassName("form-control" ).style.background = bg;
}