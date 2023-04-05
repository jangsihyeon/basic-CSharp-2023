﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf02_realwinapp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  버튼 ok 클릭 이벤트에 대한 처리 메서드 만듦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 클릭!!!", "클릭", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            btnOk.Text = "클릭됌";
            return;
        }

        private void button1_Mousehover(object sender, EventArgs e)
        {
            MessageBox.Show("마우스만 올려도 이벤트가 발생해요");
            return;
        }
    }
}
