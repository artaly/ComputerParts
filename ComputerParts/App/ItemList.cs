using MySql.Data.MySqlClient;
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
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;
        public DataTable dt;

        protected void FillDataGridView()
        {
            /*BindingSource bs = new BindingSource();
            bs.DataSource = ConnectandReadList("SELECT `ItemID`,`Barcode`,`Parts`,`Brand`, `Quantity`, i.`Description`,`Location`, `ComputerSet`,`Status` FROM `tblbrand` b,`tblitems` i, `tblparts`  p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID");
            dtgList.DataSource = bs;
            bs.ResetBindings(false);*/
            config.Load_DTG("SELECT `ItemID`,`Barcode`,`Parts`,`Brand`, `Quantity`, i.`Description`,`Location`, `ComputerSet`,`Status` FROM `tblbrand` b,`tblitems` i, `tblparts`  p, `tbllocation` l, tblcompset c WHERE b.`BrandID`= i.`BrandID` AND i.`PartsID`= p.`PartsID` AND i.`LocationID`= l.`LocationID` AND i.CompSetID = c.CompSetID", dtgList);


        }

        public DataTable ConnectandReadList(string query)
        {
            DataTable ds = new DataTable();
            using (var myConnection = new MySqlConnection("server=localhost;user id=root;database=dbmonitoring;sslMode=none"))
            {
                myConnection.Open();
                var cmd = new MySqlCommand(query, myConnection);
                var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            return ds;
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            //txtSearch_TextChanged(sender, e);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  ItemID, `Barcode`,`Parts`,`Brand`, `Quantity`,i.`Description`,`Location`, `ComputerSet`,Status "
                + " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID "
                + "AND (Status Like '%" + ComboBox1.Text + "%')";
            config.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT  ItemID, `Barcode`,`Parts`,`Brand`,`Quantity`, i.`Description`,`Location`, `ComputerSet`,Status "
                + " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID "
                + "AND (Barcode Like '%" + txtSearch.Text + "%' OR Parts Like '%"
                + txtSearch.Text + "%' OR Brand Like '%" + txtSearch.Text + "%' OR i.Description Like '%"
                + txtSearch.Text + "%' OR Location Like '%" + txtSearch.Text + "%')";
            config.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;
        }

    }   
}
