using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentMonLauncher
{
    public partial class frm_Options : Form
    {
        public frm_Options()
        {
            InitializeComponent();
        }

        private void frm_Options_Load(object sender, EventArgs e)
        {
            foreach (char keyCode in Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c).ToList())
            {
                cmb_KeyValue.Items.Add(keyCode);
            }
            foreach (string FunctionKey in Enumerable.Range(1, 12).Select(s => "F" + s.ToString()).ToList())
            {
                cmb_KeyValue.Items.Add(FunctionKey);
            }

            PopulateHotkey();
        }

        private void PopulateHotkey()
        {

            if (String.IsNullOrEmpty(Properties.Settings.Default.Hotkey))
            {
                return;
            }

            foreach (string token in Properties.Settings.Default.Hotkey.Split('+'))
            {
                switch (token)
                {
                    case "CTRL":
                        chk_Ctrl.Checked = true;
                        break;
                    case "ALT":
                        chk_Alt.Checked = true;
                        break;
                    case "WIN":
                        chk_Win.Checked = true;
                        break;
                    case "SHIFT":
                        chk_Shift.Checked = true;
                        break;
                    default:
                        cmb_KeyValue.SelectedIndex = cmb_KeyValue.FindStringExact(token);
                        break;
                }
            }
        }

        private void CommitHotKey()
        {
            if (!(chk_Win.Checked || chk_Ctrl.Checked || chk_Alt.Checked || chk_Shift.Checked))
            {
                MessageBox.Show("Invalid Hotkey.  You must select one of CTRL, ALT, Shift, or WIN.");
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(chk_Ctrl.Checked ? "CTRL+" : null);
            sb.Append(chk_Alt.Checked ? "ALT+" : null);
            sb.Append(chk_Win.Checked ? "WIN+" : null);
            sb.Append(chk_Shift.Checked ? "SHIFT+" : null);
            sb.Append(cmb_KeyValue.Text);

            Properties.Settings.Default.Hotkey = sb.ToString();
            Properties.Settings.Default.Save();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CommitHotKey();
            this.Close();
        }
    }
}
