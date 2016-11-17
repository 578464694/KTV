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
