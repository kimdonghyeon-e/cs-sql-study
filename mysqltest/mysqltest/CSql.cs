using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace mysqltest
{
    class CSql
    {
        private MySqlConnection m_conn;

        public int CSqlConnection(string sId, string sPw, string sDb, string sTb)       //SQL연결하고 오픈까지
        {
            string strConn = "Server=localhost;Database=" + sDb + ";Uid=" + sId + ";Pwd=" + sPw + ";";
            m_conn = new MySqlConnection(strConn);

            try
            {
                m_conn.Open();
            }
            catch
            {
                return -1;
            }
            
            return 0;
        }
        public int CSqlDisconn()        //SQL연결해제
        {
            try
            {
                m_conn.Close();
            }
            catch
            {
                return -1;
            }

            return 0;
        }
        public int CInsert(string sTb, string sD1, string sD2, string sD3)      //SQL insert
        {
            string strInst = "insert into " + sTb + " values (\'" + sD1 + "\', \'" + sD2 + "\', \'" + sD3 + "\');";
            MySqlCommand cmd = new MySqlCommand(strInst, m_conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }

            return 0;
        }
        public int CRead(ref DataTable dt, string sTb)          //SQL read
        {
            dt.Clear();
            string strSql = "select * from " + sTb + ";";
            MySqlCommand cmd = new MySqlCommand(strSql, m_conn);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dt.Rows.Add(rdr["col1"], rdr["col2"], rdr["col3"]);
                }
                rdr.Close();
            }
            catch
            {
                return -1;
            }

            return 0;
        }
        ~CSql() {
            
        }

    }
}
