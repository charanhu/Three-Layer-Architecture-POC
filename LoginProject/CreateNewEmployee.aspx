<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateNewEmployee.aspx.cs" EnableViewState="false" Inherits="LoginProject.CreateNewEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Employee</title>


    <script src="Scripts/Employee.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css"/>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
    <!-- Bootstrap -->
    <!-- Bootstrap DatePicker -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/css/bootstrap-datepicker.css" type="text/css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.6.4/js/bootstrap-datepicker.js" type="text/javascript"></script>
    <!-- Bootstrap DatePicker -->
    <script type="text/javascript">
        $(function () {
            $('[id*=txtDate]').datepicker({
                changeMonth: true,
                changeYear: true,
                format: "dd-mm-yyyy",
                language: "tr",
                orientation: "bottom left",
                endDate: "today-15"

            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server" class="form-inline">
        <div class="container">
            <br />
            <asp:Label ID="lblHead" runat="server" Text="Create New Employee" Font-Size="20pt" Style="text-align: center"></asp:Label>

            <asp:Button ID="btnBack" class="btn btn-info float-right" runat="server" OnClick="OnBackButtonClick" Text="Back" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblCheckDup" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" ID="txtFirstName" runat="server" MaxLength="30"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;

            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" ID="txtLastName" runat="server" MaxLength="30"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;

            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" ID="txtEmail" runat="server" MaxLength="50"></asp:TextBox>
            

            <br />
            <br />
            <br />

            <asp:Label ID="lblDepartment" runat="server" Text="Department"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="txtDepartment" runat="server" class="form-control" Width="17%">
                <asp:ListItem Text="--select--" Value="0"></asp:ListItem>
                <asp:ListItem Text="Healthcare" Value="1"></asp:ListItem>
                <asp:ListItem Text="HMS" Value="2"></asp:ListItem>
                <asp:ListItem Text="Insurence" Value="3"></asp:ListItem>
                <asp:ListItem Text="BFS" Value="4"></asp:ListItem>
                <asp:ListItem Text="IT" Value="5"></asp:ListItem>
                <asp:ListItem Text="HR" Value="6"></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;

            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" ID="txtDate" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;

            <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>&nbsp;
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" ID="txtSalary" runat="server" MaxLength="12"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblAddress1" runat="server" Text="Address 1"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" ID="txtAddress1" runat="server" Width="80%" MaxLength="100"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblAddress2" runat="server" Text="Address 2"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" ID="txtAddress2" runat="server" Width="80%" MaxLength="100"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnSave" class="btn btn-primary" runat="server" Text="Save" OnClientClick="Javascript: return AddEmployeeValidation();" OnClick="OnSaveButtonClick" Width="150px" />

            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReset" class="btn btn-danger" runat="server" OnClick="OnResetButtonClick" Text="Reset" />
            &nbsp;&nbsp;
           

           
            
            &nbsp;


            
            <asp:HiddenField ID="hdEmpId" runat="server" Value="0" />


            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
