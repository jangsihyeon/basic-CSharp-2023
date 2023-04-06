using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace wf03_property
{
    public partial class FrmMain : Form
    {
        Random rnd = new Random();

        public FrmMain()
        {
            InitializeComponent();
            // 생성자에는 되도록 설정부분을 넣지마세요
            // Form_Load() 이벤트 핸들러에 작성할 것 
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GbxMain.Text = "컨트롤 학습";
            var fonts = FontFamily.Families.ToList();  // 내 os 폰트이름 가져오기 
            foreach (var font in fonts) 
            {
                cbofontFamily.Items.Add(font.Name);
            }

            // 글자 크기 최소값, 최대값 지정
            NudFontsize.Minimum = 5;
            NudFontsize.Maximum = 40;

            // 텍스트 박스 크기 뭐 어쩌구
            txtResult.Text = "Hello, WinForms!!";

            NudFontsize.Value = 9;  // 기본 글자체 
        }

        /// <summary>
        /// 글자 스타일 , 크기, 글자체를 변경해주는 메서드
        /// </summary>
        private void ChangeFontStyle()
        {
            if (cbofontFamily.SelectedIndex < 0)
            {
                cbofontFamily.SelectedIndex = 257;  // default는 나눔고딕(나는 돋움)으로 지정 
            }

            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked == true)
            {
                style |= FontStyle.Bold;   // Bit or 연산자 
            }
            if(chkItalic.Checked == true) 
            {
                style |= FontStyle.Italic;
            }

            decimal fontSize = NudFontsize.Value;

            txtResult.Font = new Font((string)cbofontFamily.SelectedItem, (float)fontSize, style);

            if (RdoNormal.Checked)  // 라디오 버튼 추가 이벤트 
            {
               txtResult.Text = txtResult.Text.Trim();
            }
            else if (RdoIndent.Checked)
            {
                txtResult.Text = "    " + txtResult.Text;
            }
        }

        void ChangeIndent()
        {
            if (RdoNormal.Checked)  // 라디오 버튼 추가 이벤트 
            {
                txtResult.Text = txtResult.Text.Trim();
            }
            else if (RdoIndent.Checked)
            {
                txtResult.Text = "    " + txtResult.Text;
            }
        }
        
        // 지울거면 참조 0개 만들고 지우기 -> 이벤트(번개버튼)에서 이름 찾아서 전부 다 지우고 지워야함 
        private void cbofontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void NudFontsize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PgbDummy.Value = TrbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form() { 
                Text = "Modal Form",
                Width = 300,
                Height = 200,
                Left = 10,
                Top = 20,
                BackColor = Color.Crimson,
                StartPosition = FormStartPosition.CenterScreen,
            };
            frm.ShowDialog();  // 모달 방식으로 자식창 띄우기.
        }

        private void BtnModalless_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "Modalless Form",
                Width = 300,
                Height = 200,
                StartPosition = FormStartPosition.CenterParent,   // modalless는 centerparent 안먹힘 
                BackColor = Color.GreenYellow,

            };
            frm.Show();   // 모달리스 방식으로 자식창띄움
        }

        // MessageBox는  기본적으로 모달 
        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtResult.Text);
            //MessageBox.Show(txtResult.Text, caption :"메시지창"); // 캡션 추가
            //MessageBox.Show(txtResult.Text,  "메시지창",  MessageBoxButtons.YesNo);   // 버튼 추가 
            //MessageBox.Show(txtResult.Text, "메시지창", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);   // 아이콘 추가 
            MessageBox.Show(txtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                            MessageBoxDefaultButton.Button2);   // 기본 포커스 버튼 설정 
            //MessageBox.Show(txtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            //                                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);   // 오른쪽 정렬 
            

        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
           TrvDummy.Nodes.Add(rnd.Next(50).ToString());
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode!= null)
            {
                TrvDummy.SelectedNode.Nodes.Add(rnd.Next(50, 100).ToString());
                TrvDummy.SelectedNode.Expand();   // 트리 노드 하위 것들을 펼져주기  <-> Collapse
                TreeToList();
            }
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear();    // 리스트 뷰 , 트리뷰 모든 아이템을 제거 초기화 메서드
            foreach(TreeNode item in TrvDummy.Nodes)
            {
                TreeToList(item);
            }
        }

        private void TreeToList(TreeNode item)
        {
            LsvDummy.Items.Add(
                new ListViewItem(new[] { item.Text, item.FullPath.ToString()}));

            foreach(TreeNode node in item.Nodes)
            {
                TreeToList(node);     //재귀호출
            }
                                    
        }

        private void RdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent( );
        }

        private void RdoIndent_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PcbDummy.Image = Image.FromFile("C:\\Source\\basic-CSharp-2023\\Day03\\Day03WinApp\\wf03_property\\cat.png");
        }

        private void PcbDummy_Click(object sender, EventArgs e)
        {
            if (PcbDummy.SizeMode == PictureBoxSizeMode.Normal)
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.Normal;
            }

        }
    }
}
