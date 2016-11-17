﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace KTV_stand_online_vsrsion
{
    class DBoperateClass
    {
        /// <summary>
        /// 获得 插入的SQL
        /// </summary>
        /// <param name="songName"></param>
        /// <param name="py"></param>
        /// <returns></returns>
        public string getInsertSQL(string name,string songPath, string py)
        {
            string insert = string.Format("INSERT INTO T_song(name,path,py) VALUES('{0}','{1}','{2}')",name, songPath, py);
            return insert;
        }
        /// <summary>
        /// 数据库连接函数
        /// </summary>
        /// <returns></returns>
        public SqlConnection dbcon()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conStrSong"].ToString();
            con.Open();
            return con;
        }

        /// <summary>
        /// 创建数据库命令
        /// </summary>
        /// <param name="cmdTxt"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        public SqlCommand CreatCommand(string cmdTxt)
        {
            SqlCommand com = new SqlCommand(cmdTxt, dbcon());
            dbcon().Close();
            return com;
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int operate(string s)
        {
            SqlCommand com = new SqlCommand(s, dbcon());
            dbcon().Close();
            return (com.ExecuteNonQuery());//返回受到命令影响的SQL行数
        }
        /// <summary>
        /// 添加歌曲
        /// </summary>
        /// <param name="insertSQL"></param>
        public int Insert(string insertSQL)
        { 
            int rows = operate(insertSQL);
            if(rows == 0)
            {
                MessageBox.Show("插入失败");
            }
            return rows;
        }
        /// <summary>
        /// 绑定 dataSet 全选
        /// </summary>
        /// <returns></returns>
        public DataSet bingDataSet()
        {
            DataSet myds = new DataSet();
            string selectsql = "select * from T_song";
            SqlDataAdapter adapter = new SqlDataAdapter(selectsql, this.dbcon());
            adapter.Fill(myds);
            this.dbcon().Close();
            return myds;
        }
        /// <summary>
        /// 通过 sql 获得dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet getDataset(string sql)
        {
            DataSet myds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, this.dbcon());
            adapter.Fill(myds);
            this.dbcon().Close();
            return myds;
        }
        /// <summary>
        /// 根据sql，绑定FormAdd 中数据源
        /// </summary>
        /// <param name="sql"></param>
       /* public void bindList(string sql)
        {
            FormAdd formadd = new FormAdd();
            
            DBoperateClass operate = new DBoperateClass();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, operate.dbcon());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            //判断数据源
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //在此处会从dgv 获得空行
                int rows = formadd.dgvGetData.Rows.Count;
                rows--;
                for (int i = 0; i < rows; i++)
                {
                    ListViewItem items = new ListViewItem();
                    items.Tag = formadd.dgvGetData.Rows[i].Cells["path"].Value;
                    items.Text = formadd.dgvGetData.Rows[i].Cells["name"].Value.ToString();
                    items.SubItems.Add(formadd.dgvGetData.Rows[i].Cells["id"].Value.ToString());
                    items.SubItems.Add(formadd.dgvGetData.Rows[i].Cells["hot"].Value.ToString()); // 2 保存hot
                    formadd.lvwSongsFromDB.Items.Add(items);
                }
            }
            formadd.ShowDialog();
        }*/
    }
}
