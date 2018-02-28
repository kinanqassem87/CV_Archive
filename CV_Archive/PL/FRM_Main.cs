using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CV_Archive.PL
{
    public partial class FRM_Main : Form
    {
        public static string FullName = "";
        public static string UserName = "";
        public static string U_Password = "";
        public static string u_id = "";
        public static string Per = "";
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void tsSignIn_Click(object sender, EventArgs e)
        {
            FRM_SignIN a = new FRM_SignIN();
            a.ShowDialog();
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            if (Per.Equals("admin"))
            {
                 tsSignOut.Enabled = tsChangePassword.Enabled = tsManagement.Enabled=tsDocSearch.Enabled=tsBackup.Enabled= true;
                tsSignIn.Enabled = false;
            }
            if (Per.Equals("user"))
            {

                tsSignOut.Enabled = tsChangePassword.Enabled = tsDocSearch.Enabled = true;
                tsSignIn.Enabled = false;
            }
        }

        private void tsSignOut_Click(object sender, EventArgs e)
        {
            Per = "out";
            tsSignOut.Enabled = tsChangePassword.Enabled = tsManagement.Enabled = tsDocSearch.Enabled =tsBackup.Enabled= false;
            tsSignIn.Enabled = true;
            FRM_SignIN s = new FRM_SignIN();
            s.ShowDialog();
        }

        private void tsChangePassword_Click(object sender, EventArgs e)
        {
            FRM_ChangPassword a = new FRM_ChangPassword();
            a.ShowDialog();
        }

        private void tsAddDoc_Click(object sender, EventArgs e)
        {
            Frm_AddNewDoc a = new Frm_AddNewDoc();
            a.ShowDialog();
        }

        private void tsAbout_Click(object sender, EventArgs e)
        {
            Frm_About a = new Frm_About();
            a.ShowDialog();
        }

        private void tsManagDoc_Click(object sender, EventArgs e)
        {
            Frm_DocManagement a = new Frm_DocManagement();
            a.ShowDialog();
        }

        private void tsDocSearch_Click(object sender, EventArgs e)
        {
            Frm_DisplayAllDoc a = new Frm_DisplayAllDoc();
            a.ShowDialog();
        }

        private void tsBackup_Click(object sender, EventArgs e)
        {
            Frm_BackupData a = new Frm_BackupData();
            a.ShowDialog();
        }
    }
}
