using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookAppLogic;

namespace FacebookWinFormsApp
{
    public partial class FormLogin : Form
    {
        private LogicManager m_LogicManager;

        public FormLogin()
        {
            m_LogicManager = new LogicManager();
            m_LogicManager.HandelRememberUser();
            InitializeComponent();
        }

        public LogicManager LogicManager
        {
            get { return m_LogicManager; }
        }

        public bool CheckIfRememberUser()
        {
            return m_LogicManager.AppSettings.CheckIfRememberUser();
        }

        public string GetLastAccessToken()
        {
            return m_LogicManager.AppSettings.LastAccessToken;
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberUser.Checked)
            {
                m_LogicManager.AppSettings.RememberUser = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            handleLogin();
        }

        private void handleLogin()
        {
            m_LogicManager.Login();
            if (string.IsNullOrEmpty(m_LogicManager.LoginResult.AccessToken))
            {
                MessageBox.Show("Login Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
        }
    }
}
