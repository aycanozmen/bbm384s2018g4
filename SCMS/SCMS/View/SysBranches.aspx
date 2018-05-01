<%@ Page Title="" Language="C#" MasterPageFile="~/View/temp1sys.Master" AutoEventWireup="true" CodeBehind="SysBranches.aspx.cs" Inherits="SCMS.View.SysBranches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  
    <link href="css/createForm.css" rel="stylesheet" />
    <link href="css/table.css" rel="stylesheet" />
   
    <script src="scripts/jquery.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>

  
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="scripts/appScript/sysbranches.js"></script>
 
    <div class="row">
        <div class="panel-heading">
                <h3>
                    <a class="editor_create">Branches</a>
                    <i class="fa fa-table"></i>
                </h3>
        </div>
    </div>
    <input type="button" value="Get Branch"  id="getBranchBtn" />

    <div>     
        <table id="branchTable" class="display" cellspacing="0" width="100%">

        <thead>
            <tr> 
                <th>Id</th>
                <th>Branch</th>
                <th>City</th>
                <th>District</th>
                <th>Street</th>
                <th>Phone</th>
                <th>Delete Button</th>
                 <th>Edit Button</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
    </div>
    <input type="button" value="Create New Branch"  id="create" />    
    <div id="create-dialog-form" title="Create new branch" style="display:none;">
  <p class="validateTips">All form fields are required.</p>
  
  <form>
    <fieldset>
      
      <label for="name">Branch</label>
      <input type="text" name="branch" id="name"  class="text ui-widget-content ui-corner-all">
      <label for="city">City</label>
      <input type="text" name="city" id="city" class="text ui-widget-content ui-corner-all">
      <label for="district">District</label>
      <input type="text" name="district" id="district" class="text ui-widget-content ui-corner-all">
      <label for="street">Street</label>
      <input type="text" name="street" id="street" class="text ui-widget-content ui-corner-all">
      <label for="phone">Phone</label>
      <input type="text" name="phone" id="phone" class="text ui-widget-content ui-corner-all">
 
      <!-- Allow form submission with keyboard without duplicating the dialog button -->
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
    </fieldset>
  </form>
      
</div>
       <!--Edit user modal-->          
<div id="edit-dialog-form" title="Edit branch details" style="display:none;">
  <p class="validateTips">All form fields are required.</p>
 
  <form>
    
    <fieldset>
     
      <label for="edit_name">Branch</label>
      <input type="text" name="branch" id="edit_name"  class="text ui-widget-content ui-corner-all">
      <label for="edit_city">City</label>
      <input type="text" name="city" id="edit_city" class="text ui-widget-content ui-corner-all">
      <label for="edit_district">District</label>
      <input type="text" name="district" id="edit_district" class="text ui-widget-content ui-corner-all">
      <label for="edit_street">Street</label>
      <input type="text" name="street" id="edit_street" class="text ui-widget-content ui-corner-all">
      <label for="edit_phone">Phone</label>
      <input type="text" name="phone" id="edit_phone" class="text ui-widget-content ui-corner-all">
 
      <!-- Allow form submission with keyboard without duplicating the dialog button -->
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
    </fieldset>
      
  </form>
</div >        


</asp:Content>

