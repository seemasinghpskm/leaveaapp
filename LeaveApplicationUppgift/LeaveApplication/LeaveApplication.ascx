<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>


<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveApplication.ascx.cs" Inherits="LeaveApplicationUppgift.LeaveApplication.LeaveApplication" %>

<table style="height: 213px; width: 471px">
    <tr>
        <td>Förenamn</td>
        <td>
            <asp:TextBox ID="txtFornamn" runat="server" Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Efternamn</td>

        <td>
            <asp:TextBox ID="txtEfternamn" runat="server" Enabled="False"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Start Datum</td>
        <td>
            <SharePoint:DateTimeControl ID="dtSPStartDate" runat="server" />
        </td>
    </tr>
    <tr>
        <td>Slut Datum</td>
        <td>
            <SharePoint:DateTimeControl ID="dtSPEndDate" runat="server" />
        </td>
    </tr>
    <tr>
        <td>Omfattning</td>
        <td>
            <asp:TextBox ID="txtOmfattning" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Ansvarig
        </td>

        <td>
            <SharePoint:ClientPeoplePicker runat="server" ID="ppOwner" />
        </td>
    </tr>
    <tr>
        <td></td>
        <td><asp:Button runat="server" ID="btnAdd" Text="Skicka Semester" OnClick="btnSubmit_Click" /></td>
    </tr>
</table>
<br />

<asp:Label ID="lblMSG" runat="server"></asp:Label>