using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf04_filecopy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnFindSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();   // ���â
            if (result == DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        // �Ϲ����� ����� ���Ϻ���
        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);
        }

        private long CopySync(string fromFile, string toFile)
        {
            BtnAsyncCopy.Enabled = false;   // �񵿱��ư �Ͻ� ��Ȱ��ȭ
            long totalCopied = 0;

            using (FileStream fromStream = new FileStream(fromFile, FileMode.Open))   // �������� ����
            {
                using (FileStream toStream = new FileStream(toFile, FileMode.Create))   // Ÿ������ ����
                {
                    byte[] buffer = new byte[1024 * 1024];  // 1MByte ����
                    int nRead = 0;
                    while ((nRead = fromStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;

                        // ���α׷����ٿ� ǥ��
                        PgbCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgbCopy.Maximum;
                    }
                }
            }
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }

        // �񵿱�� ȣ���Ҷ��� await���, �����Ҷ��� async ���
        private async Task<long> CopyASync(string fromFile, string toFile)
        {
            BtnSyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream fromStream = new FileStream(fromFile, FileMode.Open))   // �������� ����
            {
                using (FileStream toStream = new FileStream(toFile, FileMode.Create))   // Ÿ������ ����
                {
                    byte[] buffer = new byte[1024 * 1024];  // 1MByte ����
                    int nRead = 0;
                    while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        // ���α׷����ٿ� ǥ��
                        PgbCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgbCopy.Maximum;
                    }
                }
            }
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }
        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyASync(TxtSource.Text, TxtTarget.Text);
        }
    }
}