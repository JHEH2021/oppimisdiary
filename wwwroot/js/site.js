// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var deleteButton = document.getElementById("delete");

function confirmDelete() {
    deleteButton.addEventlistener("submit",
        (event) => {
            event.preventDefault();
            var choice = confirm("Are you sure you want to delete the complete Topic?");
            if (choice) {
                deleteButton.submit();
            }

        });
}




function changeBackground(id, color) {

    document.getElementById(id).style.background = color;
}




function annaOhjeita() {
    alert("Tällä sivuilla voit seurata oppimistasi ja asettaa tavoiteita. \nALOITA UUSI AIHE: voit syöttää lomakkeelle sen pyytämiä tietoja ja tallentaa ne ja seurata näin edistymistäsi. \nTO DO: voit listata tehtäviä, jotka täytyy tehdä pikaisesti.");
}

