$(document).ready(function () {


    $("#getManagerBtn").click(function () {
        getManagerTable();
    });

    $("#getBranchBtn").click(function () {
        getBranchTable();
    });
});


function getManagerTable() {

    jQuery.support.cors = true;

    $.ajax(
    {
        type: "POST",
        url: "systrainerHandler.ashx/ProcessRequest?fnc=getTable",

        contentType: "application/json; charset=utf-8",
        dataType: "json",
        cache: false,
        success: function (data) {

            var trHTML = '';
            $('#managerTable tbody').html("");
            $.each($(data), function () {

                trHTML += '<tr id="row_' + this.Id + '"><td>' + this.Name + '</td><td>' + this.Surname + '</td><td>' + this.Username + '</td><td>'
                    + this.Phone + '</td><td>' + this.Gender + '</td><td>' + this.BirthDate + '</td><td>' + this.Domain + '</td>' +
                    '<td><input type="button" class="deleteBtn" value="Delete Trainer" rowId="' + this.Id + '" /> </td>' +
                    '<td><input type="button" value="Edit Trainer" class="edit-manager" rowId="' + this.Id + '"  /></td>' + '</tr>';
            });

            $('#managerTable tbody').append(trHTML);

            deletemanagerBtnEvent();
            editmanagerBtnEvent();
        },

        error: function (msg) {

            alert(msg.responseText);
        }
    });
}

function deletemanagerBtnEvent() {
    $('.deleteBtn').click(function () {
        var confirmDelete = confirm("Are you sure you want to delete the trainer?");
        if (confirmDelete) {
            var id = $(this).attr("rowId");
            deleteRow(id);
        }

    });

}
function deleteRow(id) {

    $.ajax({

        type: "POST",
        url: "systrainerHandler.ashx/ProcessRequest?fnc=deleteRow&branchID=" + id,
        contentType: "application/json; charset=utf-8",
        dataType: "text",

        success: function (data) {

            if (data == "Deleted.") {
                $("#row_" + id).remove();
                alert("Trainer " + data);
            }
            else {
                alert("Trainer" + data);
            }

        }, error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }

    });
}

function editBtnEvent() {

    var current_edit_row_details = {};
    var id;
    $('.edit-manager').click(function () {
        var tds = $(this).closest('tr').children('td');
        id = $(this).attr("rowId");
        //alert(tds[0].innerHTML) 
        var name = tds[1].innerHTML;
        var surname = tds[2].innerHTML;
        var username = tds[3].innerHTML;
        var street = tds[4].innerHTML;
        var phone = tds[5].innerHTML;


        $('#edit_name').val(name);
        $('#edit_city').val(city);
        $('#edit_district').val(district);
        $('#edit_street').val(street);
        $('#edit_phone').val(phone);

        current_edit_row_details.name = name;
        current_edit_row_details.city = city;
        current_edit_row_details.district = district;
        current_edit_row_details.street = street;
        current_edit_row_details.phone = phone;

        current_edit_row_details.current_row = $(this).closest('tr');

        edit_dialogs.dialog("open");

    });




    function editCourse() {

        var valid = true;
        //console.log('current_edit_row_details = ');
        //console.log(current_edit_row_details);

        var tds = $(current_edit_row_details.current_row).children('td');

        var name = $('#edit_name').val();//current_edit_row_details.name;
        var city = $('#edit_city').val();
        var district = $('#edit_district').val();
        var street = $('#edit_street').val();
        var phone = $('#edit_phone').val();

        var param = "&branchID=" + id + "&name=" + name + "&city=" + city + "&district=" + district + "&street=" + street + "&phone=" + phone;
        //editRow(param);

        $.ajax({

            type: "POST",
            url: "sysbranchHandler.ashx/ProcessRequest?fnc=editRow" + param,
            contentType: "application/json; charset=utf-8",
            dataType: "text",

            success: function (data) {

                if (data == "Updated.") {
                    tds[1].innerHTML = name;
                    tds[2].innerHTML = city;
                    tds[3].innerHTML = district;
                    tds[4].innerHTML = street;
                    tds[5].innerHTML = phone;

                    alert("Branch " + data);

                }
                else {
                    alert("Branch " + data);
                }

            }, error: function (xhr, ajaxOptions, thrownError) {
                alert(xhr.status);
                alert(thrownError);
            }

        });


        edit_dialogs.dialog("close");


        return valid;
    }


}





function newManager(param) {

    $.ajax({

        type: "POST",
        url: "systrainerHandler.ashx/ProcessRequest?fnc=newManager" + param,
        contentType: "application/json; charset=utf-8",
        dataType: "text",

        success: function (data) {

            if (data == "Added.") {

                getManagerTable();
                alert("New Trainer " + data);
            }
            else {
                alert("New Trainer " + data);
            }

        }, error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }

    });

}
$(function () {
    var dialog;

    function addManager() {
        var name = $('#name').val();//current_edit_row_details.name;
        var surname = $('#surname').val();
        var username = $('#username').val();
        var password = $('#password').val();
        var phone = $('#phone').val();
        var gender = $('#gender').val();
        var birthdate = $('#birthdate').val();
        var domain = $('#domain').val();

        var param = "&name=" + name + "&surname=" + surname + "&username=" + username + "&password=" + password + "&phone=" + phone + "&gender=" + gender + "&birthdate=" + birthdate + "&domain=" + domain;

        newManager(param);
        dialog.dialog("close");
    }

    dialog = $("#create-dialog-form").dialog({
        autoOpen: false,
        height: 400,
        width: 350,
        modal: true,
        buttons: {
            "Add a trainer": addManager,
            Cancel: function () {
                dialog.dialog("close");
            }
        },

    });


    $("#create").button().on("click", function () {

        dialog.dialog("open");
    });



});

