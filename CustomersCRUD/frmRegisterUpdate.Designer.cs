
namespace CustomersCRUD
{
    partial class frmRegisterUpdate
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
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lbPostalCode = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbRegion = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.lbContactName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lbContactTitle = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFax = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(75, 36);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(210, 33);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 21);
            this.txtID.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(210, 305);
            this.txtCity.MaxLength = 15;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 21);
            this.txtCity.TabIndex = 3;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(75, 308);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(38, 16);
            this.lbCity.TabIndex = 2;
            this.lbCity.Text = "City:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(566, 128);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(155, 21);
            this.txtPostalCode.TabIndex = 5;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(75, 251);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(70, 16);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Address:";
            // 
            // txtRegion
            // 
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(566, 72);
            this.txtRegion.MaxLength = 15;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(155, 21);
            this.txtRegion.TabIndex = 7;
            // 
            // lbPostalCode
            // 
            this.lbPostalCode.AutoSize = true;
            this.lbPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostalCode.Location = new System.Drawing.Point(451, 131);
            this.lbPostalCode.Name = "lbPostalCode";
            this.lbPostalCode.Size = new System.Drawing.Size(97, 16);
            this.lbPostalCode.TabIndex = 6;
            this.lbPostalCode.Text = "Postal Code:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(210, 232);
            this.txtAddress.MaxLength = 60;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 48);
            this.txtAddress.TabIndex = 9;
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegion.Location = new System.Drawing.Point(451, 75);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(62, 16);
            this.lbRegion.TabIndex = 8;
            this.lbRegion.Text = "Region:";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactTitle.Location = new System.Drawing.Point(210, 183);
            this.txtContactTitle.MaxLength = 30;
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(155, 21);
            this.txtContactTitle.TabIndex = 11;
            // 
            // lbContactName
            // 
            this.lbContactName.AutoSize = true;
            this.lbContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactName.Location = new System.Drawing.Point(75, 130);
            this.lbContactName.Name = "lbContactName";
            this.lbContactName.Size = new System.Drawing.Size(109, 16);
            this.lbContactName.TabIndex = 10;
            this.lbContactName.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            this.txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactName.Location = new System.Drawing.Point(210, 130);
            this.txtContactName.MaxLength = 30;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(155, 21);
            this.txtContactName.TabIndex = 13;
            // 
            // lbContactTitle
            // 
            this.lbContactTitle.AutoSize = true;
            this.lbContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContactTitle.Location = new System.Drawing.Point(75, 183);
            this.lbContactTitle.Name = "lbContactTitle";
            this.lbContactTitle.Size = new System.Drawing.Size(99, 16);
            this.lbContactTitle.TabIndex = 12;
            this.lbContactTitle.Text = "Contact Title:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(210, 77);
            this.txtCompanyName.MaxLength = 40;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(155, 21);
            this.txtCompanyName.TabIndex = 15;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.Location = new System.Drawing.Point(75, 77);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(122, 16);
            this.lbCompanyName.TabIndex = 14;
            this.lbCompanyName.Text = "Company Name:";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(566, 178);
            this.txtCountry.MaxLength = 15;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(155, 21);
            this.txtCountry.TabIndex = 17;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(451, 178);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(64, 16);
            this.lbCountry.TabIndex = 16;
            this.lbCountry.Text = "Country:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(451, 237);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(56, 16);
            this.lbPhone.TabIndex = 18;
            this.lbPhone.Text = "Phone:";
            // 
            // lbFax
            // 
            this.lbFax.AutoSize = true;
            this.lbFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFax.Location = new System.Drawing.Point(451, 285);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(37, 16);
            this.lbFax.TabIndex = 20;
            this.lbFax.Text = "Fax:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(566, 234);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(155, 21);
            this.txtPhone.TabIndex = 21;
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(566, 280);
            this.txtFax.MaxLength = 15;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(155, 21);
            this.txtFax.TabIndex = 22;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(290, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 59);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Pink;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(454, 366);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 59);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Clear";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmRegisterUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbFax);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.lbContactTitle);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.lbContactName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbRegion);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lbPostalCode);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Name = "frmRegisterUpdate";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.frmRegisterUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lbPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label lbContactName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lbContactTitle;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}