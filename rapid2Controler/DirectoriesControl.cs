using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.Robotics;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.EventLogDomain;
using ABB.Robotics.Controllers.FileSystemDomain;
namespace rapid2Controler
{
    public static class DirectoriesControl
    {
       private static Controller controller = Form1.controller;
        /// <summary>
        /// 检查目录是否存在
        /// </summary>
        /// <param name="path">路径值</param>
        /// <param name="remoteORlocal">0：检查远端目录，1：检查本地目录</param>
        /// <returns></returns>
        public static bool CheckDirectoryExists(string path,int remoteORlocal)
        {
            if (remoteORlocal == 0)
            {return controller.FileSystem.DirectoryExists(path);}
            else if (remoteORlocal ==1)
            { return System.IO.Directory.Exists(path); }
            else
                return false;
        }
        /// <summary>
        /// 检查是否为目录
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public static bool IsDirectory(string path)
        {
            if (true == controller.FileSystem.DirectoryExists(path))
                return true;
            else
                return false;
        }
    }
}
