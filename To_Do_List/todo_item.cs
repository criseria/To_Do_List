using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Newtonsoft.Json;

namespace To_Do_List
{
    public partial class todo_item : UserControl
    {
        public todo_item()
        {
            InitializeComponent();
        }
        // 생성자로 초기화하는 메서드
        public todo_item(String Text, string Key, bool Checked)
        {
            InitializeComponent();
            key = Key;
            value = Text;
            lbl.Text = Text;
            check.Checked = Checked;
        }

        public event EventHandler onChange = null;
        public event EventHandler onDelete = null;
        public string key = null;
        public string value = null;

        private void check_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (check.Checked)
            {
                this.BackColor = Color.Green;
                lbl.Font = new Font(lbl.Font, FontStyle.Strikeout);
            }
            else
            {
                this.BackColor = Color.Gainsboro;
                lbl.Font = new Font(lbl.Font, FontStyle.Regular);
            }
            // 만약에 수정하기 등 을 통해 빈값을 입력한 상태에서 체크버튼을 눌럿을시에
            // 이벤트가 작동하는 것을 막기 위해서 null값이 아닌경우에만 호출하도록 설정
            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 만약에 체크버튼과 삭제버튼을 비활성화 하지 않을 경우
            // 삭제버튼을 눌러서 항목을 삭제했을 때 입력값은 사라지지만 두개의 버튼은
            // 화면상에 여전히 존재 할 수 있기에 비활성화 처리를 해줘야 한다.
            check.Checked = false;
            btnDelete.Visible = false;

            // 삭제 이벤트를 호출하여 항목 삭제
            if (onDelete != null)
            {
                onDelete.Invoke(this, EventArgs.Empty);
            }

        }

        private void todo_item_Load_1(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                // 체크박스에 체크가 될 경우 중간에 취소선으로 변경하는 코드
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            using (ModifyForm modifyForm = new ModifyForm(lbl.Text))
            {
                if (modifyForm.ShowDialog() == DialogResult.OK)
                {
                    // ModifyForm에서 수정한 내용을 가져와서 지금 화면에 업데이트하는 코드
                    string updatedText = modifyForm.UpdatedText;
                    lbl.Text = updatedText;
                }
            }
        }
    }
}