using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConciseVPN
{
    /**
     * VPN操作类
     */
    class VPNTools
    {

        /**
         * 连接指定名称的VPN
         */
        public static bool connect(string vpnName, string username, string password)
        {
            String command = "rasdial " + vpnName + " " + username + " " + password;
            String result = Command.execute(command);
            if (result.IndexOf("已连接") > 0)
                return true;
            return false;
        }

        /**
         * 断开指定VPN连接
         */
        public static bool disConnect(String vpnName)
        {
            String command = "rasdial " + vpnName + " /disconnect";
            String result = Command.execute(command);
            if (result.IndexOf("没有连接") > 0)
                return false;
            return true;
        }

        /**
         * 新建VPN连接
         */
        public static void createConnection() {
            String command = "rasphone -a" ;
            Command.execute(command);
        }

        /**
         * 删除VPN连接
         */
        public static void deleteConnection(String vpnName)
        {
            String command = "rasphone -r " + vpnName;
            Command.execute(command);
        }

        /**
        * 修改VPN连接
        */
        public static void editConnection(String vpnName)
        {
            String command = "rasphone -e " + vpnName;
            Command.execute(command);
        }

        /**
         * 检测是否有VPN连接
         */
        public static String checkCoonnect()
        {
            String result = Command.execute("rasdial");
            if (result.IndexOf("没有连接") != -1)
                return "false";
            else{//返回连接中的VPN名称
                result = result.Replace("已连接", "").Replace("命令已完成。","");
                result = result.Substring(result.IndexOf("vpn_"));
                result = result.Substring(0, result.IndexOf("\n\n\r\n"));
                return result;
            }
        }
    }
}
