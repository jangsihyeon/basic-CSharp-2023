using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_property
{
    public partial class FrmMain : Form
    {
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
            if (cbofontFamily.SelectedIndex < 0) return;

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
    }
}
