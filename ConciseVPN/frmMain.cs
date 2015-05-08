using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ConciseVPN.Properties;
using Timer = System.Windows.Forms.Timer;

namespace ConciseVPN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resources.logo.GetHicon());
            setHidden();
        }

        #region 设置事件
        private void setEvent()
        {
            //设置各个组件的鼠标进入/离开事件
            panel.MouseEnter += sender_MouseEnter;
            panel.MouseLeave += sender_MouseLeave;
            this.MouseLeave += sender_MouseLeave;
            gbVPN.MouseEnter += sender_MouseEnter;
            gbVPN.MouseLeave += sender_MouseLeave;
            gbUser.MouseEnter += sender_MouseEnter;
            gbUser.MouseLeave += sender_MouseLeave;

            //设置功能按钮的鼠标离开事件
            pbAdd.MouseLeave += sender_MouseLeave;
            pbConnectCurrent.MouseLeave += sender_MouseLeave;
            pbDelete.MouseLeave += sender_MouseLeave;
            pbDisConnect.MouseLeave += sender_MouseLeave;
            pbEdit.MouseLeave += sender_MouseLeave;
            pbList.MouseLeave += sender_MouseLeave;
            lblClose.MouseLeave += sender_MouseLeave;

            //设置功能按钮的鼠标进入事件
            pbAdd.MouseEnter += sender_MouseEnter;
            pbConnectCurrent.MouseEnter += sender_MouseEnter;
            pbDelete.MouseEnter += sender_MouseEnter;
            pbDisConnect.MouseEnter += sender_MouseEnter;
            pbEdit.MouseEnter += sender_MouseEnter;
            pbList.MouseEnter += sender_MouseEnter;
            lblClose.MouseEnter += sender_MouseEnter;

            //设置功能按钮的鼠标悬浮事件
            pbAdd.MouseHover += sender_MouseHover;
            pbConnectCurrent.MouseHover += sender_MouseHover;
            pbDelete.MouseHover += sender_MouseHover;
            pbDisConnect.MouseHover += sender_MouseHover;
            pbEdit.MouseHover += sender_MouseHover;
            pbList.MouseHover += sender_MouseHover;
        }
        #endregion

        #region 需要用到的变量
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //显示或隐藏timer
        Timer timer = new Timer();
        //隐藏时的坐标
        private Point hidePoint;
        //显示时的坐标
        private Point showPoint;

        private Form thisForm = null;
        //第几次显示窗体
        private int times = 0;
        //当前操作的VPN
        private string currentVPN = null; 

        //当前的用户信息
        private string[] user = new string[2];
        
        //检测连接状态
        private Timer getStatusTimer = null;
        #endregion

        #region 窗体启动事件
        private void frmMain_Load(object sender, EventArgs e)
        {
            setStartInfo();
            setEvent();
        }

        #endregion

        #region 设置读取到的用户信息

        private void setUserInfo()
        {
            List<string[]> users = UserOperation.ReadInfo(Application.StartupPath + "/app.config");
            int count = 1;
            foreach (string[] user in users)
            {
                RadioButton radioUser = new RadioButton();
                radioUser.Text = user[0];
                radioUser.Tag = user[1];
                radioUser.Name = "rdoUser_" + user[0];
                radioUser.Visible = true;
                radioUser.Location = new Point(5, 20 * count);
                radioUser.MouseEnter += sender_MouseEnter;
                radioUser.MouseLeave += sender_MouseLeave;
                radioUser.Click += radioUser_Click;
                gbUser.Controls.Add(radioUser);
                count++;
            }
        }

        void radioUser_Click(object sender, EventArgs e)
        {
            user[0] = ((RadioButton)sender).Text;
            user[1] = ((RadioButton)sender).Tag.ToString();
        }  
        #endregion

        #region 设置启动的信息

        private void setStartInfo()
        {
            thisForm = this;
            this.Height = 29;
            //设置显示位置
            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);
            this.Location = new Point((rect.Width / 4) * 2, 0);

            timer.Interval = 500;
            timer.Tick += timer_Tick;
            timer.Start();

            hidePoint = new Point((rect.Width / 4) * 2, -30);
            showPoint = new Point((rect.Width / 4) * 2, 0);

            setVpnNames();
            setUserInfo();
            panel.Visible = false;
            checkConntect();
            getStatusTimer = new Timer();
            getStatusTimer.Interval = 2000;
            getStatusTimer.Tick += getStatusTimer_Tick;
            getStatusTimer.Start();
        }

        void getStatusTimer_Tick(object sender, EventArgs e)
        {
            ThreadStart starter = delegate { checkConntect(); };
            Thread thread = new Thread(starter);
            thread.IsBackground = true;
            thread.Start();
        } 
        #endregion

        #region 设置VPN的名称.添加到ListView

        private void setVpnNames()
        {
            List<String> names = NetUtil.GetAllAdslName();

            int count = 1;
            foreach (string name in names)
            {
                if (name.IndexOf("vpn") != -1 || name.IndexOf("VPN") != -1)
                {
                    RadioButton radioVPN = new RadioButton();
                    radioVPN.Text = name;
                    radioVPN.Name = "rdoVPN_" + name;
                    radioVPN.Visible = true;
                    radioVPN.Location = new Point(5, 20 * count);
                    radioVPN.MouseEnter += sender_MouseEnter;
                    radioVPN.MouseLeave += sender_MouseLeave;
                    radioVPN.Click += radioVPN_Click;
                    gbVPN.Controls.Add(radioVPN);
                    count++;
                }
            }
        }

        void radioVPN_Click(object sender, EventArgs e)
        {
            currentVPN = ((RadioButton) sender).Text;
        }

        #endregion

        #region 检查是否连接VPN

        private void checkConntect()
        {
            //检测VPN是否连接
            String result = VPNTools.checkCoonnect();
            if (result.Equals("false"))
                pbLine.Image = Resources.disconnect_line;
            
            else
            {
                pbLine.Image = Resources.connect_line;
                currentVPN = result;
                foreach (Control control in gbVPN.Controls)
                {
                    if (((RadioButton) control).Text.Equals(currentVPN))
                    {
                        ((RadioButton) control).Checked = true;
                    }
                }
            }
        }
        
        #endregion

        #region 鼠标移开窗体1秒自动隐藏
        private int index = 0;
        void timer_Tick(object sender, EventArgs e)
        {
            if (index == 1)
            {
                setHidden();
            }
            index++;

        } 
        #endregion

        #region 隐藏窗体

        private void setHidden()
        {
            this.Height = 34;
            this.Width = pbLine.Width - 3;
            this.Location = hidePoint;
            panel.Visible = false;
            isListShow = false;
        } 
        #endregion

        #region 窗体显示
        private void frmMain_MouseEnter(object sender, EventArgs e)
        {
            //鼠标进入窗体停止timer
            timer.Stop();
            index = 0;
        } 
        #endregion

        #region 鼠标移动到状态指示线

        private void pbLine_MouseEnter(object sender, EventArgs e)
        {
            show();
        } 
        #endregion

        #region 窗体得到焦点
        private void frmMain_Activated(object sender, EventArgs e)
        {
            //窗体第一次启动不调用
            if (times == 1)
            {
                show();
                times = 2;
            }
            if (times !=2 )
            {
                times = 1;
            }
        } 
        #endregion

        #region 显示面板
        private void show()
        {
            thisForm.Width = 238;
            thisForm.Height = 29;
            thisForm.Location = showPoint;
            timer.Stop();
        } 
        #endregion

        #region 连接VPN

        private void pbConnect_Click(object sender, EventArgs e)
        {
            //连接默认VPN
            getVpnName();
            checkConntect();
            if (currentVPN != null)
            {
                //使用后台线程执行
                ThreadStart starter = delegate { VPNTools.connect(currentVPN, user[0], user[1]); };
                Thread thread = new Thread(starter);
                thread.IsBackground = true;
                thread.Start();
            }

        }
        #endregion

        #region 获取选中的VPN名称

        private void getVpnName()
        {
            for (int i = 0; i < clbVPN.Items.Count; i++)
            {
                if (clbVPN.GetItemChecked(i))//是否选中
                {
                    currentVPN = clbVPN.Items[i].ToString();
                }
            }
        } 
        #endregion

        #region 断开连接
        private void pbDisConnect_Click(object sender, EventArgs e)
        {
            //断开连接
            checkConntect();
            getVpnName();
            //使用后台线程执行
            ThreadStart starter = delegate { VPNTools.disConnect(currentVPN); };
            Thread thread = new Thread(starter);
            thread.IsBackground = true;
            thread.Start();
            checkConntect();
        } 
        #endregion

        #region 添加新连接
        private void pbAdd_Click(object sender, EventArgs e)
        {
            //添加新的连接
            Thread thread = new Thread(new ThreadStart(VPNTools.createConnection));
            thread.IsBackground = true;
            thread.Start();
        }

        #endregion

        #region 修改当前连接
        private void pbEdit_Click(object sender, EventArgs e)
        {
            //修改指定连接
            getVpnName();
            ThreadStart starter = delegate { VPNTools.editConnection(currentVPN); };
            Thread thread = new Thread(starter);
            thread.IsBackground = true;
            thread.Start();
        }
        #endregion

        #region 删除指定连接

        private void pbDelete_Click(object sender, EventArgs e)
        {
            //删除指定连接
            getVpnName();
            ThreadStart starter = delegate { VPNTools.deleteConnection(currentVPN); };
            Thread thread = new Thread(starter);
            thread.IsBackground = true;
            thread.Start();
            setVpnNames();
        }


        #endregion
       
        #region 显示隐藏VPN/用户列表
        private bool isListShow = false;
        private void pbList_Click(object sender, EventArgs e)
        {
            setVpnNames();
            if (!isListShow)
            {
                thisForm.Height = 152;
                panel.Visible = true;
                isListShow = !isListShow;
            }
            else
            {
                thisForm.Height = 29;
                panel.Visible = false;
                isListShow = !isListShow;
            }
        } 

        #endregion

        #region 焦点离开窗体
        private void frmMain_Deactivate(object sender, EventArgs e)
        {
            timer.Start();
        }

        #endregion

        #region 通用组件响应事件
        private void sender_MouseEnter(object sender, EventArgs e)
        {
            thisForm.Location = showPoint;
            timer.Stop();
        }

        private void sender_MouseLeave(object sender, EventArgs e)
        {
            timer.Start();
        }
        #endregion

        #region 功能按钮的鼠标悬浮事件

        private void sender_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = 5000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 200;
            tip.ShowAlways = true;
            if (((PictureBox)sender).Name.IndexOf("Add") != -1)
                tip.SetToolTip((PictureBox)sender, TipContext.addTip);
            if (((PictureBox)sender).Name.IndexOf("Delete") != -1)
                tip.SetToolTip((PictureBox)sender, TipContext.deleteTip);
            if (((PictureBox)sender).Name.IndexOf("DisConnect") != -1)
                tip.SetToolTip((PictureBox)sender, TipContext.disConnectTip);
            if (((PictureBox)sender).Name.IndexOf("ConnectCurrent") != -1)
                tip.SetToolTip((PictureBox)sender, TipContext.addTip);
            if (((PictureBox)sender).Name.IndexOf("Edit") != -1)
                tip.SetToolTip((PictureBox)sender, TipContext.editTip);
            if (((PictureBox)sender).Name.IndexOf("List") != -1)
                tip.SetToolTip((PictureBox)sender, TipContext.listTip);
        } 
        #endregion

    }
}
