<%@ Page Title="" Language="C#" MasterPageFile="~/View/temp1sys.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="SysCourses.aspx.cs" Inherits="SCMS.View.SysCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  
    <link href="css/createForm.css" rel="stylesheet" />
    <link href="css/table.css" rel="stylesheet" />
   
    <script src="scripts/jquery.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>

  
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="scripts/appScript/syscourses.js"></script>
 
    <div class="row">
        <div class="panel-heading">
                <h3>
                    <a class="editor_create">Courses</a>
                    <i class="fa fa-table"></i>
                </h3>
        </div>
    </div>
    <input type="button" value="Get Course"  id="getCourseBtn" />

    <div>     
        <table id="courseTable" class="display" cellspacing="0" width="100%">

        <thead>
            <tr> 
                <th>Course</th>
                <th>Quota</th>
                <th>Period(Week)</th>
                <th>Duration of Training(Minute)</th>
                <th>Level</th>
                <th>Price</th>
                <th>Equipment</th>
                <th>Information</th>
                <th>Delete Button</th>
                 <th>Edit Button</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
    </div>
    <input type="button" value="Create New Course"  id="create" />    
    <div id="create-dialog-form" title="Create new course" style="display:none;">
  <p class="validateTips">All form fields are required.</p>
  
  <form>
    <fieldset>
      <label for="course">Course</label>
      <input type="text" name="course" id="course"  class="text ui-widget-content ui-corner-all">
      <label for="quota">Quota</label>
      <input type="number" name="quota" id="quota"  class="text ui-widget-content ui-corner-all">
      <label for="period">Period(Week)</label>
      <input type="number" name="period" id="period" class="text ui-widget-content ui-corner-all">
      <label for="duration">Duration of Training(Minute)</label>
      <input type="number" name="duration" id="duration" class="text ui-widget-content ui-corner-all">
      <label for="level">Level</label>
      <input type="number" name="level" id="level" class="text ui-widget-content ui-corner-all">
      <label for="price">Price</label>
      <input type="number" name="price" id="price" class="text ui-widget-content ui-corner-all">
      <label for="equipment">Equipment</label>
      <input type="text" name="equipment" id="equipment" class="text ui-widget-content ui-corner-all">
      <label for="information">Information</label>
      <input type="text" name="information" id="information" class="text ui-widget-content ui-corner-all">
     
 
      <!-- Allow form submission with keyboard without duplicating the dialog button -->
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
    </fieldset>
  </form>
      
</div>
       <!--Edit user modal-->          
<div id="edit-dialog-form" title="Edit course details" style="display:none;">
  <p class="validateTips">All form fields are required.</p>
 
  <form>
     <fieldset>
      <label for="edit_course">Course</label>
      <input type="text" name="course" id="edit_course"  class="text ui-widget-content ui-corner-all">
      <label for="edit_quota">Quota</label>
      <input type="number" name="quota" id="edit_quota"  class="text ui-widget-content ui-corner-all">
      <label for="edit_period">Period(Week)</label>
      <input type="number" name="period" id="edit_period" class="text ui-widget-content ui-corner-all">
      <label for="edit_duration">Duration of Training(Minute)</label>
      <input type="number" name="duration" id="edit_duration" class="text ui-widget-content ui-corner-all">
      <label for="edit_level">Level</label>
      <input type="number" name="level" id="edit_level" class="text ui-widget-content ui-corner-all">
      <label for="edit_price">Price</label>
      <input type="number" name="price" id="edit_price" class="text ui-widget-content ui-corner-all">
      <label for="edit_equipment">Equipment</label>
      <input type="text" name="equipment" id="edit_equipment" class="text ui-widget-content ui-corner-all">
      <label for="edit_information">Information</label>
      <input type="text" name="information" id="edit_information" class="text ui-widget-content ui-corner-all">
     
 
      <!-- Allow form submission with keyboard without duplicating the dialog button -->
      <input type="submit" tabindex="-1" style="position:absolute; top:-1000px">
    </fieldset>
  </form>
</div >        



</asp:Content>
