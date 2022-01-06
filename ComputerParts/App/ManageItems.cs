using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerParts.App
{
    public partial class ManageItems : UserControl
    {
        public ManageItems()
        {
            InitializeComponent();

        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxrow;


        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void ManageItems_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
            FillDataGridView();
        }

        private void gbxManageItems_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || txtDescription.Text == "")
            {
                funct.messagerequired();
            }

            sql = "SELECT * FROM `tblitems` WHERE `PartsID`=" + cboParts.SelectedValue +
                " AND `LocationID`=" + cboLocation.SelectedValue + " AND `CompSetID`=" + cboCompSet.SelectedValue;
            maxrow = config.maxrow(sql);
            if (maxrow > 0)
            {
                MessageBox.Show(cboParts.Text + " is already exist in the computer ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = "INSERT INTO `tblitems` (`Barcode`, `BrandID`, `Description`, `PartsID`, `RecievedDate`, `Quantity`, `LocationID`, `CompSetID`, `Status`) " +
         " VALUES ('" + txtBarcode.Text + "'," + cboBrand.SelectedValue + ",'" + txtDescription.Text + "'," + cboParts.SelectedValue + ",Date(Now()),1," + cboLocation.SelectedValue + "," +tbxQuantity + "," + cboCompSet.SelectedValue + ",'" + cboStatus.Text + "')";
                config.Execute_CUD(sql, "error to execute the query.", "New item created successfully.");
            }

            btnNew_Click(sender, e);
            FillDataGridView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(this);

            sql = "SELECT PartsID, Parts FROM tblparts";
            config.fiil_CBO(sql, cboParts);
            sql = "SELECT BrandID,  Brand FROM tblbrand";
            config.fiil_CBO(sql, cboBrand);
            sql = "SELECT  LocationID,Location FROM tbllocation";
            config.fiil_CBO(sql, cboLocation);
            sql = "SELECT  CompSetID,ComputerSet FROM tblcompset";
            config.fiil_CBO(sql, cboCompSet);
            config.Load_DTG("SELECT `Barcode`,`Parts`,`Brand`, `Quantity`, i.`Description`,`Location`, `ComputerSet`,`Status` FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID", dtg_listItems);
            ClearTextBoxes(this.Controls);
        }

        private void ClearTextBoxes(ControlCollection controls)
        {
            foreach (TextBox tb in controls.OfType<TextBox>())
                tb.Text = string.Empty;
            foreach (Control c in controls)
                ClearTextBoxes(c.Controls);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            sql = "UPDATE `tblitems` SET  `BrandID`='" + cboBrand.SelectedValue + "', `Description`='" + txtDescription.Text + "', `PartsID`=" + cboParts.SelectedValue + ", `Quantity`=" + tbxQuantity.Text + ", `LocationID`=" + cboLocation.SelectedValue + ", `CompSetID`=" + cboCompSet.SelectedValue + ", `Status`='" + cboStatus.Text + "' WHERE  `Barcode`='" + txtBarcode.Text + "'";
            config.Execute_CUD(sql, "error to execute the query.", "Item updated successfully.");
            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM tblitems  where Barcode = " + txtBarcode.Text;
            config.Execute_CUD(sql, "error to execute the query.", "Item has been deleted in the database.");
            btnNew_Click(sender, e);
            FillDataGridView();
        }

        protected void FillDataGridView()
        {
            config.Load_DTG("SELECT `Barcode`,`Parts`,`Brand`, `Quantity`, i.`Description`,`Location`, `ComputerSet`,`Status` FROM `tblbrand` b,`tblitems` i, `tblparts`  p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID", dtg_listItems);

        }

        private void dtg_listItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcode.Text = dtg_listItems.CurrentRow.Cells[0].Value.ToString();
            cboParts.Text = dtg_listItems.CurrentRow.Cells[1].Value.ToString();
            cboBrand.Text = dtg_listItems.CurrentRow.Cells[2].Value.ToString();
            tbxQuantity.Text = dtg_listItems.CurrentRow.Cells[3].Value.ToString();
            txtDescription.Text = dtg_listItems.CurrentRow.Cells[4].Value.ToString();
            cboLocation.Text = dtg_listItems.CurrentRow.Cells[5].Value.ToString();
            cboCompSet.Text = dtg_listItems.CurrentRow.Cells[6].Value.ToString();
            cboStatus.Text = dtg_listItems.CurrentRow.Cells[7].Value.ToString();
            
        }
    }
    }


