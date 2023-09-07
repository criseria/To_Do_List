using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class ModifyForm : Form
    {

        public ModifyForm(string initialText)
        {
            InitializeComponent();
            bunifuTextBox1.Text = initialText;
            StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnSave;
        }

        public string UpdatedText { get; private set; }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            UpdatedText = bunifuTextBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}