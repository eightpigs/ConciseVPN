namespace ConciseVPN
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClose = new System.Windows.Forms.Label();
            this.pbLine = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbList = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDisConnect = new System.Windows.Forms.PictureBox();
            this.pbConnectCurrent = new System.Windows.Forms.PictureBox();
            this.clbUser = new System.Windows.Forms.CheckedListBox();
            this.clbVPN = new System.Windows.Forms.CheckedListBox();
            this.gbVPN = new System.Windows.Forms.GroupBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectCurrent)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblClose.Font = new System.Drawing.Font("Consolas", 12F);
            this.lblClose.Location = new System.Drawing.Point(218, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 19);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pbLine
            // 
            this.pbLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLine.Image = global::ConciseVPN.Properties.Resources.disconnect_line;
            this.pbLine.ImageLocation = "";
            this.pbLine.Location = new System.Drawing.Point(-2, 29);
            this.pbLine.Name = "pbLine";
            this.pbLine.Size = new System.Drawing.Size(58, 6);
            this.pbLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLine.TabIndex = 4;
            this.pbLine.TabStop = false;
            this.pbLine.MouseEnter += new System.EventHandler(this.pbLine_MouseEnter);
            // 
            // pbEdit
            // 
            this.pbEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::ConciseVPN.Properties.Resources.edit;
            this.pbEdit.ImageLocation = "";
            this.pbEdit.Location = new System.Drawing.Point(114, 4);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(18, 19);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 3;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // pbList
            // 
            this.pbList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbList.Image = global::ConciseVPN.Properties.Resources.list;
            this.pbList.ImageLocation = "";
            this.pbList.Location = new System.Drawing.Point(185, 4);
            this.pbList.Name = "pbList";
            this.pbList.Size = new System.Drawing.Size(18, 19);
            this.pbList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbList.TabIndex = 3;
            this.pbList.TabStop = false;
            this.pbList.Click += new System.EventHandler(this.pbList_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDelete.Image = global::ConciseVPN.Properties.Resources.delete;
            this.pbDelete.ImageLocation = "";
            this.pbDelete.Location = new System.Drawing.Point(150, 4);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(18, 19);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 3;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::ConciseVPN.Properties.Resources.add;
            this.pbAdd.ImageLocation = "";
            this.pbAdd.Location = new System.Drawing.Point(79, 4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(18, 19);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 3;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDisConnect
            // 
            this.pbDisConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDisConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDisConnect.Image = global::ConciseVPN.Properties.Resources.disconnect;
            this.pbDisConnect.ImageLocation = "";
            this.pbDisConnect.Location = new System.Drawing.Point(44, 4);
            this.pbDisConnect.Name = "pbDisConnect";
            this.pbDisConnect.Size = new System.Drawing.Size(18, 19);
            this.pbDisConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisConnect.TabIndex = 2;
            this.pbDisConnect.TabStop = false;
            this.pbDisConnect.Click += new System.EventHandler(this.pbDisConnect_Click);
            // 
            // pbConnectCurrent
            // 
            this.pbConnectCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbConnectCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConnectCurrent.Image = global::ConciseVPN.Properties.Resources.connect;
            this.pbConnectCurrent.ImageLocation = "";
            this.pbConnectCurrent.Location = new System.Drawing.Point(8, 4);
            this.pbConnectCurrent.Name = "pbConnectCurrent";
            this.pbConnectCurrent.Size = new System.Drawing.Size(18, 19);
            this.pbConnectCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConnectCurrent.TabIndex = 1;
            this.pbConnectCurrent.TabStop = false;
            this.pbConnectCurrent.Click += new System.EventHandler(this.pbConnect_Click);
            // 
            // clbUser
            // 
            this.clbUser.FormattingEnabled = true;
            this.clbUser.Location = new System.Drawing.Point(26, 125);
            this.clbUser.Name = "clbUser";
            this.clbUser.Size = new System.Drawing.Size(30, 21);
            this.clbUser.TabIndex = 6;
            // 
            // clbVPN
            // 
            this.clbVPN.FormattingEnabled = true;
            this.clbVPN.Location = new System.Drawing.Point(0, 125);
            this.clbVPN.Name = "clbVPN";
            this.clbVPN.Size = new System.Drawing.Size(26, 21);
            this.clbVPN.TabIndex = 6;
            // 
            // gbVPN
            // 
            this.gbVPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbVPN.Location = new System.Drawing.Point(0, 2);
            this.gbVPN.Name = "gbVPN";
            this.gbVPN.Padding = new System.Windows.Forms.Padding(20);
            this.gbVPN.Size = new System.Drawing.Size(112, 120);
            this.gbVPN.TabIndex = 7;
            this.gbVPN.TabStop = false;
            this.gbVPN.Text = "VPN";
            // 
            // gbUser
            // 
            this.gbUser.Location = new System.Drawing.Point(124, 2);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(20);
            this.gbUser.Size = new System.Drawing.Size(112, 120);
            this.gbUser.TabIndex = 7;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.gbVPN);
            this.panel.Controls.Add(this.gbUser);
            this.panel.Location = new System.Drawing.Point(0, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(236, 125);
            this.panel.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(238, 152);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.clbVPN);
            this.Controls.Add(this.clbUser);
            this.Controls.Add(this.pbLine);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbList);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbDisConnect);
            this.Controls.Add(this.pbConnectCurrent);
            this.Controls.Add(this.lblClose);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "ConciseVPN";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Deactivate += new System.EventHandler(this.frmMain_Deactivate);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseEnter += new System.EventHandler(this.frmMain_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectCurrent)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pbConnectCurrent;
        private System.Windows.Forms.PictureBox pbDisConnect;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.PictureBox pbLine;
        private System.Windows.Forms.PictureBox pbList;
        private System.Windows.Forms.CheckedListBox clbUser;
        private System.Windows.Forms.CheckedListBox clbVPN;
        private System.Windows.Forms.GroupBox gbVPN;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Panel panel;
    }
}

