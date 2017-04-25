using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace LeaveApplicationUppgift.LeaveApplication
{
    [ToolboxItemAttribute(false)]
    public partial class LeaveApplication : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public LeaveApplication()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {

                    SPUser currUser = SPContext.Current.Web.CurrentUser;
                    string strDisplayName = currUser.Name;
                    string[] names = strDisplayName.Split(' ');
                    if (names.Length > 0)
                    {
                        if (string.IsNullOrEmpty(names[0]))
                            txtFornamn.Text = "";
                        else
                            txtFornamn.Text = names[0];
                        if (string.IsNullOrEmpty(names[1]))
                            txtEfternamn.Text = "";
                        else
                            txtEfternamn.Text = names[1];
                    }

                }
                catch (Exception ex)
                {
                    lblMSG.ForeColor = Color.Red;
                    lblMSG.Text = ex.Message;
                }
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        { try {
                SPWeb web = SPContext.Current.Web;
                SPList objSPlist = web.Lists["SemesterLista"];
                SPUser approveruser = null;
                if (ppOwner.AllEntities.Count == 1)
                {
                    approveruser = web.EnsureUser(ppOwner.InitialUserAccounts);
                }
                else
                {
                    lblMSG.ForeColor = Color.Red;
                    lblMSG.Text = "Please select approver";

                }


                LeaveAppInfo leaveInfo = new LeaveAppInfo();
                leaveInfo.LeaveTitle = "Leave Application for " + txtFornamn.Text;
                leaveInfo.FirstName = txtFornamn.Text;
                leaveInfo.LastName = txtEfternamn.Text;
                leaveInfo.StartDate = dtSPStartDate.SelectedDate;
                leaveInfo.EndDate = dtSPEndDate.SelectedDate;
                leaveInfo.PercentageCompletion = 0;
                leaveInfo.status = "Skapad";
                
                if (!CheckIfAlreadyRequestIsThere(objSPlist.Items))
                {
                    //creating new Item
                    SPListItem newItem = objSPlist.AddItem();
                    newItem["Title"] = leaveInfo.LeaveTitle;
                    newItem["Startdatum"] = leaveInfo.StartDate;
                    newItem["Slutdatum"] = leaveInfo.EndDate;
                    newItem["F_x00f6_rnamn"] = leaveInfo.FirstName;
                    newItem["Efternamn"] = leaveInfo.LastName;
                    newItem["Status"] = leaveInfo.status.ToString();
                    newItem["Omfattning"] = leaveInfo.PercentageCompletion;
                    newItem["Ansvarig"] = approveruser;

                    newItem.Update();
                    lblMSG.ForeColor = Color.Green;
                    lblMSG.Text = " Ansökan lämnas in för" + leaveInfo.FirstName;
                }
                else
                {
                    lblMSG.ForeColor = Color.Red;
                    lblMSG.Text = "Ansökan redan finns för den datumintervall för " + leaveInfo.FirstName;
                }
            }
            catch (Exception ex)
            {
                lblMSG.ForeColor = Color.Red;
                lblMSG.Text = ex.Message;
            }

        }

        private bool CheckIfAlreadyRequestIsThere(SPListItemCollection allItems)
        {
            List<LeaveAppInfo> allLeaves = new List<LeaveAppInfo>();
            string strcurrentFirstName = txtFornamn.Text;
            DateTime currStartDate = dtSPStartDate.SelectedDate;
            DateTime currEndDate = dtSPEndDate.SelectedDate;
            foreach (SPListItem item in allItems)
            {
                LeaveAppInfo oLeave = new LeaveAppInfo();
                oLeave.FirstName = item["F_x00f6_rnamn"].ToString();
                if (item["Efternamn"] != null)
                {
                    oLeave.LastName = item["Efternamn"].ToString();
                }
                oLeave.StartDate =DateTime.Parse(item["Startdatum"].ToString());
                oLeave.EndDate = DateTime.Parse(item["Slutdatum"].ToString());
                allLeaves.Add(oLeave);
            }
          

            List<LeaveAppInfo> currentUsersLeaveInfo = allLeaves.Where(x => x.FirstName.Contains(strcurrentFirstName)).ToList<LeaveAppInfo>();
            if (currentUsersLeaveInfo.Count == 0)
            {
                return false;
            }
            else
            {
                
                List<LeaveAppInfo> leavesfromUser=  currentUsersLeaveInfo.Where(y => y.StartDate <= currStartDate && y.EndDate > currEndDate || y.StartDate >= currStartDate && y.StartDate < currEndDate).ToList<LeaveAppInfo>();
                
                if (leavesfromUser.Count == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}
