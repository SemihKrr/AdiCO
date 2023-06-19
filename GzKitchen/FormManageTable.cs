using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace GzKitchen
{
    public partial class FormManageTable : UserControl
    {
        private GzKitchenEntities db = new GzKitchenEntities();
        private byte[] selectedPictureByteArray = new byte[] { };
        private int selectedID = 0;
        private string saveButtonState = "add";

        public FormManageTable()
        {
            InitializeComponent();
        }


        private void FormManageMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvMenu.Columns.Clear();

            var query = db.Orders.ToList().Select(x => new
            {
                x.ID,
                //
                // Convert ByteArray to Bitmap
                //
                Picture = new Bitmap(new MemoryStream(x.Picture)),
                x.TableNo,
            }).ToList();

            dgvMenu.DataSource = query;
            dgvMenu.Columns["ID"].Visible = false;
            ((DataGridViewImageColumn)dgvMenu.Columns["Picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            var btnEditColumn = new DataGridViewButtonColumn();
            btnEditColumn.Name = "Edit";
            btnEditColumn.HeaderText = "Edit";
            btnEditColumn.Text = "Edit";
            btnEditColumn.UseColumnTextForButtonValue = true;

            var btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.Name = "Delete";
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;

            dgvMenu.Columns.Add(btnEditColumn);
            dgvMenu.Columns.Add(btnDeleteColumn);

            txtName.Text = "";
            selectedID = 0;
            selectedPictureByteArray = new byte[] { };
            picBoxPicture.ImageLocation = Application.StartupPath + "/Assets/Select Image.png";
            saveButtonState = "add";

            txtName.Focus();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (new FieldsValidator().IsAllTextBoxFilled(Controls))
            {
                if (txtName.Text != "")
                {
                    if (selectedPictureByteArray.Length > 0)
                    {
                        if (saveButtonState == "add")
                        {
                            db.Orders.Add(new Order
                            {
                                TableNo = txtName.Text,
                                Picture = selectedPictureByteArray,
                            });

                            db.SaveChanges();
                            LoadData();
                        }
                        else
                        {
                            var query = db.Orders.Find(selectedID);
                            query.TableNo = txtName.Text;
                            query.Picture = selectedPictureByteArray;

                            db.SaveChanges();
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a picture ...");
                    }
                }
                else
                {
                    MessageBox.Show("Price is not valid ...");
                }

            }
            else
            {
                MessageBox.Show("Fill all the fields ...");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMenu.CurrentRow.Cells;
                selectedID = int.Parse(row["ID"].Value.ToString());

                if (e.ColumnIndex == dgvMenu.Columns["Edit"].Index)
                {
                    txtName.Text = row["TableNo"].Value.ToString();

                    var selectedBitmap = (Bitmap)row["Picture"].Value;
                    picBoxPicture.Image = selectedBitmap;

                    using (var stream = new MemoryStream())
                    {
                        selectedBitmap.Save(stream, ImageFormat.Jpeg);
                        selectedPictureByteArray = stream.ToArray();
                    }

                    saveButtonState = "edit";
                }
                else if (e.ColumnIndex == dgvMenu.Columns["Delete"].Index)
                {
                    var confirmationDialog = MessageBox.Show("Are you sure want to delete this ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmationDialog == DialogResult.Yes)
                    {
                        var query = db.Orders.Find(selectedID);
                        db.Orders.Remove(query);

                        db.SaveChanges();
                    }

                    LoadData();
                }
            }
        }

        private void picBoxPicture_Click(object sender, EventArgs e)
        {
            var openFD = new OpenFileDialog()
            {
                Filter = "Images Files (*.jpg; *.png; *.gif; *.jpeg; *.bmp;)|*.jpg; *.png; *.gif; *.jpeg; *.bmp;"
            };

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                picBoxPicture.ImageLocation = openFD.FileName;
                var bitmap = new Bitmap(openFD.FileName);
                using (var stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Jpeg);
                    selectedPictureByteArray = stream.ToArray();
                }
            }
        }
    }
}
