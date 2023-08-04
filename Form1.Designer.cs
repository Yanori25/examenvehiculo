
namespace ExamenVehiculo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvroles = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfillmarca = new System.Windows.Forms.TextBox();
            this.grpopciones = new System.Windows.Forms.GroupBox();
            this.txtactivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.Marca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfilmodelo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(79, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(251, 20);
            this.txtid.TabIndex = 1;
            // 
            // dgvroles
            // 
            this.dgvroles.BackgroundColor = System.Drawing.Color.White;
            this.dgvroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroles.Location = new System.Drawing.Point(21, 81);
            this.dgvroles.Name = "dgvroles";
            this.dgvroles.Size = new System.Drawing.Size(621, 177);
            this.dgvroles.TabIndex = 2;
            this.dgvroles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvroles_CellClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(251, 129);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(108, 27);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseCompatibleTextRendering = true;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(50, 129);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(108, 27);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseCompatibleTextRendering = true;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtfilmodelo);
            this.groupBox1.Controls.Add(this.btnpdf);
            this.groupBox1.Controls.Add(this.btnexcel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfillmarca);
            this.groupBox1.Controls.Add(this.dgvroles);
            this.groupBox1.Location = new System.Drawing.Point(40, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 264);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista vehiculos";
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(222, 47);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(108, 27);
            this.btnpdf.TabIndex = 13;
            this.btnpdf.Text = "Exportar a pdf";
            this.btnpdf.UseCompatibleTextRendering = true;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(88, 47);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(108, 27);
            this.btnexcel.TabIndex = 12;
            this.btnexcel.Text = "Exportar a excel";
            this.btnexcel.UseCompatibleTextRendering = true;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca";
            // 
            // txtfillmarca
            // 
            this.txtfillmarca.Location = new System.Drawing.Point(108, 19);
            this.txtfillmarca.Name = "txtfillmarca";
            this.txtfillmarca.Size = new System.Drawing.Size(222, 20);
            this.txtfillmarca.TabIndex = 3;
            this.txtfillmarca.TextChanged += new System.EventHandler(this.txtfillmarca_TextChanged);
            // 
            // grpopciones
            // 
            this.grpopciones.Controls.Add(this.txtactivo);
            this.grpopciones.Controls.Add(this.label6);
            this.grpopciones.Controls.Add(this.txtanio);
            this.grpopciones.Controls.Add(this.label5);
            this.grpopciones.Controls.Add(this.label3);
            this.grpopciones.Controls.Add(this.txtmodelo);
            this.grpopciones.Controls.Add(this.label4);
            this.grpopciones.Controls.Add(this.txtdescripcion);
            this.grpopciones.Controls.Add(this.Marca);
            this.grpopciones.Controls.Add(this.txtmarca);
            this.grpopciones.Controls.Add(this.btneditar);
            this.grpopciones.Controls.Add(this.label1);
            this.grpopciones.Controls.Add(this.txtid);
            this.grpopciones.Controls.Add(this.btneliminar);
            this.grpopciones.Controls.Add(this.btnagregar);
            this.grpopciones.Location = new System.Drawing.Point(40, 12);
            this.grpopciones.Name = "grpopciones";
            this.grpopciones.Size = new System.Drawing.Size(677, 174);
            this.grpopciones.TabIndex = 18;
            this.grpopciones.TabStop = false;
            this.grpopciones.Text = "opciones";
            // 
            // txtactivo
            // 
            this.txtactivo.Location = new System.Drawing.Point(420, 74);
            this.txtactivo.Name = "txtactivo";
            this.txtactivo.Size = new System.Drawing.Size(251, 20);
            this.txtactivo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Activo";
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(79, 74);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(251, 20);
            this.txtanio.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Modelo";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(420, 48);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(251, 20);
            this.txtmodelo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripcion";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(420, 19);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(251, 20);
            this.txtdescripcion.TabIndex = 17;
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(18, 55);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 14;
            this.Marca.Text = "Marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(79, 48);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(251, 20);
            this.txtmarca.TabIndex = 15;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(390, 129);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(108, 27);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "Editar";
            this.btneditar.UseCompatibleTextRendering = true;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Modelo";
            // 
            // txtfilmodelo
            // 
            this.txtfilmodelo.Location = new System.Drawing.Point(420, 19);
            this.txtfilmodelo.Name = "txtfilmodelo";
            this.txtfilmodelo.Size = new System.Drawing.Size(222, 20);
            this.txtfilmodelo.TabIndex = 15;
            this.txtfilmodelo.TextChanged += new System.EventHandler(this.txtfilmodelo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpopciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvroles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpopciones.ResumeLayout(false);
            this.grpopciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvroles;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfillmarca;
        private System.Windows.Forms.GroupBox grpopciones;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txtactivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfilmodelo;
    }
}

