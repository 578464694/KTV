using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace KTV_stand_online_vsrsion
{
    public partial class FormMsLog : Form
    {
        public FormMsLog()
        {
            InitializeComponent();
        }

        private void btnMsLog_Click(object sender, EventArgs e)
        {
            DBoperateClass operate = new DBoperateClass();
            if (this.tbxPwd.Text == string.Empty || this.tbxUsername.Text == string.Empty)
            {
                labTip.Text = "用户名或密码不能为空";
                return;
            }
            string encrytString = UserMd5(this.tbxPwd.Text);
            if (!operate.LogCheck(this.tbxUsername.Text, encrytString))
            {
                labTip.Text = "用户名或密码错误";
            }
            else
            {
                FormMsSong ms = new FormMsSong();
                ms.Show();
            }
        }
        /// <summary>
        /// MD5 加密函数
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        static string UserMd5(string str)
        {
            string cl = str;
            string pwd = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符

                pwd = pwd + s[i].ToString("X");

            }
            return pwd;
        }
    }
}
