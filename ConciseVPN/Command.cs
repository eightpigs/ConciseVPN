using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics; 
using System.Text;
using System.Threading;

namespace ConciseVPN
{
    /**
     * 命令行工具类
     */
    class Command
    {
        private static System.Diagnostics.Process p = null;

        public static String execute(String cmd)
        {
            //如果还有一个线程在执行,.那么,等待1秒后kill它
            if (null != p)
            {
                killCmd();
            }
            p = new System.Diagnostics.Process(); 
            p.StartInfo.FileName="cmd.exe";//要执行的程序名称 
            p.StartInfo.UseShellExecute=false; 
            p.StartInfo.RedirectStandardInput=true;//可接受来自调用程序的输入信息 
            p.StartInfo.RedirectStandardOutput=true;//由调用程序获取输出信息 
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.CreateNoWindow=true;//不显示程序窗口 
            p.Start();//启动程序
            //向CMD窗口发送输入信息： 
            p.StandardInput.WriteLine(cmd);
            //获取CMD窗口的输出信息： 
            StreamReader reader = p.StandardOutput;

            if (cmd.Equals("rasdial"))
            {
                //线程休眠2秒.直接执行kill
                Thread thread = new Thread(new ThreadStart(killCmd));
                thread.IsBackground = true;
                thread.Start();
            }

            String result = reader.ReadToEnd();
            p.StandardInput.WriteLine("exit");
            return result;
        }

        /**
         * 在检测是否连接成功时,程序卡住.必须结束掉cmd进程
         * 不管什么情况,休眠1秒直接结束cmd
         */
        public static void killCmd()
        {
            Thread.Sleep(1000);
            System.Diagnostics.Process pr = new System.Diagnostics.Process();
            pr.StartInfo.FileName = "cmd.exe";//要执行的程序名称 
            pr.StartInfo.UseShellExecute = false;
            pr.StartInfo.RedirectStandardInput = true;//可能接受来自调用程序的输入信息 
            pr.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息 
            pr.StartInfo.CreateNoWindow = true;//不显示程序窗口 
            pr.Start();//启动程序 
            //向CMD窗口发送输入信息： 
            p.StandardInput.WriteLine("kill" + p.Id);
            p.StandardInput.WriteLine("exit");
        }
    }
}
