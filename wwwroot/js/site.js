// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function() {
    $("#SelectedTagIds").multiselect({
        includeSelectAllOption: true,
    })

    $("#SelectedCategoryIds").multiselect({
        includeSelectAllOption: true,
    });
    $(".s2").select2();

    tinyMCE.init({
        mode: "textareas"
    });
    $("#wrap").wrap("<div class='container-fluid'></div>");


    

    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function(e) {
                $('#editimg').attr('src', e.target.result);
            }

            reader.readAsDataURL(input.files[0]); // convert to base64 string
        }
    }

    $("#myimg").change(function() {
        readURL(this);
    });

    $(".dropdown").hover(function() {
        var dropdownMenu = $(this).children(".dropdown-menu");
        if (dropdownMenu.is(":visible")) {
            dropdownMenu.parent().toggleClass("open");
        }
    });

    $('#postTable').DataTable();
    $('#cat').DataTable();
    $('#tag').DataTable();

});

