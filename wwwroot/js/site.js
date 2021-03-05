// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $("#SelectedTagIds").multiselect({
        includeSelectAllOption: true,
    })
    $("#SelectedCategoryIds").multiselect({
        includeSelectAllOption: true,
    });


    tinyMCE.init({
       
        mode: "textareas"
    });
    $("#wrap").wrap("<div class='container-fluid'></div>");


    $("#input").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#table tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });

    $("#tag").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#tagTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });

});

