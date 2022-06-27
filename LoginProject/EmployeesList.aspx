<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesList.aspx.cs" Inherits="LoginProject.EmployeesList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employees List</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
    <script src="Scripts/Employee.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <asp:LinkButton ID="btnLogout" class="float-right" runat="server" OnClick="OnLogoutButtonClick">Logout</asp:LinkButton>
            <br />
            <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <asp:Label ID="lblEmpLst" runat="server" Text="Employee List" Font-Size="20pt" Style="text-align: center"></asp:Label>
            </div>

            <br />
            <br />
            <asp:Button ID="btnAddEmployee" class="btn btn-primary float-right" runat="server" OnClick="OnAddEmployeeButtonClick" Text="Add New Employee" />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" class="table table-bordered" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" HorizontalAlign="Center">
                <Columns>
                    <asp:TemplateField HeaderText="Id">
                        <ItemTemplate>
                            <asp:Label ID="lblId" runat="server"
                                Text='<%# Bind("Id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email ID" />
                    <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth"/>
                    <asp:BoundField DataField="Salary" HeaderText="Salary" />
                    <asp:BoundField DataField="DepartmentName" HeaderText="Department Name" />
                    <asp:TemplateField HeaderText="Manage">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEdit" class="btn btn-success" Text="Edit" runat="server" CommandName="Edit" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="lnkDelete" class="btn btn-danger" Text="Delete" runat="server" CommandName="Delete" OnClientClick="Javascript:return alertForDelete();"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <br />

            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
