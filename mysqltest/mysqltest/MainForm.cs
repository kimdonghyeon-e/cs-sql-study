using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysqltest
{
    public partial class MainForm : Form
    {
        CSql m_sq = new CSql();
        DataTable m_dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            string sId = tbID.Text;
            string sPw = tbPW.Text;
            string sDb = tbDB.Text;
            string sTb = tbTable.Text;

            if (sId == "" || sPw == "" || sDb == "" || sTb == "")
            {
                MessageBox.Show("please input ID, PW, DB, Table");
            }
            else
            {
                if (m_sq.CSqlConnection(sId, sPw, sDb, sTb) != 0)
                {
                    MessageBox.Show("Connection Error");
                }
                else
                {
                    MessageBox.Show("Connected");
                    btDisconn.Enabled = true;
                    btSend.Enabled = true;
                    btConn.Enabled = false;
                    btRead.Enabled = true;
                    tbID.Enabled = false;
                    tbPW.Enabled = false;
                    tbDB.Enabled = false;
                    tbTable.Enabled = false;
                }
            }
        }

        private void btDisconn_Click(object sender, EventArgs e)
        {
            if (m_sq.CSqlDisconn() != 0)
            {
                MessageBox.Show("Disconnection Error");
                btDisconn.Enabled = false;
                btSend.Enabled = false;
                btRead.Enabled = false;
            }
            else
            {
                MessageBox.Show("Disconnected");
                btDisconn.Enabled = false;
                btSend.Enabled = false;
                btConn.Enabled = true;
                btRead.Enabled = false;
                tbID.Enabled = true;
                tbPW.Enabled = true;
                tbDB.Enabled = true;
                tbTable.Enabled = true;
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string sTb = tbTable.Text;
            string sData1 = tbData1.Text;
            string sData2 = tbData2.Text;
            string sData3 = tbData3.Text;

            if (m_sq.CInsert(sTb, sData1, sData2, sData3) != 0)
            {
                lbWrInfo.Text = "Write error";
            }
            else
            {
                lbWrInfo.Text = sData1 + ", " + sData2 + ", " + sData3 + " write success";
                tbData1.Clear();
                tbData2.Clear();
                tbData3.Clear();
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            string sTb = tbTable.Text;
            if (m_sq.CRead(ref m_dt, sTb) != 0)
            {
                lbRead.Text = "Read error";
            }
            else
            {
                dgvReadData.DataSource = m_dt;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvReadData.DataSource = m_dt;
            m_dt.Columns.Add(new DataColumn("column1", typeof(string)));
            m_dt.Columns.Add(new DataColumn("column2", typeof(string)));
            m_dt.Columns.Add(new DataColumn("column3", typeof(string)));
            dgvReadData.Columns["column1"].Width = 100;
            dgvReadData.Columns["column2"].Width = 125;
            dgvReadData.Columns["column3"].Width = 75;
        }
    }
}
