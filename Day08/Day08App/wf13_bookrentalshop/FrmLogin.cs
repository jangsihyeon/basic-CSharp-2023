using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace wf13_bookrentalshop
{
    public partial class FrmLogin : Form
    {
        private bool isLogined = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            isLogined = LoginProcess();

            if (isLogined)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application.Exit();
                Environment.Exit(0);   // 가장 완벽하게 프로그램을 종료 
            
        }

        // 이게 없으면 X 버튼이나 Alt+F4 로 했을 때 메인폼이 나타남 
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 로그인 안되었을때 창을 닫으면 프로그램 모두 종료
            if (isLogined != true)
            {
                Environment.Exit(0);
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)  // 엔터키를 누르면
            {
                BtnLogin_Click(sender, e);   // 버튼 클릭 이벤트 핸들러 호출 
            }
        }

        //  DB usertbl에서 정보 확인 로그인처리 
        private bool LoginProcess()
        {
            // Valeidation check (입력 검증)
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("유저 아이디를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = "";
            string strPassword = "";

            try
            {
                // DB 처리 
                /* 이 방식은 close를 직접 해줘야함 
                MySqlConnection conn = new MySqlConnection("");
                conn.Open();
                conn.Close();*/
                string connectionString = "Server=localhost;Port=3306;DataBase=bookrentalshop;Uid=root;Pwd=12345";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    #region  << Db 쿼리를 위한 구성>>

                    string selQuery = @"SELECT userID 
	                                                           , password 
                                                        FROM usertbl 
                                                     WHERE userId = @userId
                                                        AND password = @password";
                    MySqlCommand selcmd = new MySqlCommand(selQuery, conn);
                    // @userId, @password 파라미터 할당
                    MySqlParameter prmUserId = new MySqlParameter("@userId", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);
                    selcmd.Parameters.Add(prmUserId);
                    selcmd.Parameters.Add(prmPassword);

                    #endregion

                    MySqlDataReader reader = selcmd.ExecuteReader();  // 실행한 다음에 위에 있는 userid랑 password를 받아옴 
                    if (reader.Read())
                    {
                        strUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";
                        strPassword = reader["password"] != null ? reader["password"].ToString() : "--";
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"로그인 정보가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    // conn.Close(); close를 직접 해줌 
                }
                // MessageBox.Show($"{strUserId} / {strPassword}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 유저아이디 텍스트박스에서 엔터를 치면 패스워드 텍스트박스로 포커스 이동 
        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }
    }
}
