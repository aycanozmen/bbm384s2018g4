$(document).ready(function () {


    $("#getBranchBtn").click(function () {
        getBranchTable();
    });



});

function getBranchTable() {

    jQuery.support.cors = true;

    $.ajax(
    {
        type: "POST",
        url: "sysbranchHandler.ashx/ProcessRequest?fnc=getTable",

        contentType: "application/json; charset=utf-8",
        dataType: "json",
        cache: false,
        success: function (data) {

            var trHTML = '';
            $('#branchTable tbody').html("");
            $.each($(data), function () {

                trHTML += '<tr id="row_' + this.Id + '"><td>' + this.Id + '</td><td>' + this.Name + '</td><td>' + this.City + '</td><td>'
                    + this.District + '</td><td>' + this.Street + '</td><td>' + this.Phone + '</td>' +
                    '<td><input type="button" class="deleteBtn" value="Delete Branch" rowId="' + this.Id + '" /> </td>' +
                    '<td><input type="button" value="Edit Branch" class="edit-branch" rowId="' + this.Id + '"  /></td>' + '</tr>';
            });

            $('#branchTable tbody').append(trHTML);

            deleteBtnEvent();
            editBtnEvent();
        },

        error: function (msg) {

            alert(msg.responseText);
        }
    });
}

function deleteBtnEvent() {
    $('.deleteBtn').click(function () {
        var confirmDelete = confirm("Are you sure you want to delete the course?");
        if (confirmDelete) {
            var id = $(this).attr("rowId");
            deleteRow(id);
        }

    });

}
function deleteRow(id) {

    $.ajax({

        type: "POST",
        url: "sysbranchHandler.ashx/ProcessRequest?fnc=deleteRow&branchID=" + id,
        contentType: "application/json; charset=utf-8",
        dataType: "text",

        success: function (data) {

            if (data == "Deleted.") {
                $("#row_" + id).remove();
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
}
function editBtnEvent() {

    var current_edit_row_details = {};
    var id;
    $('.edit-branch').click(function () {
        var tds = $(this).closest('tr').children('td');
        id = $(this).attr("rowId");
        //alert(tds[0].innerHTML) 
        var name = tds[1].innerHTML;
        var city = tds[2].innerHTML;
        var district = tds[3].innerHTML;
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
    //edit user dailog 
    edit_dialogs = $("#edit-dialog-form").dialog({
        autoOpen: false,
        height: 450,
        width: 350,
        modal: true,
        buttons: {
            "Edit course details": editCourse,
            Cancel: function () {
                edit_dialogs.dialog("close");
            }
        },

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

function newBranch(param) {

    $.ajax({

        type: "POST",
        url: "sysbranchHandler.ashx/ProcessRequest?fnc=newBranch" + param,
        contentType: "application/json; charset=utf-8",
        dataType: "text",

        success: function (data) {

            if (data == "Added.") {

                /*   $("#example tbody").append("<tr>" +
                     "<td>" + $("#name").val() + "</td>" +
                     "<td>" + $("#surname").val() + "</td>" +
                     "<td>" + $("#password").val() + "</td>" +
                     "<td>" + $("#birth").val() + "</td>" +
                     "<td>" + $("#position").val() + "</td>" +
                     "<td>" + $("#officer").val() + "</td>" +
                     "<td>" + $("#identity").val() + "</td>" +
                     "<td>" + $("#active").val() + "</td>" +
                     "<td>" + $("#auth").val() + "</td>" +
                     "<td>" + $("#exp").val() + "</td>" +
                      "</tr>");*/
                getBranchTable();
                alert("New Branch " + data);
            }
            else {
                alert("New Branch " + data);
            }

        }, error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }

    });

}
$(function () {
    var dialog;


    function addBranch() {
        var name = $('#name').val();//current_edit_row_details.name;
        var city = $('#city').val();
        var district = $('#district').val();
        var street = $('#street').val();
        var phone = $('#phone').val();

        var param ="&name=" + name + "&city=" + city + "&district=" + district + "&street=" + street + "&phone=" + phone;

        newBranch(param);
        dialog.dialog("close");
    }

    dialog = $("#create-dialog-form").dialog({
        autoOpen: false,
        height: 400,
        width: 350,
        modal: true,
        buttons: {
            "Create a course": addBranch,
            Cancel: function () {
                dialog.dialog("close");
            }
        },

    });

    $("#create").button().on("click", function () {

        dialog.dialog("open");
    });




});