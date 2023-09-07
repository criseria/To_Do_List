using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Enter 키를 누를 때 btnAdd_Click 메서드 호출 기능 설정
            this.AcceptButton = btnAdd;
        }

        // 초기 위치의 y축값 설정
        int positon = 10;

        // 할 일 항목을 추가하는 메서드
        public void addItem(string Text, string Key, bool Checked)
        {
            todo_item item = new To_Do_List.todo_item(Text, Key, Checked);

            item.Location = new System.Drawing.Point(10, positon);

            panel2.Controls.Add(item);

            // ToDoList의 상태 변경 및 삭제 처리를 위한 이벤트 핸들러
            item.onChange += Item_onChange;
            item.onDelete += Item_onDelete;

            // 항목 추가 후, positon 값을 증가시켜 다음 항목이 하단에 나오도록 함
            positon += item.Height + 10;
        }

        // 할 일 항목 삭제 이벤트 핸들러
        private void Item_onDelete(object sender, EventArgs e)
        {
            // 삭제 버튼을 클릭하면 해당 항목을 화면에서 제거하고 컨트롤 리스트에서도 제거
            todo_item item = sender as todo_item;
            if (item != null)
            {
                // 항목 인덱스를 찾고 유효한 경우에만 제거
                int removedIndex = panel2.Controls.IndexOf(item);
                if (removedIndex >= 0)
                {   
                    panel2.Controls.RemoveAt(removedIndex);
                }

                // 항목을 제거한 이후 밑의 항목들을 위로 이동시키기
                for (int i = removedIndex; i < panel2.Controls.Count; i++)
                {
                    Control control = panel2.Controls[i];
                    control.Top -= item.Height + 10;
                }

                // positon 값을 감소시켜 삭제 후 맨 아래에 추가되도록 함
                // 이렇게 position값을 빼 주지 않을경우 새로운 내용을 추가하였을 때 겹쳐져서 나타남.
                positon -= item.Height + 10;
            }
        }

        // 할 일 항목 상태 변경 이벤트 핸들러
        private void Item_onChange(object sender, EventArgs e)
        {
            // 이곳에 할 일 항목 상태가 변경되었을 때 처리할 로직을 추가할 수 있음
            // 현재는 아무 동작도 하지 않음
        }
        
        private void txt_Enter(object sender, EventArgs e)
        {
            // 텍스트 상자에 포커스를 주었을 때
            // 텍스트 상자 안의 내용이 "Write Your Plan Here!"일 경우, 내용을 지움
            if (txt.Text == "Write Your Plan Here!")
            {
                txt.Text = "";
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            // 텍스트 상자에 포커스를 해제 할 경우
            // PlaceHolder효과를 주기 위해서 사용.
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "Write Your Plan Here!";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 텍스트 상자 안의 내용이 없거나
            // 기본설정값인 경우에 메시지박스를 출력
            if (txt.Text.Trim().Length == 0 || txt.Text == "Write Your Plan Here!")
            {
                MessageBox.Show("내용을 입력해주세요!!");
                return;
            }

            // 새 항목을 맨 아래에 추가하고 메시지 박스를 비우기
            addItem(txt.Text, "0", false);
            txt.Text = "";
        }
    }
}