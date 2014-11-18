namespace DarkComet_Fucker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tblKeys = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpJuguetes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tblInfo = new System.Windows.Forms.DataGridView();
            this.btnRobarRemotos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRobar = new System.Windows.Forms.Button();
            this.txtRobar = new System.Windows.Forms.TextBox();
            this.cmbRobar = new System.Windows.Forms.ComboBox();
            this.btnFlood = new System.Windows.Forms.Button();
            this.colInfoKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfoValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblKeys)).BeginInit();
            this.grpJuguetes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(53, 15);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(211, 20);
            this.txtRuta.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(270, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 22);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tblKeys
            // 
            this.tblKeys.AllowUserToAddRows = false;
            this.tblKeys.AllowUserToDeleteRows = false;
            this.tblKeys.AllowUserToResizeColumns = false;
            this.tblKeys.AllowUserToResizeRows = false;
            this.tblKeys.BackgroundColor = System.Drawing.Color.White;
            this.tblKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKeys.ColumnHeadersVisible = false;
            this.tblKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colValue});
            this.tblKeys.Location = new System.Drawing.Point(15, 53);
            this.tblKeys.MultiSelect = false;
            this.tblKeys.Name = "tblKeys";
            this.tblKeys.ReadOnly = true;
            this.tblKeys.RowHeadersVisible = false;
            this.tblKeys.RowTemplate.ReadOnly = true;
            this.tblKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblKeys.Size = new System.Drawing.Size(321, 102);
            this.tblKeys.TabIndex = 3;
            // 
            // colKey
            // 
            this.colKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // grpJuguetes
            // 
            this.grpJuguetes.Controls.Add(this.groupBox1);
            this.grpJuguetes.Controls.Add(this.btnRobarRemotos);
            this.grpJuguetes.Controls.Add(this.groupBox2);
            this.grpJuguetes.Controls.Add(this.btnFlood);
            this.grpJuguetes.Enabled = false;
            this.grpJuguetes.Location = new System.Drawing.Point(15, 161);
            this.grpJuguetes.Name = "grpJuguetes";
            this.grpJuguetes.Size = new System.Drawing.Size(321, 265);
            this.grpJuguetes.TabIndex = 4;
            this.grpJuguetes.TabStop = false;
            this.grpJuguetes.Text = "Juguetes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.tblInfo);
            this.groupBox1.Location = new System.Drawing.Point(10, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(6, 19);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(126, 19);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "OBTENER";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // tblInfo
            // 
            this.tblInfo.AllowUserToAddRows = false;
            this.tblInfo.AllowUserToDeleteRows = false;
            this.tblInfo.AllowUserToResizeColumns = false;
            this.tblInfo.AllowUserToResizeRows = false;
            this.tblInfo.BackgroundColor = System.Drawing.Color.White;
            this.tblInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblInfo.ColumnHeadersVisible = false;
            this.tblInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfoKey,
            this.colInfoValue});
            this.tblInfo.GridColor = System.Drawing.Color.White;
            this.tblInfo.Location = new System.Drawing.Point(6, 44);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowHeadersVisible = false;
            this.tblInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblInfo.Size = new System.Drawing.Size(296, 118);
            this.tblInfo.TabIndex = 0;
            // 
            // btnRobarRemotos
            // 
            this.btnRobarRemotos.Location = new System.Drawing.Point(193, 19);
            this.btnRobarRemotos.Name = "btnRobarRemotos";
            this.btnRobarRemotos.Size = new System.Drawing.Size(121, 19);
            this.btnRobarRemotos.TabIndex = 2;
            this.btnRobarRemotos.Text = "ROBAR REMOTOS";
            this.btnRobarRemotos.UseVisualStyleBackColor = true;
            this.btnRobarRemotos.Click += new System.EventHandler(this.btnRobarRemotos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRobar);
            this.groupBox2.Controls.Add(this.txtRobar);
            this.groupBox2.Controls.Add(this.cmbRobar);
            this.groupBox2.Location = new System.Drawing.Point(10, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Robar archivo";
            // 
            // btnRobar
            // 
            this.btnRobar.Enabled = false;
            this.btnRobar.Location = new System.Drawing.Point(246, 20);
            this.btnRobar.Name = "btnRobar";
            this.btnRobar.Size = new System.Drawing.Size(58, 19);
            this.btnRobar.TabIndex = 2;
            this.btnRobar.Text = "ROBAR";
            this.btnRobar.UseVisualStyleBackColor = true;
            this.btnRobar.Click += new System.EventHandler(this.btnRobar_Click);
            // 
            // txtRobar
            // 
            this.txtRobar.Enabled = false;
            this.txtRobar.Location = new System.Drawing.Point(103, 20);
            this.txtRobar.Name = "txtRobar";
            this.txtRobar.Size = new System.Drawing.Size(136, 20);
            this.txtRobar.TabIndex = 1;
            // 
            // cmbRobar
            // 
            this.cmbRobar.FormattingEnabled = true;
            this.cmbRobar.Location = new System.Drawing.Point(6, 19);
            this.cmbRobar.Name = "cmbRobar";
            this.cmbRobar.Size = new System.Drawing.Size(91, 21);
            this.cmbRobar.TabIndex = 0;
            this.cmbRobar.SelectedIndexChanged += new System.EventHandler(this.cmbRobar_SelectedIndexChanged);
            // 
            // btnFlood
            // 
            this.btnFlood.Location = new System.Drawing.Point(10, 19);
            this.btnFlood.Name = "btnFlood";
            this.btnFlood.Size = new System.Drawing.Size(108, 19);
            this.btnFlood.TabIndex = 0;
            this.btnFlood.Text = "START FLOOD";
            this.btnFlood.UseVisualStyleBackColor = true;
            this.btnFlood.Click += new System.EventHandler(this.btnFlood_Click);
            // 
            // colInfoKey
            // 
            this.colInfoKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInfoKey.HeaderText = "Key";
            this.colInfoKey.Name = "colInfoKey";
            // 
            // colInfoValue
            // 
            this.colInfoValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInfoValue.HeaderText = "Value";
            this.colInfoValue.Name = "colInfoValue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 430);
            this.Controls.Add(this.grpJuguetes);
            this.Controls.Add(this.tblKeys);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DarkComet Fucker by Blau";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tblKeys)).EndInit();
            this.grpJuguetes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView tblKeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.GroupBox grpJuguetes;
        public System.Windows.Forms.Button btnFlood;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRobar;
        private System.Windows.Forms.ComboBox cmbRobar;
        private System.Windows.Forms.Button btnRobar;
        private System.Windows.Forms.Button btnRobarRemotos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tblInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfoKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfoValue;
    }
}

