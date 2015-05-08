using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConciseVPN
{
    class NetUtil
    {
        #region 获取adsl所有宽带连接名称

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct RasEntryName      //define the struct to receive the entry name
        {
            public int dwSize;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256 + 1)]
            public string szEntryName;
            #if WINVER5
                 public int dwFlags;
                 [MarshalAs(UnmanagedType.ByValTStr,SizeConst=260+1)]
                 public string szPhonebookPath;
            #endif
        }

        [DllImport("rasapi32.dll", CharSet = CharSet.Auto)]

        public extern static uint RasEnumEntries(
            string reserved,              // reserved, must be NULL
            string lpszPhonebook,         // pointer to full path and file name of phone-book file
            [In, Out]RasEntryName[] lprasentryname, // buffer to receive phone-book entries
            ref int lpcb,                  // size in bytes of buffer
            out int lpcEntries             // number of entries written to buffer
        );

        public static List<string> GetAllAdslName()
        {
            List<string> list = new List<string>();
            int lpNames = 1;
            int entryNameSize = 0;
            int lpSize = 0;
            RasEntryName[] names = null;
            entryNameSize = Marshal.SizeOf(typeof(RasEntryName));
            lpSize = lpNames * entryNameSize;
            names = new RasEntryName[lpNames];
            names[0].dwSize = entryNameSize;
            uint retval = RasEnumEntries(null, null, names, ref lpSize, out lpNames);

            //if we have more than one connection, we need to do it again
            if (lpNames > 1)
            {
                names = new RasEntryName[lpNames];
                for (int i = 0; i < names.Length; i++)
                {
                    names[i].dwSize = entryNameSize;
                }
                retval = RasEnumEntries(null, null, names, ref lpSize, out lpNames);
            }

            if (lpNames > 0)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    list.Add(names[i].szEntryName);
                }
            }
            return list;
        }

        #endregion
    }
}
