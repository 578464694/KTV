using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace KTV_stand_online_vsrsion
{
    public partial class FormChoose : Form
    {
        public FormChoose()
        {
            InitializeComponent();
        }

        private void btnUserLog_Click(object sender, EventArgs e)
        {
            FormMain.gLogInfo = 0;
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void btnMsLog_Click(object sender, EventArgs e)
        {
            FormMsLog log = new FormMsLog();
            log.Show();
        }

    }
}
