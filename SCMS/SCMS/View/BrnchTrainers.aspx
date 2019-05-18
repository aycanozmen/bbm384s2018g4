<%@ Page Title="" Language="C#" MasterPageFile="~/View/temp2sys.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="BrnchTrainers.aspx.cs" Inherits="SCMS.View.BrnchTrainers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  
    <link href="css/createForm.css" rel="stylesheet" />
    <link href="css/table.css" rel="stylesheet" />
   
    <script src="scripts/jquery.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>

  
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="scripts/appScript/trainers.js"></script>
 
    <div class="row">
        <div class="panel-heading">
                <h3>
                    <a class="editor_create">Trainers</a>
                    <i class="fa fa-table"></i>
                </h3>
        </div>
    </div>
    <input type="button" value="Get Trainers"  id="getManagerBtn" />

    <div>     
         <table id="managerTable" class="display" cellspacing="0" width="100%">

        <thead>
            <tr> 
                <th>Name</th>
                <th>Surname</th>
                <th>Username</th>
                <th>Phone</th>
                <th>Gender</th>
                <th>Birthdate</th>
                <th>Domain</th>
                <th>Delete Button</th>
                 <th>Edit Button</th>
            </tr>
        </thead>
        <tbody>

        </tbody>
    </table>
    </div>
    <input type="button" value="Add New Trainer"  id="create" />    
     <div id="create-dialog-form" title="Add new trainer" style="display:none;">
  <p class="validateTips">Fill in the form fields are required.</p>
  
  <form>
    <fieldset>
      <label for="name">Name</label>
      <input type="text" name="name" id="name"  class="text ui-widget-content ui-corner-all">
      <label for="surname">Surname</label>
      <input type="text" name="surname" id="surname"  class="text ui-widget-content ui-corner-all">
      <label for="username">Username</label>
      <input type="text" name="username" id="username" class="text ui-widget-content ui-corner-all">
      <label for="password">Password</label>
      <input type="text" name="password" id="password" class="text ui-widget-content ui-corner-all">
      <label for="phone">Phone</label>
      <input type="text" name="phone" id="phone" class="text ui-widget-content ui-corner-all">
        
      <label for="gender">Gender</label>
      <input type="text" name="gender" id="gender" class="text ui-widget-content ui-corner-all">
      <label for="birthdate">Birthdate</label>
      <input type="text" name="birthdate" id="birthdate" class="text ui-widget-content ui-corner-all">
      <label for="domain">Domain</label>
      <input type="text" name="domain" id="domain" class="text ui-widget-content ui-corner-all">

 
      <!-- Allow form submission with keyboard without duplicating the dialog button -->
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
    </fieldset>
  </form>
      
</div>
       <!--Edit user modal-->          
<div id="edit-dialog-form" title="Edit managers details" style="display:none;">
  <p class="validateTips">Fill in the form fields are required.</p>
 
  <form>
     <fieldset>
      <label for="name">Name</label>
      <input type="text" name="name" id="edit_name"  class="text ui-widget-content ui-corner-all">
      <label for="surname">Surname</label>
      <input type="text" name="surname" id="edit_surname"  class="text ui-widget-content ui-corner-all">
      <label for="username">Username</label>
      <input type="text" name="username" id="edit_username" class="text ui-widget-content ui-corner-all">
      <label for="phone">Phone</label>
      <input type="text" name="phone" id="edit_phone" class="text ui-widget-content ui-corner-all">
      <label for="birthdate">Birthdate</label>
      <input type="text" name="birthdate" id="edit_birthdate" class="text ui-widget-content ui-corner-all">
 
      <!-- Allow form submission with keyboard without duplicating the dialog button -->
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
    </fieldset>
  </form>
</div >        

</asp:Content>
