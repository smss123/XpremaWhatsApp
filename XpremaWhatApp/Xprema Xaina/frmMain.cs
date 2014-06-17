using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xprema_Xaina.WhatsAppIDSender;
using Xprema_Xaina.SendPanal;
using Xprema_Xaina.PhoneNumber;
using Xprema_Xaina.Groups;
using Xprema_Xaina.Filter;
namespace Xprema_Xaina
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowForm(Form frm)
        {
            frm.ShowDialog();
        }
        private void addIDSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ShowForm(new frmWhatsAppIDSenderAdd());

        }

        private void registerIDSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
              ShowForm(new frmWhatsAppIDSenderRegister());
        }

        private void deleteIDSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
               ShowForm(new frmWhatsAppIDSenderDelete());
        }

        private void editIDSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmWhatsAppIDSenderEdit());
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmGroupsAdd());
        }

        private void editGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmGroupsEdit());
        }

        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmGroupsDelete());
        }

        private void addPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPhoneNumberAdd());
        }

        private void editPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPhoneNumberEdit());
        }

        private void deletePhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPhoneNumberDelete());
        }

        private void sendPanalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSendPanal());
        }

        private void reviewIDSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmReviewIDSender());
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Restart Now?","System Restart",MessageBoxButtons.YesNo , MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes )
            {
                Application.Restart();
            }
            
        }

        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Turn Off Now?", "System Turn Off", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
