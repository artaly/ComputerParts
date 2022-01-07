using ComputerParts.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerParts.Forms
{
    public partial class UserDashboard : Form
    {
        private ItemList itemList;
        private RequestUnit requestUnit;

        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnResetColor()
        {
            this.btnItemList.Normalcolor = Color.Transparent;
            this.btnRequestUnit.Normalcolor = Color.Transparent;
        }

        internal void togglePanelMain(string panelName)
        {
            this.btnResetColor();
            this.panel_main.Controls.Clear();
            switch (panelName)
            {
                /*case "transferItem":
                    if (this.transferItem == null)
                    {
                        this.transferItem = new TransferItem();
                        this.panel_main.Controls.Add(transferItem);
                        this.transferItem.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.transferItem.Location = new System.Drawing.Point(0, 0);
                        this.transferItem.Name = "transferItem";
                        this.transferItem.Size = new System.Drawing.Size(1177, 908);
                        this.transferItem.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(transferItem);
                    }
                    this.btnTransfer.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;*/
                case "itemList":
                    if (this.itemList == null)
                    {
                        this.itemList = new ItemList();
                        this.panel_main.Controls.Add(itemList);
                        this.itemList.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.itemList.Location = new System.Drawing.Point(0, 0);
                        this.itemList.Name = "itemList";
                        this.itemList.Size = new System.Drawing.Size(1627, 1006);
                        this.itemList.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(itemList);
                    }
                    this.btnItemList.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                case "requestUnit":
                    if (this.requestUnit == null)
                    {
                        this.requestUnit = new RequestUnit();
                        this.panel_main.Controls.Add(requestUnit);
                        this.requestUnit.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.requestUnit.Location = new System.Drawing.Point(0, 0);
                        this.requestUnit.Name = "requestUnit";
                        this.requestUnit.Size = new System.Drawing.Size(1627, 1006);
                        this.requestUnit.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(requestUnit);
                    }
                    this.btnRequestUnit.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                /*
        case "genetic":
            if (this.uCGenetic == null)
            {
                this.uCGenetic = new UCGenetic();
                this.panel_main.Controls.Add(uCGenetic);
                this.uCGenetic.Dock = System.Windows.Forms.DockStyle.Fill;
                this.uCGenetic.Location = new System.Drawing.Point(0, 0);
                this.uCGenetic.Name = "uCGenetic";
                this.uCGenetic.Size = new System.Drawing.Size(250, 776);
                this.uCGenetic.TabIndex = 0;
            }
            else
            {
                this.panel_main.Controls.Add(uCGenetic);
            }
            this.btn_genetic.Normalcolor = Color.FromArgb(15, 25, 33);
            break;*/
                default:
                    break;
            }
        }


        private void btnItemList_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btnItemList.Location.X, btnItemList.Location.Y);
            this.togglePanelMain("itemList");
        }

        private void btnRequestUnit_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btnRequestUnit.Location.X, btnRequestUnit.Location.Y);
            this.togglePanelMain("requestUnit");
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            timerDash.Enabled = true;
            this.togglePanelMain("itemList");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
