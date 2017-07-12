<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="students_Registration.aspx.cs" Inherits="certificate_issuing.students_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 91%;
        }
        .auto-style2 {
            width: 134px;
        }
        .auto-style3 {
            width: 190px;
        }
        .auto-style4 {
            width: 176px;
        }
        .auto-style5 {
            width: 191px;
        }
        .auto-style6 {
            width: 164px;
        }
        .auto-style7 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="left" class="auto-style1">
            <tr>
                <td class="auto-style7" colspan="6">STUDENTS REGISTRATION</td>
            </tr>
            <tr>
                <td class="auto-style2">Student ID:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">Admission No:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">Joining Date:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">First Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox6" runat="server" Width="156px"></asp:TextBox>
                </td>
                <td class="auto-style4">Sir Name:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox5" runat="server" Width="148px"></asp:TextBox>
                </td>
                <td class="auto-style6">Other Names:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="141px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">D.O.B:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">Course:</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">Year Of Study:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="16px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Guardian Full Names:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox12" runat="server" Width="155px"></asp:TextBox>
                </td>
                <td class="auto-style4">Guardian Contact Number:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox11" runat="server" Width="178px"></asp:TextBox>
                </td>
                <td class="auto-style6">Guardian Email Address:</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="6" style="text-align: center">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" />
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
