// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function(){
   /* $("ul.tabs li a:first").addClass("activo");*/
    $(".secciones div").hide();
    $(".secciones div:first").show();

   /* $("ul.tabs li a").click(function(){
        $("ul.tabs li a").removeClass("activo");
        $(this).addClass("activo");
        $(".secciones div").hide();

        var tabActivo = $(this).attr("href");
        $(tabActivo).show();
        return false;
    });*/



    $("a#btn-navegar").click(function(){
        $(".secciones div").hide();

        var tabActivo = $(this).attr("href");
        $(tabActivo).show();
        return false;
    });
});