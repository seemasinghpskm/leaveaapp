using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web.UI.WebControls;
using System.Drawing;

namespace LeaveApplicationUppgift.ViewNapproveLeavesWP
{
    [ToolboxItemAttribute(false)]
    public partial class ViewNapproveLeavesWP : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public ViewNapproveLeavesWP()
        {
        }
        List<LeaveAppInfo> allLeaves = new List<LeaveAppInfo>();
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!Page.IsPostBack)
                LoadLeaves();
            }
            catch (Exception ex)
            {
                lblMSG.ForeColor = Color.Red;
                lblMSG.Text = ex.Message;

            }
        }

        private void LoadLeaves()
        {
            string strcurrentFirstName = string.Empty;
            string strcurrentLastName = string.Empty;
            SPWeb web = SPContext.Current.Web;
            SPUser currUser = web.CurrentUser;
            //currUser.
            SPList objSPlist = web.Lists["SemesterLista"];
            SPListItemCollection listOfLeaves = objSPlist.Items;

            string strDisplayName = currUser.Name;
            string[] names = strDisplayName.Split(' ');
            if (names.Length > 0)
            {
                if (string.IsNullOrEmpty(names[0]))
                    strcurrentFirstName = "";
                else
                    strcurrentFirstName = names[0];
                if (string.IsNullOrEmpty(names[1]))
                    strcurrentLastName = "";
                else
                    strcurrentLastName = names[1];
            }

            foreach (SPListItem item in listOfLeaves)
            {
                LeaveAppInfo oLeave = new LeaveAppInfo();
                oLeave.LeaveId = item.ID;
                oLeave.LeaveTitle = item["Title"].ToString();
                oLeave.FirstName = item["F_x00f6_rnamn"].ToString();
                if (item["Efternamn"] != null)
                {
                    oLeave.LastName = item["Efternamn"].ToString();
                }
                oLeave.StartDate = DateTime.Parse(item["Startdatum"].ToString());
                oLeave.EndDate = DateTime.Parse(item["Slutdatum"].ToString());
                oLeave.Ansvarig = item["Ansvarig"].ToString();
                oLeave.status = item["Status"].ToString();
                oLeave.PercentageCompletion = int.Parse(item["Omfattning"].ToString());
                allLeaves.Add(oLeave);
            }
            //My List of Leaves
            List<LeaveAppInfo> currentUsersLeaveInfo = allLeaves.Where(x => x.FirstName.Contains(strcurrentFirstName)).ToList<LeaveAppInfo>();
            gvMyLeaves.DataSource = currentUsersLeaveInfo;
            gvMyLeaves.DataBind();

            //Leaves for my approval

            List<LeaveAppInfo> curentUserAnsvarigFor = allLeaves.Where(x => x.Ansvarig.Contains(currUser.Name) && !x.status.Equals("Beviljad")).ToList<LeaveAppInfo>();
            gvMyApprovalGrid.DataSource = curentUserAnsvarigFor;
            gvMyApprovalGrid.DataBind();
        }

        protected void gvMyApprovalGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMyApprovalGrid.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            LoadLeaves();

        }

        protected void gvMyApprovalGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow rowtobeUpdated = gvMyApprovalGrid.Rows[e.RowIndex];
            string selectedVal = ((DropDownList)(rowtobeUpdated.Cells[6].Controls[1])).SelectedValue;
            string strleaveID = rowtobeUpdated.Cells[1].Text;
            SPWeb currweb = SPContext.Current.Web;
            //currweb.Lists[""]
            //            lblMSG.Text =selectedVal+ "-"+strleaveID;
            int selectedItem = int.Parse(strleaveID);
            string strStaus = string.Empty;
            string msg = string.Empty;
            if (selectedVal.Equals("In Progress"))
            {
                strStaus = "Behandlas";
                msg = "Leave is set to in progress status.";
            }
            if (selectedVal.Equals("Approved"))
            {
                strStaus = "Beviljad";
                msg = "Leave is approved.";
            }
            if (selectedVal.Equals("Rejected"))
            {
                strStaus = "Avslagen";
                msg = "Leave is rejected.";
            }
            SPList leaveList = currweb.Lists["Leave Application List"];
            SPListItem leaveReq = leaveList.GetItemById(selectedItem);
            leaveReq["Status"] = strStaus;
            leaveReq["Omfattning"] = 1;
            leaveReq.Update();
            leaveList.Update();
            lblMSG.Text = msg;
            gvMyApprovalGrid.EditIndex = -1;
            LoadLeaves();
        }

        protected void gvMyApprovalGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMyApprovalGrid.EditIndex = -1;
            //Bind data to the GridView control.
            LoadLeaves();

        }
    }
}
