﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveApplicationUppgift.ViewNapproveLeavesWP {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class ViewNapproveLeavesWP {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.GridView gvMyLeaves;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.GridView gvMyApprovalGrid;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Label lblMSG;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(ViewNapproveLeavesWP target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control2(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(247, 247, 247)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control3(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(181, 199, 222)));
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(74, 60, 140)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control4(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(74, 60, 140)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(247, 247, 247)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control5(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(231, 231, 255)));
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(74, 60, 140)));
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Right;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control6(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(231, 231, 255)));
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(74, 60, 140)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control7(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(115, 138, 156)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(247, 247, 247)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control8(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(244, 244, 253)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control9(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(90, 76, 157)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control10(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(216, 216, 240)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control11(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(62, 50, 119)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.GridView @__BuildControlgvMyLeaves() {
            global::System.Web.UI.WebControls.GridView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.GridView();
            this.gvMyLeaves = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "gvMyLeaves";
            @__ctrl.BackColor = global::System.Drawing.Color.White;
            @__ctrl.EmptyDataText = "No Leaves Data available";
            @__ctrl.BorderColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(231, 231, 255)));
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.None;
            @__ctrl.BorderWidth = new System.Web.UI.WebControls.Unit(1D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.CellPadding = 3;
            @__ctrl.GridLines = global::System.Web.UI.WebControls.GridLines.Horizontal;
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(225D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(800D, global::System.Web.UI.WebControls.UnitType.Pixel);
            this.@__BuildControl__control2(@__ctrl.AlternatingRowStyle);
            this.@__BuildControl__control3(@__ctrl.FooterStyle);
            this.@__BuildControl__control4(@__ctrl.HeaderStyle);
            this.@__BuildControl__control5(@__ctrl.PagerStyle);
            this.@__BuildControl__control6(@__ctrl.RowStyle);
            this.@__BuildControl__control7(@__ctrl.SelectedRowStyle);
            this.@__BuildControl__control8(@__ctrl.SortedAscendingCellStyle);
            this.@__BuildControl__control9(@__ctrl.SortedAscendingHeaderStyle);
            this.@__BuildControl__control10(@__ctrl.SortedDescendingCellStyle);
            this.@__BuildControl__control11(@__ctrl.SortedDescendingHeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.CommandField @__BuildControl__control13() {
            global::System.Web.UI.WebControls.CommandField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.CommandField();
            @__ctrl.ShowEditButton = true;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control14() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "leaveID";
            @__ctrl.HeaderText = "ID";
            @__ctrl.InsertVisible = false;
            @__ctrl.ReadOnly = true;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control15() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "LastName";
            @__ctrl.HeaderText = "Last Name";
            @__ctrl.ReadOnly = true;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control16() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "FirstName";
            @__ctrl.HeaderText = "First Name";
            @__ctrl.ReadOnly = true;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control17() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "StartDate";
            @__ctrl.HeaderText = "Start Date";
            @__ctrl.ReadOnly = true;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control18() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "EndDate";
            @__ctrl.HeaderText = "End Date";
            @__ctrl.ReadOnly = true;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control23() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Selected = true;
            @__ctrl.Text = "In Progress";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control24() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Approved";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control25() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Rejected";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control22(System.Web.UI.WebControls.ListItemCollection @__ctrl) {
            global::System.Web.UI.WebControls.ListItem @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control23();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.ListItem @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control24();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.ListItem @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control25();
            @__ctrl.Add(@__ctrl3);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControl__control21() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "DropDownList1";
            this.@__BuildControl__control22(@__ctrl.Items);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control20(System.Web.UI.Control @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                        "));
            global::System.Web.UI.WebControls.DropDownList @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control21();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    "));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControl__control27() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "Label1";
            @__ctrl.DataBinding += new System.EventHandler(this.@__DataBinding__control27);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        public void @__DataBinding__control27(object sender, System.EventArgs e) {
            System.Web.UI.WebControls.Label dataBindingExpressionBuilderTarget;
            System.Web.UI.IDataItemContainer Container;
            dataBindingExpressionBuilderTarget = ((System.Web.UI.WebControls.Label)(sender));
            Container = ((System.Web.UI.IDataItemContainer)(dataBindingExpressionBuilderTarget.BindingContainer));
            if ((this.Page.GetDataItem() != null)) {
                dataBindingExpressionBuilderTarget.Text = global::System.Convert.ToString(this.Eval("Status"), global::System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control26(System.Web.UI.Control @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control27();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    "));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        public System.Collections.Specialized.IOrderedDictionary @__ExtractValues__control26(System.Web.UI.Control @__container) {
            System.Collections.Specialized.OrderedDictionary @__table;
            System.Web.UI.WebControls.Label Label1;
            Label1 = ((System.Web.UI.WebControls.Label)(@__container.FindControl("Label1")));
            @__table = new System.Collections.Specialized.OrderedDictionary();
            if ((Label1 != null)) {
                @__table["Status"] = Label1.Text;
            }
            return @__table;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.TemplateField @__BuildControl__control19() {
            global::System.Web.UI.WebControls.TemplateField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TemplateField();
            @__ctrl.EditItemTemplate = new System.Web.UI.CompiledBindableTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControl__control20), null);
            @__ctrl.ItemTemplate = new System.Web.UI.CompiledBindableTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControl__control26), new System.Web.UI.ExtractTemplateValuesMethod(this.@__ExtractValues__control26));
            @__ctrl.HeaderText = "Status";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control12(System.Web.UI.WebControls.DataControlFieldCollection @__ctrl) {
            global::System.Web.UI.WebControls.CommandField @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control13();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.BoundField @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control14();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.BoundField @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control15();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.WebControls.BoundField @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control16();
            @__ctrl.Add(@__ctrl4);
            global::System.Web.UI.WebControls.BoundField @__ctrl5;
            @__ctrl5 = this.@__BuildControl__control17();
            @__ctrl.Add(@__ctrl5);
            global::System.Web.UI.WebControls.BoundField @__ctrl6;
            @__ctrl6 = this.@__BuildControl__control18();
            @__ctrl.Add(@__ctrl6);
            global::System.Web.UI.WebControls.TemplateField @__ctrl7;
            @__ctrl7 = this.@__BuildControl__control19();
            @__ctrl.Add(@__ctrl7);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control28(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(198, 195, 198)));
            @__ctrl.ForeColor = global::System.Drawing.Color.Black;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control29(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(74, 60, 140)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(231, 231, 255)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control30(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(198, 195, 198)));
            @__ctrl.ForeColor = global::System.Drawing.Color.Black;
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Right;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control31(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.ForeColor = global::System.Drawing.Color.Black;
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(222, 223, 222)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control32(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(148, 113, 222)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = global::System.Drawing.Color.White;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control33(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(241, 241, 241)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control34(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(89, 75, 156)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control35(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(202, 201, 201)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control36(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(51, 39, 106)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.GridView @__BuildControlgvMyApprovalGrid() {
            global::System.Web.UI.WebControls.GridView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.GridView();
            this.gvMyApprovalGrid = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "gvMyApprovalGrid";
            @__ctrl.CellPadding = 3;
            @__ctrl.EmptyDataText = "No leave Request Pending";
            @__ctrl.AutoGenerateColumns = false;
            @__ctrl.BackColor = global::System.Drawing.Color.White;
            @__ctrl.BorderColor = global::System.Drawing.Color.White;
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.Ridge;
            @__ctrl.BorderWidth = new System.Web.UI.WebControls.Unit(2D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(200D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(800D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.CellSpacing = 1;
            @__ctrl.GridLines = global::System.Web.UI.WebControls.GridLines.None;
            this.@__BuildControl__control12(@__ctrl.Columns);
            this.@__BuildControl__control28(@__ctrl.FooterStyle);
            this.@__BuildControl__control29(@__ctrl.HeaderStyle);
            this.@__BuildControl__control30(@__ctrl.PagerStyle);
            this.@__BuildControl__control31(@__ctrl.RowStyle);
            this.@__BuildControl__control32(@__ctrl.SelectedRowStyle);
            this.@__BuildControl__control33(@__ctrl.SortedAscendingCellStyle);
            this.@__BuildControl__control34(@__ctrl.SortedAscendingHeaderStyle);
            this.@__BuildControl__control35(@__ctrl.SortedDescendingCellStyle);
            this.@__BuildControl__control36(@__ctrl.SortedDescendingHeaderStyle);
            @__ctrl.RowCancelingEdit -= new System.Web.UI.WebControls.GridViewCancelEditEventHandler(this.gvMyApprovalGrid_RowCancelingEdit);
            @__ctrl.RowCancelingEdit += new System.Web.UI.WebControls.GridViewCancelEditEventHandler(this.gvMyApprovalGrid_RowCancelingEdit);
            @__ctrl.RowEditing -= new System.Web.UI.WebControls.GridViewEditEventHandler(this.gvMyApprovalGrid_RowEditing);
            @__ctrl.RowEditing += new System.Web.UI.WebControls.GridViewEditEventHandler(this.gvMyApprovalGrid_RowEditing);
            @__ctrl.RowUpdating -= new System.Web.UI.WebControls.GridViewUpdateEventHandler(this.gvMyApprovalGrid_RowUpdating);
            @__ctrl.RowUpdating += new System.Web.UI.WebControls.GridViewUpdateEventHandler(this.gvMyApprovalGrid_RowUpdating);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControllblMSG() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblMSG = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblMSG";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::LeaveApplicationUppgift.ViewNapproveLeavesWP.ViewNapproveLeavesWP @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<h1>My Applied Leaves</h1>\r\n"));
            global::System.Web.UI.WebControls.GridView @__ctrl1;
            @__ctrl1 = this.@__BuildControlgvMyLeaves();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n<h1>Leaves pending for my approval</h1>\r\n<p>&nbsp;</p>\r\n"));
            global::System.Web.UI.WebControls.GridView @__ctrl2;
            @__ctrl2 = this.@__BuildControlgvMyApprovalGrid();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            global::System.Web.UI.WebControls.Label @__ctrl3;
            @__ctrl3 = this.@__BuildControllblMSG();
            @__parser.AddParsedSubObject(@__ctrl3);
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
