using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KTV_stand_online_vsrsion
{
    public partial class FormMsSong : Form
    {
        public FormMsSong()
        {
            InitializeComponent();
        }

        private void FormMsSong_Load(object sender, EventArgs e)
        {
            string sql = "select id AS 编号,name AS 歌曲名,singer AS 歌手,hot AS 热度 from T_song";
            DBoperateClass operate = new DBoperateClass();
            this.dataGV.DataSource = operate.getDataset(sql).Tables[0];
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBoperateClass operate = new DBoperateClass();
            int deleteCount = 0;
            for (int i = this.dataGV.Rows.Count - 1; i >= 0;i-- )
            {
                if (this.dataGV.Rows[i].Selected)
                {
                 //   MessageBox.Show( this.dataGV.Rows[i].Cells[0].Value.ToString());
                    string deleteSQL = string.Format("delete from T_song where id={0}",this.dataGV.Rows[i].Cells[0].Value);
                    this.dataGV.Rows.RemoveAt(i);
                    deleteCount += operate.operate(deleteSQL);
                }
            }
            labTip.Text = string.Format("删除{0}首歌曲",deleteCount.ToString());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGV.Rows[e.RowIndex].Selected = true;
        }
    }
}
