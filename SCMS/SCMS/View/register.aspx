<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="SCMS.View.register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
  <style type="text/css">
      .style1
      {
          width: 400px;
          text-align: center;
          height: 50px;
      }
   
      .style2
      {
  
          color: #0066CC;
          text-align: center;
      }
      .style7
      {
          height: 45px;
          color: #0066CC;
          text-align: left;
      }
      .style8
      {   
          height: 45px;
          color: #0066CC;
          text-align: center;
      }
      .style9
      {
          height: 45px;
          color: #0066CC;
          width: 256px;
          text-align: center;
      }
      .style10
      {
          width: 237px;
          text-align: center;
          height: 26px;
      }
      .style11
      {
          width: 225px;
          text-align: center;
          height: 26px;
      }
      .style12
      {
          color: #0066CC;
          width: 256px;
          text-align: center;
      }
      .style13
      {
          color: #0066CC;
          text-align: left;
      }
      .style14
      {
          width: 436px;
          text-align: center;
          height: 30px;
      }
      .style15
      {
          height: 30px;
          color: #0066CC;
          width: 256px;
          text-align: center;
      }
      .style16
      {
          height: 30px;
          color: #0066CC;
          text-align: left;
      }
      .style17
      {
          width: 436px;
          text-align: center;
          height: 38px;
      }
      .style18
      {
          width: 256px;
          color: #0066CC;
          text-align: center;
          height: 38px;
          margin-top:60px;
          margin-left:540px;
      }
  </style>
</head>
<body>
  <form id="Form1" runat="server">        
      <div class="clear">
          <span   
              <br>

              <br />
                 <h3 class="style18"> <strong>New Member Sign Up Here</strong></h3>
          </span>
          <table style="width:100%;">
              <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style15">
                      Name</td>
                  <td class="style16">
                      <asp:TextBox ID="Name" runat="server" MaxLength="15"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="re_name" runat="server"
                           ControlToValidate="Name" Display="Dynamic"
                           ErrorMessage="Please enter the name" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style15">
                      Surname</td>
                  <td class="style16">
                      <asp:TextBox ID="Surname" runat="server" MaxLength="15"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="re_surname" runat="server"
                           ControlToValidate="Surname" Display="Dynamic"
                           ErrorMessage="Please enter the surname" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style15">
                      Username</td>
                  <td class="style16">
                      <asp:TextBox ID="Uname" runat="server" MaxLength="15"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="re_user" runat="server"
                           ControlToValidate="Uname" Display="Dynamic"
                           ErrorMessage="Please enter the User Name" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                  </td>
              </tr>
         
              <tr>
                   <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style9">
                      Password</td>
                  <td class="style7">
                      <asp:TextBox ID="Password" runat="server" MaxLength="8" TextMode="Password"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="re_pass" runat="server"
                           ControlToValidate="Password" Display="Dynamic"
                           ErrorMessage="Please Enter the Password" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style9">
                      Confirm Password</td>
                  <td class="style7">
                      <asp:TextBox ID="Cpassword" runat="server" MaxLength="8" TextMode="Password"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="re_cpass" runat="server"
                           ControlToValidate="Cpassword" Display="Dynamic"
                           ErrorMessage="Please Enter the Confirm Password" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                      <br />
                      <asp:CompareValidator ID="re_passCompare" runat="server"
                           ControlToCompare="Password" ControlToValidate="Cpassword" Display="Dynamic"
                           ErrorMessage="Password Mismatch" ForeColor="Red" ValidationGroup="signUp"></asp:CompareValidator>
                  </td>
              </tr>

              <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style15">
                      Phone</td>
                  <td class="style16">
                      <asp:TextBox ID="Phone" runat="server" MaxLength="15"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="re_phone" runat="server"
                           ControlToValidate="Phone" Display="Dynamic"
                           ErrorMessage="Please enter the phone" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                  </td>
              </tr>
               <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style12" >
                      Gender</td>
                  <td class="style13">
                      <asp:RadioButtonList ID="Gender" runat="server" RepeatDirection="Horizontal">
                          <asp:ListItem>Male</asp:ListItem>
                          <asp:ListItem>Female</asp:ListItem>
                      </asp:RadioButtonList>
                      <asp:RequiredFieldValidator ID="re_gender" runat="server"
                           ControlToValidate="Gender" Display="Dynamic"
                           ErrorMessage="Please Select the Gender" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style15">
                      Birthdate</td>
                  <td class="style16">
                      <asp:TextBox ID="BirthDate" runat="server" MaxLength="20"></asp:TextBox>
                      <br />
                      <asp:RequiredFieldValidator ID="re_birthdate" runat="server"
                           ControlToValidate="BirthDate" Display="Dynamic"
                           ErrorMessage="Please enter the birthdate" ForeColor="Red"
                           ValidationGroup="signUp"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="re_validdate" runat="server"
                           ControlToValidate="BirthDate" Display="Dynamic"
                           ErrorMessage="Enter the Valid Date (mm-dd-yyyy or mm/dd/yyyy)" ForeColor="Red"
                           ValidationExpression="^([0-9]{1,2})[/-]+([0-9]{1,2})[/-]+([0-9]{2}|[0-9]{4})$"
                           ValidationGroup="signUp"></asp:RegularExpressionValidator>
                  </td>
              </tr>
              
              <tr>
                  <td class="style1">
                      &nbsp;</td>
                  <td class="style8" colspan="2">
                      <button class="style8" colspan="2" id="loginBtn" onserverclick="RegisterBtnClick" runat="server">
							Register
						</button>
                  </td>
              </tr>
              <tr>
                  <td class="style1" colspan="2">
                      &nbsp;</td>
                  <td class="style18" >
          <asp:Label runat="server" ID="message"></asp:Label>
                  </td>
              </tr>
          </table>
          
      </div>
 
  </form>
</body>
</html>
