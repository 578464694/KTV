using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace KTV_stand_online_vsrsion
{
    public partial class FormAdd : Form
    {
        //用户添加的播放列表
        public static ArrayList gArrPlayList = new ArrayList();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            gArrPlayList.Clear();
        }
        /// <summary>
        /// 绑定播放列表数据源
        /// </summary>
        /// <param name="sql">查询的SQL语句</param>
        public void bindList(string sql)
        {
            DBoperateClass operate = new DBoperateClass();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,operate.dbcon());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            //判断数据源
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {

                this.dgvGetData.DataSource = ds.Tables[0];
                //在此处会从dgv 获得空行
                int rows = dgvGetData.Rows.Count;
                rows--;
                for (int i = 0; i < rows; i++)
                {
                    ListViewItem items = new ListViewItem();
                    items.Tag = dgvGetData.Rows[i].Cells["path"].Value;
                    items.Text = dgvGetData.Rows[i].Cells["name"].Value.ToString(); 
                    items.SubItems.Add(dgvGetData.Rows[i].Cells["id"].Value.ToString());
                    items.SubItems.Add(dgvGetData.Rows[i].Cells["hot"].Value.ToString()); // 2 保存hot
                    this.lvwSongsFromDB.Items.Add(items);
                }
            }
        }
        /// <summary>
        /// 单击歌曲列表，向播放列表添加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwSongsFromDB_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = this.lvwSongsFromDB.SelectedItems[0];
            ListViewItem lviAdd = new ListViewItem();
            lviAdd.Tag = lvi.Tag;
            lviAdd.Text = lvi.Text;
            lviAdd.SubItems.Add(lvi.SubItems[1]);//1 保存id
            lviAdd.SubItems.Add(lvi.SubItems[2]);//2 保存hot
            this.lvwPlayList.Items.Add(lviAdd);
        }
        /// <summary>
        /// 移除播放列表中的歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = this.lvwPlayList.Items.Count-1; i >= 0; i--)
            {
                if (lvwPlayList.Items[i].Selected)
                {
                    lvwPlayList.Items.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// 添加成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterAdd_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in this.lvwPlayList.Items)
            {
                gArrPlayList.Add(lvi);
            }
            MessageBox.Show("添加成功");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// 重新选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lvwPlayList.Items.Clear();
            gArrPlayList.Clear();
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
