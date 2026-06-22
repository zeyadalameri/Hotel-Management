namespace zeyadhotel
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetailes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnminimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.lableUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uC_Employees1 = new zeyadhotel.all_user_control.UC_Employees();
            this.uC_CustomerRegisteration1 = new zeyadhotel.all_user_control.UC_CustomerRegisteration();
            this.uC_Addroom1 = new zeyadhotel.all_user_control.UC_Addroom();
            this.uC_CustomerDetails1 = new zeyadhotel.all_user_control.UC_CustomerDetails();
            this.uC_checkout1 = new zeyadhotel.all_user_control.UC_checkout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.uC_Employees1);
            this.guna2Panel1.Controls.Add(this.uC_CustomerRegisteration1);
            this.guna2Panel1.Controls.Add(this.uC_Addroom1);
            this.guna2Panel1.Controls.Add(this.uC_CustomerDetails1);
            this.guna2Panel1.Controls.Add(this.uC_checkout1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 158);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1305, 500);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.movingPanel);
            this.guna2Panel2.Controls.Add(this.btnEmployee);
            this.guna2Panel2.Controls.Add(this.btnCustomerDetailes);
            this.guna2Panel2.Controls.Add(this.btnCheckOut);
            this.guna2Panel2.Controls.Add(this.btnCustomerRegistration);
            this.guna2Panel2.Controls.Add(this.btnAddRoom);
            this.guna2Panel2.Location = new System.Drawing.Point(68, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1249, 140);
            this.guna2Panel2.TabIndex = 1;
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.Cyan;
            this.movingPanel.Location = new System.Drawing.Point(14, 115);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(216, 5);
            this.movingPanel.TabIndex = 3;
            this.movingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.movingPanel_Paint);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Animated = true;
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.DarkCyan;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(1018, 20);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(216, 85);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetailes
            // 
            this.btnCustomerDetailes.Animated = true;
            this.btnCustomerDetailes.BorderRadius = 26;
            this.btnCustomerDetailes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetailes.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetailes.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerDetailes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetailes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetailes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetailes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetailes.FillColor = System.Drawing.Color.DarkCyan;
            this.btnCustomerDetailes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustomerDetailes.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetailes.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetailes.Image")));
            this.btnCustomerDetailes.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomerDetailes.Location = new System.Drawing.Point(767, 21);
            this.btnCustomerDetailes.Name = "btnCustomerDetailes";
            this.btnCustomerDetailes.Size = new System.Drawing.Size(216, 85);
            this.btnCustomerDetailes.TabIndex = 1;
            this.btnCustomerDetailes.Text = "Customer Detailes";
            this.btnCustomerDetailes.Click += new System.EventHandler(this.btnCustomerDetailes_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Animated = true;
            this.btnCheckOut.BorderRadius = 26;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.DarkCyan;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckOut.Location = new System.Drawing.Point(516, 21);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(216, 85);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.Animated = true;
            this.btnCustomerRegistration.BorderRadius = 26;
            this.btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRegistration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRegistration.FillColor = System.Drawing.Color.DarkCyan;
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegistration.Image")));
            this.btnCustomerRegistration.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomerRegistration.Location = new System.Drawing.Point(265, 21);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(216, 85);
            this.btnCustomerRegistration.TabIndex = 0;
            this.btnCustomerRegistration.Text = "Customer registeraiton";
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Animated = true;
            this.btnAddRoom.BorderRadius = 26;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.DarkCyan;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddRoom.Location = new System.Drawing.Point(14, 21);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(216, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderThickness = 2;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(37, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " ";
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimize.BackgroundImage")));
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminimize.FillColor = System.Drawing.Color.Transparent;
            this.btnminimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Location = new System.Drawing.Point(12, 70);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnminimize.Size = new System.Drawing.Size(37, 32);
            this.btnminimize.TabIndex = 2;
            this.btnminimize.Text = " ";
            this.btnminimize.UseTransparentBackground = true;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BorderRadius = 10;
            this.btnrefresh.BorderThickness = 1;
            this.btnrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrefresh.FillColor = System.Drawing.Color.White;
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Location = new System.Drawing.Point(14, 108);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(35, 28);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "R";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // lableUser
            // 
            this.lableUser.BackColor = System.Drawing.Color.Transparent;
            this.lableUser.Location = new System.Drawing.Point(49, 10);
            this.lableUser.Name = "lableUser";
            this.lableUser.Size = new System.Drawing.Size(71, 15);
            this.lableUser.TabIndex = 4;
            this.lableUser.Text = "Welcome User";
            this.lableUser.Click += new System.EventHandler(this.lableUser_Click);
            // 
            // uC_Employees1
            // 
            this.uC_Employees1.BackColor = System.Drawing.Color.White;
            this.uC_Employees1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employees1.Name = "uC_Employees1";
            this.uC_Employees1.Size = new System.Drawing.Size(1320, 573);
            this.uC_Employees1.TabIndex = 5;
            this.uC_Employees1.Load += new System.EventHandler(this.uC_Employees1_Load);
            // 
            // uC_CustomerRegisteration1
            // 
            this.uC_CustomerRegisteration1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegisteration1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerRegisteration1.Name = "uC_CustomerRegisteration1";
            this.uC_CustomerRegisteration1.Size = new System.Drawing.Size(1280, 550);
            this.uC_CustomerRegisteration1.TabIndex = 4;
            // 
            // uC_Addroom1
            // 
            this.uC_Addroom1.BackColor = System.Drawing.Color.White;
            this.uC_Addroom1.Location = new System.Drawing.Point(0, 3);
            this.uC_Addroom1.name = null;
            this.uC_Addroom1.Name = "uC_Addroom1";
            this.uC_Addroom1.Size = new System.Drawing.Size(1317, 604);
            this.uC_Addroom1.TabIndex = 0;
            this.uC_Addroom1.Visible = false;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1320, 587);
            this.uC_CustomerDetails1.TabIndex = 3;
            // 
            // uC_checkout1
            // 
            this.uC_checkout1.BackColor = System.Drawing.Color.White;
            this.uC_checkout1.Location = new System.Drawing.Point(0, 0);
            this.uC_checkout1.Name = "uC_checkout1";
            this.uC_checkout1.Size = new System.Drawing.Size(1320, 587);
            this.uC_checkout1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 682);
            this.Controls.Add(this.lableUser);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2CircleButton btnminimize;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetailes;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private System.Windows.Forms.Panel movingPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private all_user_control.UC_Addroom uC_Addroom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private all_user_control.UC_checkout uC_checkout1;
        private all_user_control.UC_CustomerDetails uC_CustomerDetails1;
        private all_user_control.UC_CustomerRegisteration uC_CustomerRegisteration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private all_user_control.UC_Employees uC_Employees1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lableUser;
    }
}