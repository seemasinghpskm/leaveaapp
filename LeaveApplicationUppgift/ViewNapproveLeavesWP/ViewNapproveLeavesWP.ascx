<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewNapproveLeavesWP.ascx.cs" Inherits="LeaveApplicationUppgift.ViewNapproveLeavesWP.ViewNapproveLeavesWP" %>
<h1>My Applied Leaves </h1>
<asp:GridView ID="gvMyLeaves" runat="server" BackColor="White" EmptyDataText="No Leaves Data available" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="225px" Width="800px">
    <AlternatingRowStyle BackColor="#F7F7F7" />
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <SortedAscendingCellStyle BackColor="#F4F4FD" />
    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
    <SortedDescendingCellStyle BackColor="#D8D8F0" />
    <SortedDescendingHeaderStyle BackColor="#3E3277" />
    
</asp:GridView>

<h1>Leaves pending for my approval</h1>
<p>&nbsp;</p>
<asp:GridView ID="gvMyApprovalGrid" OnRowCancelingEdit="gvMyApprovalGrid_RowCancelingEdit"  OnRowEditing="gvMyApprovalGrid_RowEditing" OnRowUpdating="gvMyApprovalGrid_RowUpdating"  runat="server" CellPadding="3" EmptyDataText ="No leave Request Pending" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" Height="200px" Width="800px" CellSpacing="1" GridLines="None">
    <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="leaveID" HeaderText="ID" 
                    InsertVisible="False" ReadOnly="True"  />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" ReadOnly="True"  />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" ReadOnly="True" />
                <asp:BoundField DataField="StartDate" HeaderText="Start Date" ReadOnly="True" />
                <asp:BoundField DataField="EndDate" HeaderText="End Date" ReadOnly="True" />
                <asp:TemplateField HeaderText="Status" >
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" >
                             <asp:ListItem Selected="True" Text="In Progress"></asp:ListItem>
                            <asp:ListItem  Text="Approved"></asp:ListItem>
                            <asp:ListItem Text="Rejected"></asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

   
    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
    <RowStyle ForeColor="Black" BackColor="#DEDFDE" />
    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#594B9C" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#33276A" />

   
</asp:GridView>
<asp:Label ID="lblMSG" runat="server"></asp:Label>