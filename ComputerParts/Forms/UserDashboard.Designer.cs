
namespace ComputerParts.Forms
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_active = new System.Windows.Forms.Panel();
            this.btnItemList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnRequestUnit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dshTime = new System.Windows.Forms.Label();
            this.dshDate = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.timerDash = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackgroundImage = global::ComputerParts.Properties.Resources.bg_login;
            this.panelSideMenu.Controls.Add(this.btnLogOut);
            this.panelSideMenu.Controls.Add(this.menu_active);
            this.panelSideMenu.Controls.Add(this.btnItemList);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Controls.Add(this.bunifuSeparator1);
            this.panelSideMenu.Controls.Add(this.btnRequestUnit);
            this.panelSideMenu.Cursor = System.Windows.Forms.Cursors.No;
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(330, 1102);
            this.panelSideMenu.TabIndex = 1;
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
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 1028);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(71)))), ((int)(((byte)(101)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(330, 74);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // menu_active
            // 
            this.menu_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(14)))), ((int)(((byte)(134)))));
            this.menu_active.Location = new System.Drawing.Point(0, 120);
            this.menu_active.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu_active.Name = "menu_active";
            this.menu_active.Size = new System.Drawing.Size(8, 72);
            this.menu_active.TabIndex = 7;
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
            this.btnItemList.Location = new System.Drawing.Point(6, 121);
            this.btnItemList.Margin = new System.Windows.Forms.Padding(0);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Normalcolor = System.Drawing.Color.Transparent;
            this.btnItemList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(71)))), ((int)(((byte)(101)))));
            this.btnItemList.OnHoverTextColor = System.Drawing.Color.White;
            this.btnItemList.selected = false;
            this.btnItemList.Size = new System.Drawing.Size(330, 74);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(330, 119);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ComputerParts.Properties.Resources.icon;
            this.pbLogo.Location = new System.Drawing.Point(122, 25);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(86, 68);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(6, 91);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(330, 54);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnRequestUnit
            // 
            this.btnRequestUnit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(13)))), ((int)(((byte)(134)))));
            this.btnRequestUnit.BackColor = System.Drawing.Color.Transparent;
            this.btnRequestUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequestUnit.BorderRadius = 0;
            this.btnRequestUnit.ButtonText = "Request Unit";
            this.btnRequestUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestUnit.DisabledColor = System.Drawing.Color.Gray;
            this.btnRequestUnit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRequestUnit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRequestUnit.Iconimage")));
            this.btnRequestUnit.Iconimage_right = null;
            this.btnRequestUnit.Iconimage_right_Selected = null;
            this.btnRequestUnit.Iconimage_Selected = null;
            this.btnRequestUnit.IconMarginLeft = 0;
            this.btnRequestUnit.IconMarginRight = 0;
            this.btnRequestUnit.IconRightVisible = true;
            this.btnRequestUnit.IconRightZoom = 0D;
            this.btnRequestUnit.IconVisible = true;
            this.btnRequestUnit.IconZoom = 90D;
            this.btnRequestUnit.IsTab = false;
            this.btnRequestUnit.Location = new System.Drawing.Point(6, 195);
            this.btnRequestUnit.Margin = new System.Windows.Forms.Padding(0);
            this.btnRequestUnit.Name = "btnRequestUnit";
            this.btnRequestUnit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRequestUnit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(71)))), ((int)(((byte)(101)))));
            this.btnRequestUnit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRequestUnit.selected = false;
            this.btnRequestUnit.Size = new System.Drawing.Size(330, 74);
            this.btnRequestUnit.TabIndex = 17;
            this.btnRequestUnit.Text = "Request Unit";
            this.btnRequestUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRequestUnit.Textcolor = System.Drawing.Color.White;
            this.btnRequestUnit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestUnit.Click += new System.EventHandler(this.btnRequestUnit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(7)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.dshTime);
            this.panel4.Controls.Add(this.dshDate);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(330, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1612, 92);
            this.panel4.TabIndex = 2;
            // 
            // dshTime
            // 
            this.dshTime.AutoSize = true;
            this.dshTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dshTime.Location = new System.Drawing.Point(1691, 25);
            this.dshTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dshTime.Name = "dshTime";
            this.dshTime.Size = new System.Drawing.Size(120, 29);
            this.dshTime.TabIndex = 2;
            this.dshTime.Text = "h:mm:ss tt";
            // 
            // dshDate
            // 
            this.dshDate.AutoSize = true;
            this.dshDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dshDate.Location = new System.Drawing.Point(21, 25);
            this.dshDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dshDate.Name = "dshDate";
            this.dshDate.Size = new System.Drawing.Size(199, 29);
            this.dshDate.TabIndex = 1;
            this.dshDate.Text = "Date Placeholder";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(7)))), ((int)(((byte)(70)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1907, 31);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.Control;
            this.panel_main.Controls.Add(this.bunifuSeparator2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(330, 92);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1612, 1010);
            this.panel_main.TabIndex = 3;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, -28);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(870, 54);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // timerDash
            // 
            this.timerDash.Enabled = true;
            this.timerDash.Tick += new System.EventHandler(this.timerDash_Tick);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private System.Windows.Forms.Panel menu_active;
        private Bunifu.Framework.UI.BunifuFlatButton btnItemList;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRequestUnit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dshTime;
        private System.Windows.Forms.Label dshDate;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panel_main;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Timer timerDash;
    }
}