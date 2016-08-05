using System.Windows.Forms;
using DeadSpace2SaveEditor.Code;

namespace DeadSpace2SaveEditor
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            lblVersion.Text = lblVersion.Text.Replace("{ver}", AppHelper.GetVersionStr());
        }

        private void llEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:smile.voronezh@gmail.com?subject=Dead Space 2 Save Editor");
        }

        private void llGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/VakhtinAndrey");
        }
    }
}
