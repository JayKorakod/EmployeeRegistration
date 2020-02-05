using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeRegistration
{
    public partial class Regisform : Form
    {
        Employee model = new Employee();
        public Regisform()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtFN.Text = txtLN.Text = txtTel.Text = txtDepart.Text = txtSec.Text = txtAdd.Text 
                = txtSubDis.Text = txtDis.Text = txtProv.Text = txtPosCode.Text = txtSchool.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.EmployeeID = 0;
        }

        private void Regisform_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.Firstname = txtFN.Text.Trim();
            model.Lastname = txtLN.Text.Trim();
            model.Tel = txtTel.Text.Trim();
            model.Department = txtDepart.Text.Trim();
            model.Section = txtSec.Text.Trim();
            model.Address = txtAdd.Text.Trim();
            model.Subdistrict = txtSubDis.Text.Trim();
            model.District = txtDis.Text.Trim();
            model.Province = txtProv.Text.Trim();
            model.Postalcode = txtPosCode.Text.Trim();
            model.School = txtSchool.Text.Trim();
            using (DBEntities db = new DBEntities())
            {
                if (model.EmployeeID == 0) // Insert
                    db.Employees.Add(model);
                else // Update
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDateGridView();
            MessageBox.Show("Submit Success");
        }
        void PopulateDateGridView()
        {
            dgvEmployee.AutoGenerateColumns = false;
            using(DBEntities db = new DBEntities())
            {
                dgvEmployee.DataSource = db.Employees.ToList<Employee>();
            }
        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            if(dgvEmployee.CurrentRow.Index != -1) 
            {
                model.EmployeeID = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["EmployeeID"].Value);
                using(DBEntities db = new DBEntities())
                {
                    model = db.Employees.Where(x => x.EmployeeID == model.EmployeeID).FirstOrDefault();
                    txtFN.Text = model.Firstname;
                    txtLN.Text = model.Lastname;
                    txtTel.Text = model.Tel;
                    txtDepart.Text = model.Department;
                    txtSec.Text = model.Section;
                    txtAdd.Text = model.Address;
                    txtSubDis.Text = model.Subdistrict;
                    txtDis.Text = model.District;
                    txtProv.Text = model.Province;
                    txtPosCode.Text = model.Postalcode;
                    txtSchool.Text = model.School;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to Delete ?","Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Employees.Attach(model);
                    db.Employees.Remove(model);
                    db.SaveChanges();
                    PopulateDateGridView();
                    Clear();
                    MessageBox.Show("Delete Success");
                }
            }
        }
    }
}
