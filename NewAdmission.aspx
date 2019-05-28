<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewAdmission.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style14 {
        width: 184px;
            height: 31px;
        }
    .auto-style15 {
            margin-left: 80px;
            height: 31px;
        }
        .auto-style19 {
        height: 26px;
    }
    .auto-style20 {
        height: 21px;
    }
    .auto-style21 {
        width: 922px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td class="auto-style14">Enter School Name</td>
        <td class="auto-style15" colspan="2">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style19">Address</td>
        <td colspan="2" class="auto-style19">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>StateName</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" CssClass="mb-0">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>City</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Affiliated Board</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style20" colspan="3">Pin Code<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Contact Number</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Date Of Resignation</td>
        <td colspan="2">
            <asp:TextBox ID="TextBox8" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Zonal</td>
        <td colspan="2">
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align:center" class="auto-style21">
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </td>
        <td style="text-align:center">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
