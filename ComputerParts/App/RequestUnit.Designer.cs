namespace ComputerParts.App
{
    partial class RequestUnit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestUnit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxItemToReq = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtgReq = new System.Windows.Forms.DataGridView();
            this.tbxReqID = new System.Windows.Forms.TextBox();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.tbxContactNo = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReq)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.tbxContactNo);
            this.groupBox1.Controls.Add(this.tbxFullName);
            this.groupBox1.Controls.Add(this.tbxReqID);
            this.groupBox1.Controls.Add(this.tbxItemToReq);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnRequest);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.bunifuFlatButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(685, 1136);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Item";
            // 
            // tbxItemToReq
            // 
            this.tbxItemToReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemToReq.Location = new System.Drawing.Point(45, 551);
            this.tbxItemToReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxItemToReq.Name = "tbxItemToReq";
            this.tbxItemToReq.Size = new System.Drawing.Size(594, 35);
            this.tbxItemToReq.TabIndex = 69;
            this.tbxItemToReq.TextChanged += new System.EventHandler(this.btnItemToReq_TextChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(45, 651);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(194, 35);
            this.nudQuantity.TabIndex = 68;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(45, 605);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(106, 29);
            this.lblQty.TabIndex = 66;
            this.lblQty.Text = "Quantity:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(40, 506);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(178, 29);
            this.bunifuCustomLabel3.TabIndex = 64;
            this.bunifuCustomLabel3.Text = "Item to request:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(8)))), ((int)(((byte)(119)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(122, 736);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 85);
            this.btnClear.TabIndex = 61;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(8)))), ((int)(((byte)(119)))));
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRequest.Location = new System.Drawing.Point(374, 736);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(170, 86);
            this.btnRequest.TabIndex = 60;
            this.btnRequest.Text = "REQUEST";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(40, 280);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(80, 29);
            this.bunifuCustomLabel5.TabIndex = 58;
            this.bunifuCustomLabel5.Text = "Email:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(40, 402);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(139, 29);
            this.bunifuCustomLabel4.TabIndex = 56;
            this.bunifuCustomLabel4.Text = "Contact no.:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 171);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(130, 29);
            this.bunifuCustomLabel2.TabIndex = 52;
            this.bunifuCustomLabel2.Text = "Full Name:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(36, 74);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 29);
            this.bunifuCustomLabel1.TabIndex = 50;
            this.bunifuCustomLabel1.Text = "Request ID:";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1646, 577);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(524, 166);
            this.bunifuFlatButton1.TabIndex = 49;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dtgReq
            // 
            this.dtgReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReq.Location = new System.Drawing.Point(730, 34);
            this.dtgReq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgReq.Name = "dtgReq";
            this.dtgReq.RowHeadersWidth = 51;
            this.dtgReq.Size = new System.Drawing.Size(1192, 1121);
            this.dtgReq.TabIndex = 50;
            // 
            // tbxReqID
            // 
            this.tbxReqID.Location = new System.Drawing.Point(45, 118);
            this.tbxReqID.Name = "tbxReqID";
            this.tbxReqID.Size = new System.Drawing.Size(594, 35);
            this.tbxReqID.TabIndex = 70;
            // 
            // tbxFullName
            // 
            this.tbxFullName.Location = new System.Drawing.Point(45, 228);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(594, 35);
            this.tbxFullName.TabIndex = 74;
            // 
            // tbxContactNo
            // 
            this.tbxContactNo.Location = new System.Drawing.Point(45, 452);
            this.tbxContactNo.Name = "tbxContactNo";
            this.tbxContactNo.Size = new System.Drawing.Size(594, 35);
            this.tbxContactNo.TabIndex = 75;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(45, 329);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(594, 35);
            this.tbxEmail.TabIndex = 76;
            // 
            // RequestUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgReq);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RequestUnit";
            this.Size = new System.Drawing.Size(1830, 1258);
            this.Load += new System.EventHandler(this.RequestUnit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnRequest;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.DataGridView dtgReq;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQty;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox tbxItemToReq;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxContactNo;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.TextBox tbxReqID;
    }
}
