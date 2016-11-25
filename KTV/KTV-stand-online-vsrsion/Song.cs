using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KTV_stand_online_vsrsion
{
    class Song
    {
        int id;
        int hot;
        string path;
        string name;
        /// <summary>
        /// 设置歌曲信息
        /// </summary>
        /// <param name="id">歌曲编号</param>
        /// <param name="hot">热度</param>
        /// <param name="path">路径</param>
        /// <param name="name">名称</param>
        public void setSongInfo(int id,int hot,string path,string name)
        {
            this.id = id;
            this.hot = hot;
            this.path = path;
            this.name = name;
        }
        public string getPath()
        {
            return path;
        }
        public int getId()
        {
            return this.id;
        }
    }
}
