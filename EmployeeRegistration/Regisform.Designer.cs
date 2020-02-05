namespace EmployeeRegistration
{
    partial class Regisform
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubDis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPosCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subdistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.School = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(625, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.Firstname,
            this.Lastname,
            this.Tel,
            this.Department,
            this.Section,
            this.Address,
            this.Subdistrict,
            this.District,
            this.Province,
            this.Postalcode,
            this.School});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 340);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 30;
            this.dgvEmployee.Size = new System.Drawing.Size(923, 222);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.DoubleClick += new System.EventHandler(this.dgvEmployee_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firstname";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(133, 46);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(137, 22);
            this.txtFN.TabIndex = 3;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(133, 104);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(137, 22);
            this.txtLN.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lastname";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(133, 164);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(137, 22);
            this.txtTel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tel";
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(133, 226);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(137, 22);
            this.txtDepart.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Department";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(133, 286);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(137, 22);
            this.txtSec.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Section";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(741, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(849, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(423, 46);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(137, 22);
            this.txtAdd.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // txtSubDis
            // 
            this.txtSubDis.Location = new System.Drawing.Point(423, 104);
            this.txtSubDis.Name = "txtSubDis";
            this.txtSubDis.Size = new System.Drawing.Size(137, 22);
            this.txtSubDis.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sub-district";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(423, 164);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(137, 22);
            this.txtDis.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "District";
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(423, 226);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(137, 22);
            this.txtProv.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Province";
            // 
            // txtPosCode
            // 
            this.txtPosCode.Location = new System.Drawing.Point(423, 286);
            this.txtPosCode.Name = "txtPosCode";
            this.txtPosCode.Size = new System.Drawing.Size(137, 22);
            this.txtPosCode.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Postal Code";
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(685, 46);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(137, 22);
            this.txtSchool.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(591, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "School";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            this.EmployeeID.Width = 125;
            // 
            // Firstname
            // 
            this.Firstname.DataPropertyName = "Firstname";
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.MinimumWidth = 6;
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Width = 125;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.MinimumWidth = 6;
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 125;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 125;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 125;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.MinimumWidth = 6;
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            this.Section.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Subdistrict
            // 
            this.Subdistrict.DataPropertyName = "Subdistrict";
            this.Subdistrict.HeaderText = "Subdistrict";
            this.Subdistrict.MinimumWidth = 6;
            this.Subdistrict.Name = "Subdistrict";
            this.Subdistrict.ReadOnly = true;
            this.Subdistrict.Width = 125;
            // 
            // District
            // 
            this.District.DataPropertyName = "District";
            this.District.HeaderText = "District";
            this.District.MinimumWidth = 6;
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Width = 125;
            // 
            // Province
            // 
            this.Province.DataPropertyName = "Province";
            this.Province.HeaderText = "Province";
            this.Province.MinimumWidth = 6;
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            this.Province.Width = 125;
            // 
            // Postalcode
            // 
            this.Postalcode.DataPropertyName = "Postalcode";
            this.Postalcode.HeaderText = "Postalcode";
            this.Postalcode.MinimumWidth = 6;
            this.Postalcode.Name = "Postalcode";
            this.Postalcode.ReadOnly = true;
            this.Postalcode.Width = 125;
            // 
            // School
            // 
            this.School.DataPropertyName = "School";
            this.School.HeaderText = "School";
            this.School.MinimumWidth = 6;
            this.School.Name = "School";
            this.School.ReadOnly = true;
            this.School.Width = 125;
            // 
            // Regisform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 574);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPosCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubDis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnSave);
            this.Name = "Regisform";
            this.Text = "Employee Registration";
            this.Load += new System.EventHandler(this.Regisform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubDis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPosCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subdistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postalcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn School;
    }
}

