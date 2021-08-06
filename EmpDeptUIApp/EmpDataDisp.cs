using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpDeptUIApp
{
    public partial class EmpDataDisp : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        DataSet ds;
        
        public EmpDataDisp()
        {
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            SqlDataAdapter sd1 = new SqlDataAdapter("SELECT * FROM EMP_DEPT", connString);
            ds = new DataSet();
            sd1.Fill(ds, "Dept Table");
            SqlDataAdapter sd2= new SqlDataAdapter("SELECT * FROM EMP", connString);
            sd2.Fill(ds, "Emp Table");
            sqlConn.Close();
            InitializeComponent();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            deptDataGrid.DataSource = ds.Tables[0];   
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
           empDataGrid.DataSource = ds.Tables[1];
        }
    }
}
