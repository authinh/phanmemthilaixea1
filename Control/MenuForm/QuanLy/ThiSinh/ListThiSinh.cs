using Control.DAL;
using PhanMemQuanLy.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.MenuForm.QuanLy.ThiSinh
{
    public partial class ListThiSinh : Form
    {
        public ListThiSinh()
        {
            InitializeComponent();
            data.AutoGenerateColumns = false;
        }

        private void ListThiSinh_Load(object sender, EventArgs e)
        {
            data.DataSource = UserDAL.getAllUser(0,"","","",new DateTime(),0);
            cbExams.DataSource = ExamDAL.getAllExams();
            cbExams.DisplayMember = "ExamTitle";
            cbExams.ValueMember = "ExamID";
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                for(int i = 0;i< data.ColumnCount; i++)
                {
                    data.Rows[e.RowIndex].Cells[i].Selected = true;
                }
            }
        }
    }
}
