
namespace ComputerParts
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dshTime = new System.Windows.Forms.Label();
            this.dshDate = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.menu_active = new System.Windows.Forms.Panel();
            this.btnManageUsers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManageItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnItemList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.timerDash = new System.Windows.Forms.Timer(this.components);
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_main.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.bunifuSeparator2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(220, 60);
            this.panel_main.Name = "panel_main";
            this.panel_main.Padding = new System.Windows.Forms.Padding(24);
            this.panel_main.Size = new System.Drawing.Size(844, 568);
            this.panel_main.TabIndex = 2;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, -18);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(580, 35);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(7)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.dshTime);
            this.panel4.Controls.Add(this.dshDate);
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(844, 60);
            this.panel4.TabIndex = 1;
            // 
            // dshTime
            // 
            this.dshTime.AutoSize = true;
            this.dshTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dshTime.Location = new System.Drawing.Point(650, 16);
            this.dshTime.Name = "dshTime";
            this.dshTime.Size = new System.Drawing.Size(94, 24);
            this.dshTime.TabIndex = 2;
            this.dshTime.Text = "h:mm:ss tt";
            // 
            // dshDate
            // 
            this.dshDate.AutoSize = true;
            this.dshDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dshDate.Location = new System.Drawing.Point(14, 16);
            this.dshDate.Name = "dshDate";
            this.dshDate.Size = new System.Drawing.Size(154, 24);
            this.dshDate.TabIndex = 1;
            this.dshDate.Text = "Date Placeholder";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(7)))), ((int)(((byte)(70)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(801, 20);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(17, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackgroundImage = global::ComputerParts.Properties.Resources.bg_login;
            this.panelSideMenu.Controls.Add(this.btnLogOut);
            this.panelSideMenu.Controls.Add(this.menu_active);
            this.panelSideMenu.Controls.Add(this.btnManageUsers);
            this.panelSideMenu.Controls.Add(this.btnManageItems);
            this.panelSideMenu.Controls.Add(this.btnItemList);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Controls.Add(this.bunifuSeparator1);
            this.panelSideMenu.Cursor = System.Windows.Forms.Cursors.No;
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(220, 628);
            this.panelSideMenu.TabIndex = 0;
            // 
            // menu_active
            // 
            this.menu_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(14)))), ((int)(((byte)(134)))));
            this.menu_active.Location = new System.Drawing.Point(0, 78);
            this.menu_active.Name = "menu_active";
            this.menu_active.Size = new System.Drawing.Size(5, 47);
            this.menu_active.TabIndex = 7;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(13)))), ((int)(((byte)(134)))));
            this.btnManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageUsers.BorderRadius = 0;
            this.btnManageUsers.ButtonText = "Manage Users";
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageUsers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageUsers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Iconimage")));
            this.btnManageUsers.Iconimage_right = null;
            this.btnManageUsers.Iconimage_right_Selected = null;
            this.btnManageUsers.Iconimage_Selected = null;
            this.btnManageUsers.IconMarginLeft = 0;
            this.btnManageUsers.IconMarginRight = 0;
            this.btnManageUsers.IconRightVisible = true;
            this.btnManageUsers.IconRightZoom = 0D;
            this.btnManageUsers.IconVisible = true;
            this.btnManageUsers.IconZoom = 90D;
            this.btnManageUsers.IsTab = false;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 176);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Normalcolor = System.Drawing.Color.Transparent;
            this.btnManageUsers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(71)))), ((int)(((byte)(101)))));
            this.btnManageUsers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageUsers.selected = false;
            this.btnManageUsers.Size = new System.Drawing.Size(220, 48);
            this.btnManageUsers.TabIndex = 14;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageUsers.Textcolor = System.Drawing.Color.White;
            this.btnManageUsers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageItems
            // 
            this.btnManageItems.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(13)))), ((int)(((byte)(134)))));
            this.btnManageItems.BackColor = System.Drawing.Color.Transparent;
            this.btnManageItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageItems.BorderRadius = 0;
            this.btnManageItems.ButtonText = "Manage Items";
            this.btnManageItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnManageItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManageItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManageItems.Iconimage")));
            this.btnManageItems.Iconimage_right = null;
            this.btnManageItems.Iconimage_right_Selected = null;
            this.btnManageItems.Iconimage_Selected = null;
            this.btnManageItems.IconMarginLeft = 0;
            this.btnManageItems.IconMarginRight = 0;
            this.btnManageItems.IconRightVisible = true;
            this.btnManageItems.IconRightZoom = 0D;
            this.btnManageItems.IconVisible = true;
            this.btnManageItems.IconZoom = 90D;
            this.btnManageItems.IsTab = false;
            this.btnManageItems.Location = new System.Drawing.Point(0, 128);
            this.btnManageItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageItems.Name = "btnManageItems";
            this.btnManageItems.Normalcolor = System.Drawing.Color.Transparent;
            this.btnManageItems.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(71)))), ((int)(((byte)(101)))));
            this.btnManageItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManageItems.selected = false;
            this.btnManageItems.Size = new System.Drawing.Size(220, 48);
            this.btnManageItems.TabIndex = 13;
            this.btnManageItems.Text = "Manage Items";
            this.btnManageItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageItems.Textcolor = System.Drawing.Color.White;
            this.btnManageItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageItems.Click += new System.EventHandler(this.btnManageItems_Click);
            // 
            // btnItemList
            // 
            this.btnItemList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(13)))), ((int)(((byte)(134)))));
            this.btnItemList.BackColor = System.Drawing.Color.Transparent;
            this.btnItemList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItemList.BorderRadius = 0;
            this.btnItemList.ButtonText = "List Of Items";
            this.btnItemList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemList.DisabledColor = System.Drawing.Color.Gray;
            this.btnItemList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnItemList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnItemList.Iconimage")));
            this.btnItemList.Iconimage_right = null;
            this.btnItemList.Iconimage_right_Selected = null;
            this.btnItemList.Iconimage_Selected = null;
            this.btnItemList.IconMarginLeft = 0;
            this.btnItemList.IconMarginRight = 0;
            this.btnItemList.IconRightVisible = true;
            this.btnItemList.IconRightZoom = 0D;
            this.btnItemList.IconVisible = true;
            this.btnItemList.IconZoom = 90D;
            this.btnItemList.IsTab = false;
            this.btnItemList.Location = new System.Drawing.Point(-3, 79);
            this.btnItemList.Margin = new System.Windows.Forms.Padding(0);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Normalcolor = System.Drawing.Color.Transparent;
            this.btnItemList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(71)))), ((int)(((byte)(101)))));
            this.btnItemList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnItemList.selected = false;
            this.btnItemList.Size = new System.Drawing.Size(220, 48);
            this.btnItemList.TabIndex = 11;
            this.btnItemList.Text = "List Of Items";
            this.btnItemList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItemList.Textcolor = System.Drawing.Color.White;
            this.btnItemList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemList.Click += new System.EventHandler(this.btnItemList_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 77);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ComputerParts.Properties.Resources.icon;
            this.pbLogo.Location = new System.Drawing.Point(81, 16);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(57, 44);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 59);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(220, 35);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // timerDash
            // 
            this.timerDash.Tick += new System.EventHandler(this.timerDash_Tick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(13)))), ((int)(((byte)(134)))));
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "Logout";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 40D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(0, 556);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(71)))), ((int)(((byte)(101)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(220, 48);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel_main.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageUsers;
        private Bunifu.Framework.UI.BunifuFlatButton btnManageItems;
        private Bunifu.Framework.UI.BunifuFlatButton btnItemList;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel menu_active;
        private System.Windows.Forms.Panel panel_main;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label dshDate;
        private System.Windows.Forms.Label dshTime;
        private System.Windows.Forms.Timer timerDash;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
    }
}