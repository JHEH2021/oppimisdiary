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


function changeBackground(id, color) {

    document.getElementById(id).style.background = color;
}




//jQuery, jolla Tiia sai toimimaan, mutta joka ei koskaan toiminut mulla... 
//$(document).ready(function () {
//	$('.form-control').bind("mouseover", function () {
//		var color = $(this).css("background-color");

//		$(this).css("background", "lightgray");

//		$(this).bind("mouseout", function () {
//			$(this).css("background", color);
//		})
//	})
//})


//$(document).ready(function () {
//	$('tr').bind("mouseover", function () {
//		var color = $(this).css("background-color");

//		$(this).css("background", "lightgray");

//		$(this).bind("mouseout", function () {
//			$(this).css("background", color);
//		})
//	})
//})

function annaOhjeita() {
    alert("Tällä sivuilla voit seurata oppimistasi ja asettaa tavoiteita. \nALOITA UUSI AIHE: voit syöttää lomakkeelle sen pyytämiä tietoja ja tallentaa ne. \nVoit myös palata tarkistamaan ja muokkaamaan niitä myöhemmin. \nKIRJOITA MUISTIINPANO: voi lisätä matkan varrella ideoitasi ja ajatuksiasi liittyen jonkin aiheen opiskeluun. \nTO DO: voit listata asioita, jotka täytyy tehdä seuraavaksi.");
}

//$(document).ready(function () {
//	$('.btn-success').click(function () {
//		if ($('#text').val().length != 0) {
//			var x = $('.container').html();
//			var y =
//				`<div class="alert alert-success alert-dismissible fade in">
//	<a href="#" class="close" data-dismiss="alert" aria-label="close">×</a>
//						` + $('#text').val() + `</div>`;
//			$('.container').html(y + x);
//			$('#text').val("");
//		} else alert("Enter some Text!");
//	});
//	// kun to do taskia klikataan
//	$(document).on('click', '.alert', function () {
//		if ($(this).css('text-decoration-line') == "none")
//			$(this).css('text-decoration-line', 'line-through');
//		else
//			$(this).css('text-decoration-line', 'none');
//	});
//});