$(document).ready(function () {


    $("#getPaymentsBtn").click(function () {
        getPaymentsTable();
    });



});

function getPaymentsTable() {

    jQuery.support.cors = true;

    $.ajax(
    {
        type: "POST",
        url: "syspaymentHandler.ashx/ProcessRequest?fnc=getTable",

        contentType: "application/json; charset=utf-8",
        dataType: "json",
        cache: false,
        success: function (data) {

            var trHTML = '';
            $('#paymentsTable tbody').html("");
            $.each($(data), function () {

                trHTML += '<tr id="row_' + this.Id + '"><td>' + this.Id + '</td><td>' + this.Type + '</td><td>' + this.Exp + '</td>' +
                    '<td><input type="button" class="deleteBtn" value="Delete Payment Type" rowId="' + this.Id + '" /> </td>' + '</tr>';
            });

            $('#paymentsTable tbody').append(trHTML);

            deleteBtnEvent();
        },

        error: function (msg) {

            alert(msg.responseText);
        }
    });
}

function deleteBtnEvent() {
    $('.deleteBtn').click(function () {
        var confirmDelete = confirm("Are you sure you want to delete the payment type?");
        if (confirmDelete) {
            var id = $(this).attr("rowId");
            deleteRow(id);
        }

    });

}
function deleteRow(id) {

    $.ajax({

        type: "POST",
        url: "syspaymentHandler.ashx/ProcessRequest?fnc=deleteRow&paymentID=" + id,
        contentType: "application/json; charset=utf-8",
        dataType: "text",

        success: function (data) {

            if (data == "Deleted.") {
                $("#row_" + id).remove();
                alert("Payment Type " + data);
            }
            else {
                alert("Payment Type " + data);
            }

        }, error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }

    });
}

function newPayment(param) {

    $.ajax({

        type: "POST",
        url: "syspaymentHandler.ashx/ProcessRequest?fnc=newPayment" + param,
        contentType: "application/json; charset=utf-8",
        dataType: "text",

        success: function (data) {

            if (data == "Added.") {

               
                getPaymentsTable();
                alert("New Payment Type " + data);

            }
            else {
                alert("New Payment Type " + data);
            }

        }, error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }

    });

}
$(function () {
    var dialog;


    function addPayment() {
        var payment_type = $('#type').val();//current_edit_row_details.name;
        var explanation = $('#exp').val();
        
        if (type == "" ) {
            alert("Fill in payment type.");
        }
        var param = "&payment_type=" + payment_type + "&explanation=" + explanation;
        newPayment(param);
        dialog.dialog("close");
    }

    dialog = $("#create-dialog-form").dialog({
        autoOpen: false,
        height: 400,
        width: 350,
        modal: true,
        buttons: {
            "Create a payment type": addPayment,
            Cancel: function () {
                dialog.dialog("close");
            }
        },

    });

    $("#create").button().on("click", function () {

        dialog.dialog("open");
    });




});