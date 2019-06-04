// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ShowAttacks(battlemonID) {
    $.ajax({
        url: "/Battlemon/GetAttack",
        data: { 'id': battlemonID },
        succes: function (data) {
            $("#testspace").html(data);
        }
    });
}
