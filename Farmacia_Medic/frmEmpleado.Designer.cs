﻿
namespace Farmacia_Medic
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgempleado = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(33, 444);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(126, 20);
            this.txtcodigo.TabIndex = 126;
            this.txtcodigo.Visible = false;
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(580, 116);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 125;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(580, 171);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 124;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(489, 171);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 23);
            this.btmodificar.TabIndex = 123;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = true;
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(398, 171);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(75, 23);
            this.btguardar.TabIndex = 122;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(307, 172);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnuevo.TabIndex = 121;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton2.Location = new System.Drawing.Point(506, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 120;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Codigo";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton1.Location = new System.Drawing.Point(424, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 119;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(304, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 118;
            this.label9.Text = "Buscar por :";
            // 
            // dgempleado
            // 
            this.dgempleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgempleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgempleado.BackgroundColor = System.Drawing.Color.Black;
            this.dgempleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgempleado.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgempleado.Location = new System.Drawing.Point(33, 243);
            this.dgempleado.Name = "dgempleado";
            this.dgempleado.RowHeadersVisible = false;
            this.dgempleado.RowHeadersWidth = 51;
            this.dgempleado.Size = new System.Drawing.Size(620, 196);
            this.dgempleado.TabIndex = 117;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(307, 119);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(257, 20);
            this.txtbuscar.TabIndex = 116;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(123, 198);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(155, 20);
            this.txttelefono.TabIndex = 115;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(123, 170);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(155, 20);
            this.txtdireccion.TabIndex = 114;
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(123, 143);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(155, 20);
            this.txtmaterno.TabIndex = 113;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(123, 117);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(155, 20);
            this.txtpaterno.TabIndex = 112;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(123, 90);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(155, 20);
            this.txtnombre.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(30, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 110;
            this.label7.Text = "Telefono :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(30, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 109;
            this.label6.Text = "Direccion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 108;
            this.label4.Text = "Materno :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 107;
            this.label3.Text = "Paterno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(236, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 105;
            this.label1.Text = "REGISTRO EMPLEADO";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 489);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgempleado);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgempleado;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}