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

namespace ComputerParts
{
    public partial class Dashboard : Form
    {
        private TransferItem transferItem;
        private ManageUser manageUser;
        private ItemList itemList;
        private ManageItems manageItems;
        private RequestUnit requestUnit;



        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnResetColor()
        {
            //this.btnTransfer.Normalcolor = Color.Transparent;
            this.btnManageUsers.Normalcolor = Color.Transparent;
            this.btnItemList.Normalcolor = Color.Transparent;
            this.btnManageItems.Normalcolor = Color.Transparent;

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
               case "manageUser":
                    if (this.manageUser == null)
                    {
                        this.manageUser = new ManageUser();
                        this.panel_main.Controls.Add(manageUser);
                        this.manageUser.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.manageUser.Location = new System.Drawing.Point(0, 0);
                        this.manageUser.Name = "uCAnalytics";
                        this.manageUser.Size = new System.Drawing.Size(1627, 1006);
                        this.manageUser.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(manageUser);
                    }
                    this.btnManageUsers.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                    
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
                case "manageItems":
                    if (this.manageItems == null)
                    {
                        this.manageItems = new ManageItems();
                        this.panel_main.Controls.Add(manageItems);
                        this.manageItems.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.manageItems.Location = new System.Drawing.Point(0, 0);
                        this.manageItems.Name = "manageItems";
                        this.manageItems.Size = new System.Drawing.Size(1627, 1006);
                        this.manageItems.TabIndex = 0;
                    }
                    else
                    {
                        this.panel_main.Controls.Add(manageItems);
                    }
                    this.btnManageItems.Normalcolor = Color.FromArgb(15, 25, 33);
                    break;
                
            case "requestUnit":
                if (this.requestUnit == null)
                {
                    this.requestUnit = new RequestUnit();
                    this.panel_main.Controls.Add(requestUnit);
                    this.requestUnit.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.requestUnit.Location = new System.Drawing.Point(0, 0);
                    this.requestUnit.Name = "uCDemand";
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

        /*private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btnTransfer.Location.X, btnTransfer.Location.Y);
            this.togglePanelMain("transferItem");
        }*/
        private void btnItemList_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btnItemList.Location.X, btnItemList.Location.Y);
            this.togglePanelMain("itemList");
        }
        private void btnManageItems_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btnManageItems.Location.X, btnManageItems.Location.Y);
            this.togglePanelMain("manageItems");
        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btnManageUsers.Location.X, btnManageUsers.Location.Y);
            this.togglePanelMain("manageUser");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void timerDash_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            dshTime.Text = time.ToString("h:mm:ss tt");

            DateTime date = DateTime.Now;
            dshDate.Text = string.Format("{0:D}", date);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timerDash.Enabled = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnRequestUnit_Click(object sender, EventArgs e)
        {
            this.menu_active.Location = new Point(btnRequestUnit.Location.X, btnRequestUnit.Location.Y);
            this.togglePanelMain("requestUnit");
        }
    }
}
