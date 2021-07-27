
namespace Farmacia_Medic
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.txtlab = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.rdbcodigo = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dgprov = new System.Windows.Forms.DataGridView();
            this.cbolab = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgprov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 110;
            this.label1.Text = "REGISTRO PROVEEDOR";
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.BackColor = System.Drawing.Color.Transparent;
            this.lblLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLab.Location = new System.Drawing.Point(24, 231);
            this.lblLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(92, 17);
            this.lblLab.TabIndex = 127;
            this.lblLab.Text = "Laboratorio";
            // 
            // txtlab
            // 
            this.txtlab.Location = new System.Drawing.Point(121, 222);
            this.txtlab.Margin = new System.Windows.Forms.Padding(4);
            this.txtlab.Name = "txtlab";
            this.txtlab.Size = new System.Drawing.Size(229, 22);
            this.txtlab.TabIndex = 126;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(156, 403);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(100, 28);
            this.btnmodificar.TabIndex = 125;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(23, 400);
            this.bteliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(100, 28);
            this.bteliminar.TabIndex = 124;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(452, 403);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(349, 22);
            this.txtbuscar.TabIndex = 123;
            // 
            // rdbcodigo
            // 
            this.rdbcodigo.AutoSize = true;
            this.rdbcodigo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rdbcodigo.Location = new System.Drawing.Point(573, 375);
            this.rdbcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbcodigo.Name = "rdbcodigo";
            this.rdbcodigo.Size = new System.Drawing.Size(73, 21);
            this.rdbcodigo.TabIndex = 122;
            this.rdbcodigo.Text = "Codigo";
            this.rdbcodigo.UseVisualStyleBackColor = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbnombre.Checked = true;
            this.rdbnombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rdbnombre.Location = new System.Drawing.Point(483, 375);
            this.rdbnombre.Margin = new System.Windows.Forms.Padding(4);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(79, 21);
            this.rdbnombre.TabIndex = 121;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(323, 400);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 28);
            this.btnbuscar.TabIndex = 120;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(156, 339);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 119;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(24, 339);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(100, 28);
            this.btnnuevo.TabIndex = 118;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // dgprov
            // 
            this.dgprov.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprov.Location = new System.Drawing.Point(391, 94);
            this.dgprov.Margin = new System.Windows.Forms.Padding(4);
            this.dgprov.Name = "dgprov";
            this.dgprov.RowHeadersWidth = 51;
            this.dgprov.Size = new System.Drawing.Size(696, 273);
            this.dgprov.TabIndex = 117;
            // 
            // cbolab
            // 
            this.cbolab.FormattingEnabled = true;
            this.cbolab.Location = new System.Drawing.Point(221, 260);
            this.cbolab.Margin = new System.Windows.Forms.Padding(4);
            this.cbolab.Name = "cbolab";
            this.cbolab.Size = new System.Drawing.Size(160, 24);
            this.cbolab.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(24, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 17);
            this.label6.TabIndex = 115;
            this.label6.Text = "Laboratorio Registrados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(24, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "Telefono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "Direccion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "Nit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 111;
            this.label2.Text = "Nombre :";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(121, 190);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(229, 22);
            this.txttelefono.TabIndex = 109;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(121, 158);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(229, 22);
            this.txtdireccion.TabIndex = 108;
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(121, 126);
            this.txtnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(229, 22);
            this.txtnit.TabIndex = 107;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(121, 94);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(229, 22);
            this.txtnombre.TabIndex = 106;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(369, 39);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(164, 22);
            this.txtcodigo.TabIndex = 105;
            this.txtcodigo.Visible = false;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1121, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.txtlab);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.rdbcodigo);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgprov);
            this.Controls.Add(this.cbolab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Name = "frmProveedor";
            this.Text = "frmProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgprov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.TextBox txtlab;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.RadioButton rdbcodigo;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dgprov;
        private System.Windows.Forms.ComboBox cbolab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
    }
}