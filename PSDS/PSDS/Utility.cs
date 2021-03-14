using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobeCode
{
    /// <summary>
    /// 通用类
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="title">对话框标题</param>
        /// <param name="filter">文件筛选条件</param>
        /// <returns></returns>
        public static string OpenFile(string title="打开工程文件",string filter="ArcGlobe工程文件(*.3dd)|*.3dd")
        {
            string filePath = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.Title = title;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            return filePath;
        }

        /// <summary>
        /// 打开文件夹
        /// </summary>
        /// <returns></returns>
        public static string OpenFolder(string rootFolder=@"F:\PostGraduadte\2020\GlobeCode\init3ddProject")
        {
            string FolderPath = null;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = rootFolder;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowserDialog.SelectedPath;
            }
            return FolderPath;
        }

        /// <summary>
        /// 保存文件对话框
        /// </summary>
        /// <param name="title">对话框标题</param>
        /// <param name="filter">文件条件</param>
        /// <returns></returns>
        public static string SaveFile(string filter="所有文件(*.*)|*.*",string title="保存文件")
        {
            string filePath = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = filter;
            saveFileDialog.Title = title;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
            }
            return filePath;
        }

        /// <summary>
        /// 程序执行路径
        /// </summary>
        /// <returns></returns>
        public static string ExecutablePath()
        {
            return Application.ExecutablePath;
        }

        /// <summary>
        /// 程序源代码目录路径
        /// </summary>
        /// <returns></returns>
        public static string SourceCodeDir()
        {
            string test = ExecutablePath();
            int temp = test.LastIndexOf("\\bin");
            string sourceCodeDir = test.Substring(0, temp);
            return sourceCodeDir;
        }

        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="DirPath"></param>
        public static void DeleteDir(string DirPath)
        {
            Task task = new Task(() =>
              {
                //删除这个目录下的所有子目录
                if (Directory.GetDirectories(DirPath).Length > 0)
                  {
                      foreach (string var in Directory.GetDirectories(DirPath))
                      {
                          Directory.Delete(var, true);
                      }
                  }
                //删除这个目录下的所有文件
                if (Directory.GetFiles(DirPath).Length > 0)
                  {
                      foreach (string var in Directory.GetFiles(DirPath))
                      {
                          File.Delete(var);
                      }
                  }
              });

            task.Start();
            Task.WaitAny((new List<Task> { task }).ToArray());

            //删除该目录
            Directory.Delete(DirPath);
        }

        /// <summary>
        /// 删除目录下的所有文件
        /// </summary>
        /// <param name="dirPath"></param>
        public static void DeleteDirFile(string dirPath)
        {
            //删除这个目录下的所有文件
            if (Directory.GetFiles(dirPath).Length > 0)
            {
                foreach (string var in Directory.GetFiles(dirPath))
                {
                    File.Delete(var);
                }
            }
        }

        /// <summary>
        /// 判断文件是否为图片
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsRealImage(string path)
        {
            try
            {
                Image img = Image.FromFile(path);
                Console.WriteLine("\nIt is a real image");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nIt is a fate image");
                return false;
            }
        }
        /// <summary>
        /// 将源文件夹下的图片移动到指定目录
        /// </summary>
        /// <param name="sourceDir">源图片目录</param>
        /// <param name="targetDir">目标图片目录</param>
        public static void picMove(string sourceDir,string targetDir)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);
            if(dir!=null)
            {
                FileInfo[] fileInfos = dir.GetFiles();
                foreach(var file in fileInfos)
                {
                    if(IsRealImage(file.ToString()))
                    {
                        System.IO.File.Copy(file.ToString(), targetDir + "//" + file.Name);
                    }
                }
            }
        }
    }
}
