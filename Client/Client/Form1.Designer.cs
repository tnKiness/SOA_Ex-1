namespace Client
{
    partial class Form1
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
            this.lb_CountryCode = new System.Windows.Forms.Label();
            this.lb_CityName = new System.Windows.Forms.Label();
            this.txb_CountryCode = new System.Windows.Forms.TextBox();
            this.txb_CityName = new System.Windows.Forms.TextBox();
            this.btn_GetAllCountry = new System.Windows.Forms.Button();
            this.btn_GetCountryByCode = new System.Windows.Forms.Button();
            this.btn_GetCityByName = new System.Windows.Forms.Button();
            this.btn_GetAllCityOfCountry = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CountryCode
            // 
            this.lb_CountryCode.AutoSize = true;
            this.lb_CountryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CountryCode.Location = new System.Drawing.Point(32, 26);
            this.lb_CountryCode.Name = "lb_CountryCode";
            this.lb_CountryCode.Size = new System.Drawing.Size(116, 20);
            this.lb_CountryCode.TabIndex = 0;
            this.lb_CountryCode.Text = "Country Code:";
            // 
            // lb_CityName
            // 
            this.lb_CityName.AutoSize = true;
            this.lb_CityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CityName.Location = new System.Drawing.Point(32, 75);
            this.lb_CityName.Name = "lb_CityName";
            this.lb_CityName.Size = new System.Drawing.Size(92, 20);
            this.lb_CityName.TabIndex = 1;
            this.lb_CityName.Text = "City Name:";
            // 
            // txb_CountryCode
            // 
            this.txb_CountryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CountryCode.Location = new System.Drawing.Point(154, 23);
            this.txb_CountryCode.Name = "txb_CountryCode";
            this.txb_CountryCode.Size = new System.Drawing.Size(607, 27);
            this.txb_CountryCode.TabIndex = 2;
            this.txb_CountryCode.TextChanged += new System.EventHandler(this.txb_CountryCode_TextChanged);
            // 
            // txb_CityName
            // 
            this.txb_CityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CityName.Location = new System.Drawing.Point(154, 72);
            this.txb_CityName.Name = "txb_CityName";
            this.txb_CityName.Size = new System.Drawing.Size(607, 27);
            this.txb_CityName.TabIndex = 3;
            this.txb_CityName.TextChanged += new System.EventHandler(this.txb_CityName_TextChanged);
            // 
            // btn_GetAllCountry
            // 
            this.btn_GetAllCountry.Location = new System.Drawing.Point(32, 122);
            this.btn_GetAllCountry.Name = "btn_GetAllCountry";
            this.btn_GetAllCountry.Size = new System.Drawing.Size(161, 41);
            this.btn_GetAllCountry.TabIndex = 5;
            this.btn_GetAllCountry.Text = "Get All Countries";
            this.btn_GetAllCountry.UseVisualStyleBackColor = true;
            this.btn_GetAllCountry.Click += new System.EventHandler(this.btn_GetAllCountry_Click);
            // 
            // btn_GetCountryByCode
            // 
            this.btn_GetCountryByCode.Location = new System.Drawing.Point(223, 122);
            this.btn_GetCountryByCode.Name = "btn_GetCountryByCode";
            this.btn_GetCountryByCode.Size = new System.Drawing.Size(161, 41);
            this.btn_GetCountryByCode.TabIndex = 6;
            this.btn_GetCountryByCode.Text = "Get Country By Code";
            this.btn_GetCountryByCode.UseVisualStyleBackColor = true;
            this.btn_GetCountryByCode.Click += new System.EventHandler(this.btn_GetCountryByCode_Click);
            // 
            // btn_GetCityByName
            // 
            this.btn_GetCityByName.Location = new System.Drawing.Point(412, 122);
            this.btn_GetCityByName.Name = "btn_GetCityByName";
            this.btn_GetCityByName.Size = new System.Drawing.Size(161, 41);
            this.btn_GetCityByName.TabIndex = 7;
            this.btn_GetCityByName.Text = "Get City By Name";
            this.btn_GetCityByName.UseVisualStyleBackColor = true;
            this.btn_GetCityByName.Click += new System.EventHandler(this.getCityByName_Click);
            // 
            // btn_GetAllCityOfCountry
            // 
            this.btn_GetAllCityOfCountry.Location = new System.Drawing.Point(601, 122);
            this.btn_GetAllCityOfCountry.Name = "btn_GetAllCityOfCountry";
            this.btn_GetAllCityOfCountry.Size = new System.Drawing.Size(161, 42);
            this.btn_GetAllCityOfCountry.TabIndex = 8;
            this.btn_GetAllCityOfCountry.Text = "Get All Cities Of Country";
            this.btn_GetAllCityOfCountry.UseVisualStyleBackColor = true;
            this.btn_GetAllCityOfCountry.Click += new System.EventHandler(this.btn_GetAllCityOfCountry_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(31, 183);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(730, 255);
            this.dgvResults.TabIndex = 10;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btn_GetAllCityOfCountry);
            this.Controls.Add(this.btn_GetCityByName);
            this.Controls.Add(this.btn_GetCountryByCode);
            this.Controls.Add(this.btn_GetAllCountry);
            this.Controls.Add(this.txb_CityName);
            this.Controls.Add(this.txb_CountryCode);
            this.Controls.Add(this.lb_CityName);
            this.Controls.Add(this.lb_CountryCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CountryCode;
        private System.Windows.Forms.Label lb_CityName;
        private System.Windows.Forms.TextBox txb_CountryCode;
        private System.Windows.Forms.TextBox txb_CityName;
        private System.Windows.Forms.Button btn_GetAllCountry;
        private System.Windows.Forms.Button btn_GetCountryByCode;
        private System.Windows.Forms.Button btn_GetCityByName;
        private System.Windows.Forms.Button btn_GetAllCityOfCountry;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}

