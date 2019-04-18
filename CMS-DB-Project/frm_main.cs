﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_DB_Project
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void manageVolunteerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manage_volunteer volunteerForm = new frm_manage_volunteer();
            volunteerForm.MdiParent = this;
            volunteerForm.Show();
        }

        private void employeesWorksForBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_employeesworksforbranch empForBranch = new frm_employeesworksforbranch();
            empForBranch.MdiParent = this;
            empForBranch.Show();
        }
    }
}
