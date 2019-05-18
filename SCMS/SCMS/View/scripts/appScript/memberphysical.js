﻿$(document).ready(function () {


    $("#getPhysicalBtn").click(function () {
        getCourseTable();
    });

});

function getCourseTable() {

    jQuery.support.cors = true;

    $.ajax(
    {
        type: "POST",
        url: "sysphysicalHandler.ashx/ProcessRequest?fnc=getTable",

        contentType: "application/json; charset=utf-8",
        dataType: "json",
        cache: false,
        success: function (data) {

            var trHTML = '';
            $('#physicalTable tbody').html("");
            $.each($(data), function () {

                trHTML += '<tr id="row_' + this.Id + '"><td>' + this.Name + '</td><td>' + this.Surname + '</td><td>'
                    + this.Username + '</td><td>' + this.Height + '</td><td>' + this.Weight + '</td><td>'
                    + this.Waistline + '</td><td>' + this.Arm + '</td><td>' + this.Leg + '</td><td>' + this.Shoulder + '</td><td>' + this.Chest + '</td><td>' + this.BodyFat + '</td>' +
                
                    '<td><input type="button" value="Edit Properties" class="edit-course" rowId="' + this.Id + '"  /></td>' + '</tr>';
            });

            $('#physicalTable tbody').append(trHTML);

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
        url: "syscourseHandler.ashx/ProcessRequest?fnc=deleteRow&courseID=" + id,
        contentType: "application/json; charset=utf-8",
        dataType: "text",

        success: function (data) {

            if (data == "Deleted.") {
                $("#row_" + id).remove();
                alert("Course " + data);
            }
            else {
                alert("Course " + data);
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
    $('.edit-course').click(function () {
        var tds = $(this).closest('tr').children('td');
        id = $(this).attr("rowId");
        //alert(tds[0].innerHTML) 
        var name = tds[3].innerHTML;
        var maxQuota = tds[4].innerHTML;
        var periodWeek = tds[5].innerHTML;
        var durationMinute = tds[6].innerHTML;
        var level = tds[7].innerHTML;
        var price = tds[8].innerHTML;
        var equipment = tds[9].innerHTML;
        var information = tds[10].innerHTML;


        $('#edit_course').val(name);
        $('#edit_quota').val(maxQuota);
        $('#edit_period').val(periodWeek);
        $('#edit_duration').val(durationMinute);
        $('#edit_level').val(level);
        $('#edit_price').val(price);
        $('#edit_equipment').val(equipment);
        $('#edit_information').val(information);


        current_edit_row_details.name = name;
        current_edit_row_details.maxQuota = maxQuota;
        current_edit_row_details.periodWeek = periodWeek;
        current_edit_row_details.durationMinute = durationMinute;
        current_edit_row_details.level = level;
        current_edit_row_details.price = price;
        current_edit_row_details.equipment = equipment;
        current_edit_row_details.information = information;
        current_edit_row_details.current_row = $(this).closest('tr');

        edit_dialogs.dialog("open");

    });
    //edit course dailog 
    edit_dialogs = $("#edit-dialog-form").dialog({
        autoOpen: false,
        height: 450,
        width: 350,
        modal: true,
        buttons: {
            "Edit properties": editCourse,
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

        var name = $('#edit_course').val();//current_edit_row_details.name;
        var maxQuota = $('#edit_quota').val();
        var periodWeek = $('#edit_period').val();
        var durationMinute = $('#edit_duration').val();
        var level = $('#edit_level').val();
        var price = $('#edit_price').val();
        var equipment = $('#edit_equipment').val();
        var information = $('#edit_information').val();
        
        var param = "&courseID=" + id + "&name=" + name + "&maxQuota=" + maxQuota + "&periodWeek=" + periodWeek + "&durationMinute=" + durationMinute + "&level=" + level + "&price=" + price
                    + "&equipment=" + equipment + "&information=" + information;
        //editRow(param);

        $.ajax({

            type: "POST",
            url: "sysphysicalHandler.ashx/ProcessRequest?fnc=editRow" + param,
            contentType: "application/json; charset=utf-8",
            dataType: "text",

            success: function (data) {

                if (data == "Updated.") {
                    tds[3].innerHTML = name;
                    tds[4].innerHTML = maxQuota;
                    tds[5].innerHTML = periodWeek;
                    tds[6].innerHTML = durationMinute;
                    tds[7].innerHTML = level;
                    tds[8].innerHTML = price;
                    tds[9].innerHTML = equipment;
                    tds[10].innerHTML = information;

                    alert("Properties " + data);

                }
                else {
                    alert("Properties " + data);
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

function newCourse(param) {

    $.ajax({

        type: "POST",
        url: "syscourseHandler.ashx/ProcessRequest?fnc=newCourse" + param,
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
                getCourseTable();
                alert("New Course " + data);

            }
            else {
                alert("New Course " + data);
            }

        }, error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }

    });

}
$(function () {
    var dialog;


    function addCourse() {
        var name = $('#course').val();//current_edit_row_details.name;
        var maxQuota = $('#quota').val();
        var periodWeek = $('#period').val();
        var durationMinute = $('#duration').val();
        var level = $('#level').val();
        var price = $('#price').val();
        var equipment = $('#equipment').val();
        var information = $('#information').val();
        if (name == "" || maxQuota == "" || periodWeek == "" || durationMinute == "" || level == "" || price == "") {
            alert("It is necessary to fill in areas outside equipment and information");
        }
        var param = "&name=" + name + "&maxQuota=" + maxQuota + "&periodWeek=" + periodWeek + "&durationMinute=" + durationMinute + "&level=" + level + "&price=" + price
                   + "&equipment=" + equipment + "&information=" + information;
        newCourse(param);
        dialog.dialog("close");
    }

    dialog = $("#create-dialog-form").dialog({
        autoOpen: false,
        height: 400,
        width: 350,
        modal: true,
        buttons: {
            "Create a course": addCourse,
            Cancel: function () {
                dialog.dialog("close");
            }
        },

    });

    $("#create").button().on("click", function () {

        dialog.dialog("open");
    });




});