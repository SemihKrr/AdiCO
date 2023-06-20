using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GzKitchen
{
    public partial class FormNavigationTable : Form
    {
        private GzKitchenEntities db = new GzKitchenEntities();
        public int cashierID = 0;
        public List<OrderedMenu> listOrderedMenu = new List<OrderedMenu>();

        public FormNavigationTable()
        {
            InitializeComponent();
        }



        private void FormNavigationTable_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            LoadTable();
            LoadCashierInfo();
        }

        private void LoadTable()
        {
            panelMenuList.Controls.Clear();

            var query = db.Orders.ToList().Where(x => txtSearch.Text != "" ? (x.TableNo.ToLower().Contains(txtSearch.Text.ToLower())) : true).ToList();

            var rowIncrement = 0;
            var columnIncrement = 0;
            for (int i = 0; i < query.Count; i++)
            {
                var menu = query[i];

                if((i + 1) % 6 == 0)
                {
                    // Ganti Row
                    rowIncrement++;
                    columnIncrement = 0;
                }

                var panelMenu = new Panel();
                panelMenu.Name = menu.ID.ToString();
                panelMenu.BackColor = Color.FromArgb(253, 253, 253);
                panelMenu.Size = new Size(140, 180);
                panelMenu.Location = new Point(12 + (columnIncrement * 140) + (columnIncrement * 16), 12 + (rowIncrement * 180) + (rowIncrement * 16));
                panelMenu.Cursor = Cursors.Hand;

                var picBox = new PictureBox();
                picBox.Name = menu.ID.ToString();
                using (var stream = new MemoryStream(menu.Picture))
                {
                    picBox.Image = new Bitmap(stream);
                }
                picBox.Size = new Size(80, 80);
                picBox.Location = new Point(30, 30);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Click += PicBoxMenu_Click;

                var lblMenuName = new Label();
                lblMenuName.Name = menu.ID.ToString();
                lblMenuName.Text = menu.TableNo;
                lblMenuName.TextAlign = ContentAlignment.MiddleCenter;
                lblMenuName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                lblMenuName.Size = new Size(140, 30);
                lblMenuName.Location = new Point(0, 122);
                lblMenuName.Click += LblMenuInfo_Click;


                panelMenu.Controls.Add(picBox);
                panelMenu.Controls.Add(lblMenuName);

                panelMenu.Click += PanelMenu_Click;

                panelMenuList.Controls.Add(panelMenu);

                columnIncrement++;
            }
        }

        private void LblMenuInfo_Click(object sender, EventArgs e)
        {
            var selectedMenuID = int.Parse(((Label)sender).Name);
            this.Hide();
            new FormNavigationCashier()
            {
                tableId = selectedMenuID,
                cashierID = cashierID,
            }.Show();
        }

        private void PicBoxMenu_Click(object sender, EventArgs e)
        {
            var selectedMenuID = int.Parse(((PictureBox)sender).Name);
            this.Hide();
            new FormNavigationCashier()
            {
                tableId = selectedMenuID,
                cashierID=cashierID,
            }.Show();
        }

        private void PanelMenu_Click(object sender, EventArgs e)
        {
            var selectedMenuID = int.Parse(((Panel)sender).Name);
            this.Hide();
            new FormNavigationCashier()
            {
                tableId = selectedMenuID,
                cashierID = cashierID,
            }.Show();
        }

        private void AddOrderedMenu(int selectedMenuID)
        {
            // Cek apakah sudah ada menu tersebut di ListOrderedMenu
            //if(listOrderedMenu.Where(x => x.MenuID == selectedMenuID).ToList().Count > 0)
            //{
            //    var menuIndex = listOrderedMenu.FindIndex(x => x.MenuID == selectedMenuID);
            //    listOrderedMenu[menuIndex].Qty += 1;
            //}
            //else
            //{
            //    listOrderedMenu.Add(new OrderedMenu
            //    {
            //        MenuID = selectedMenuID,
            //        Qty = 1
            //    });
            //}

            //LoadOrderedMenu();
        }

        public void LoadOrderedMenu()
        {
            //panelOrderedMenu.Controls.Clear();

            //var totalPrice = 0;
            //for (int i = 0; i < listOrderedMenu.Count; i++)
            //{
            //    var menuID = listOrderedMenu[i].MenuID;
            //    var menu = db.Menus.Where(x => x.ID == menuID).ToList()[0];

            //    var orderedMenuItem = new OrderedMenuLayout()
            //    {
            //        Location = new Point(0, 0 + (i * 84)),
            //        menu = menu,
            //        listOrderedMenu = listOrderedMenu,
            //        navCashier = this,
            //        i = i
            //    };

            //    totalPrice += menu.Price * listOrderedMenu[i].Qty;
            //    panelOrderedMenu.Controls.Add(orderedMenuItem);
            //}

            //txtTotal.Text = totalPrice.ToString("C");
        }

        private void LoadCashierInfo()
        {
            db = new GzKitchenEntities();

            var query = db.Accounts.Where(x => x.ID == cashierID).ToList();
            lblCashierName.Text = query[0].Name;
            lblCashierEmail.Text = query[0].Email;
        }

        private void lblCashierName_Click(object sender, EventArgs e)
        {
            new FormEditProfile()
            {
                accountID = cashierID
            }.ShowDialog();

            LoadCashierInfo();
        }

        
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            LoadTable();
        }

        private void picBoxCashier_Click(object sender, EventArgs e)
        {
            lblCashierName_Click(sender, e);
        }

        private void lblCashierEmail_Click(object sender, EventArgs e)
        {
            lblCashierName_Click(sender, e);
        }

        private void FormNavigationCashier_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FormLogin();
            frm.ShowDialog();
        }
    }

    //public class OrderedMenu
    //{
    //    public int MenuID { get; set; }
    //    public int Qty { get; set; }
    //}
}
