namespace SISTEMA_DE_SUELDO_GAMAR_A2
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_afp = new System.Windows.Forms.Label();
            this.lbl_descuento_total = new System.Windows.Forms.Label();
            this.lbl_500porhijos = new System.Windows.Forms.Label();
            this.lbl_sfs = new System.Windows.Forms.Label();
            this.lbl_hijoscantidad = new System.Windows.Forms.Label();
            this.lbl_sueldoneto = new System.Windows.Forms.Label();
            this.lbl_tituloexpre = new System.Windows.Forms.Label();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.txt_sueldoneto = new System.Windows.Forms.TextBox();
            this.txt_cantidad_hijos = new System.Windows.Forms.TextBox();
            this.txt_500porhijo = new System.Windows.Forms.TextBox();
            this.txt_descuento_total = new System.Windows.Forms.TextBox();
            this.txt_descuento_sfs = new System.Windows.Forms.TextBox();
            this.txt_descuento_afp = new System.Windows.Forms.TextBox();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.lbl_segundotitulo = new System.Windows.Forms.Label();
            this.txt_sueldomas_incentivo = new System.Windows.Forms.TextBox();
            this.lbl_sueldoporhijo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Red;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(630, 462);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(128, 52);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_limpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(443, 462);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(130, 52);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_calcular.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btn_calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_calcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.Transparent;
            this.btn_calcular.Location = new System.Drawing.Point(542, 272);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(121, 53);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(357, 146);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(170, 23);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "NOMBRE COMPLETO";
            // 
            // lbl_afp
            // 
            this.lbl_afp.AutoSize = true;
            this.lbl_afp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_afp.ForeColor = System.Drawing.Color.White;
            this.lbl_afp.Location = new System.Drawing.Point(439, 372);
            this.lbl_afp.Name = "lbl_afp";
            this.lbl_afp.Size = new System.Drawing.Size(128, 20);
            this.lbl_afp.TabIndex = 5;
            this.lbl_afp.Text = "DESCUENTO (AFP)";
            // 
            // lbl_descuento_total
            // 
            this.lbl_descuento_total.AutoSize = true;
            this.lbl_descuento_total.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuento_total.ForeColor = System.Drawing.Color.White;
            this.lbl_descuento_total.Location = new System.Drawing.Point(820, 372);
            this.lbl_descuento_total.Name = "lbl_descuento_total";
            this.lbl_descuento_total.Size = new System.Drawing.Size(137, 20);
            this.lbl_descuento_total.TabIndex = 6;
            this.lbl_descuento_total.Text = "DESCUENTO TOTAL";
            // 
            // lbl_500porhijos
            // 
            this.lbl_500porhijos.AutoSize = true;
            this.lbl_500porhijos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_500porhijos.ForeColor = System.Drawing.Color.White;
            this.lbl_500porhijos.Location = new System.Drawing.Point(72, 372);
            this.lbl_500porhijos.Name = "lbl_500porhijos";
            this.lbl_500porhijos.Size = new System.Drawing.Size(80, 20);
            this.lbl_500porhijos.TabIndex = 7;
            this.lbl_500porhijos.Text = "INCENTIVO\r\n";
            // 
            // lbl_sfs
            // 
            this.lbl_sfs.AutoSize = true;
            this.lbl_sfs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sfs.ForeColor = System.Drawing.Color.White;
            this.lbl_sfs.Location = new System.Drawing.Point(630, 372);
            this.lbl_sfs.Name = "lbl_sfs";
            this.lbl_sfs.Size = new System.Drawing.Size(128, 20);
            this.lbl_sfs.TabIndex = 9;
            this.lbl_sfs.Text = "DESCUENTO (SFS)";
            // 
            // lbl_hijoscantidad
            // 
            this.lbl_hijoscantidad.AutoSize = true;
            this.lbl_hijoscantidad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hijoscantidad.ForeColor = System.Drawing.Color.White;
            this.lbl_hijoscantidad.Location = new System.Drawing.Point(339, 228);
            this.lbl_hijoscantidad.Name = "lbl_hijoscantidad";
            this.lbl_hijoscantidad.Size = new System.Drawing.Size(190, 23);
            this.lbl_hijoscantidad.TabIndex = 10;
            this.lbl_hijoscantidad.Text = "CANTIDAD DE HIJOS/AS";
            // 
            // lbl_sueldoneto
            // 
            this.lbl_sueldoneto.AutoSize = true;
            this.lbl_sueldoneto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldoneto.ForeColor = System.Drawing.Color.White;
            this.lbl_sueldoneto.Location = new System.Drawing.Point(1028, 372);
            this.lbl_sueldoneto.Name = "lbl_sueldoneto";
            this.lbl_sueldoneto.Size = new System.Drawing.Size(103, 20);
            this.lbl_sueldoneto.TabIndex = 11;
            this.lbl_sueldoneto.Text = "SUELDO NETO";
            // 
            // lbl_tituloexpre
            // 
            this.lbl_tituloexpre.AutoSize = true;
            this.lbl_tituloexpre.Font = new System.Drawing.Font("Arial Black", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloexpre.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloexpre.Location = new System.Drawing.Point(332, 2);
            this.lbl_tituloexpre.Name = "lbl_tituloexpre";
            this.lbl_tituloexpre.Size = new System.Drawing.Size(539, 69);
            this.lbl_tituloexpre.TabIndex = 12;
            this.lbl_tituloexpre.Text = "SALARIO EXPRESS";
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldo.ForeColor = System.Drawing.Color.White;
            this.lbl_sueldo.Location = new System.Drawing.Point(453, 186);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(74, 23);
            this.lbl_sueldo.TabIndex = 13;
            this.lbl_sueldo.Text = "SUELDO";
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sueldo.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sueldo.ForeColor = System.Drawing.Color.White;
            this.txt_sueldo.Location = new System.Drawing.Point(542, 189);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(121, 30);
            this.txt_sueldo.TabIndex = 15;
            this.txt_sueldo.TextChanged += new System.EventHandler(this.txt_sueldo_TextChanged);
            // 
            // txt_sueldoneto
            // 
            this.txt_sueldoneto.BackColor = System.Drawing.Color.Silver;
            this.txt_sueldoneto.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sueldoneto.Location = new System.Drawing.Point(1015, 403);
            this.txt_sueldoneto.Name = "txt_sueldoneto";
            this.txt_sueldoneto.Size = new System.Drawing.Size(125, 27);
            this.txt_sueldoneto.TabIndex = 16;
            this.txt_sueldoneto.TextChanged += new System.EventHandler(this.txt_sueldoneto_TextChanged);
            // 
            // txt_cantidad_hijos
            // 
            this.txt_cantidad_hijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantidad_hijos.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_hijos.ForeColor = System.Drawing.Color.White;
            this.txt_cantidad_hijos.Location = new System.Drawing.Point(542, 233);
            this.txt_cantidad_hijos.Name = "txt_cantidad_hijos";
            this.txt_cantidad_hijos.Size = new System.Drawing.Size(121, 30);
            this.txt_cantidad_hijos.TabIndex = 17;
            this.txt_cantidad_hijos.TextChanged += new System.EventHandler(this.txt_cantidad_hijos_TextChanged);
            // 
            // txt_500porhijo
            // 
            this.txt_500porhijo.BackColor = System.Drawing.Color.Silver;
            this.txt_500porhijo.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_500porhijo.Location = new System.Drawing.Point(49, 403);
            this.txt_500porhijo.Name = "txt_500porhijo";
            this.txt_500porhijo.Size = new System.Drawing.Size(125, 27);
            this.txt_500porhijo.TabIndex = 18;
            this.txt_500porhijo.TextChanged += new System.EventHandler(this.txt_500porhijo_TextChanged);
            // 
            // txt_descuento_total
            // 
            this.txt_descuento_total.BackColor = System.Drawing.Color.Silver;
            this.txt_descuento_total.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento_total.Location = new System.Drawing.Point(824, 403);
            this.txt_descuento_total.Name = "txt_descuento_total";
            this.txt_descuento_total.Size = new System.Drawing.Size(125, 27);
            this.txt_descuento_total.TabIndex = 21;
            this.txt_descuento_total.TextChanged += new System.EventHandler(this.txt_descuento_total_TextChanged);
            // 
            // txt_descuento_sfs
            // 
            this.txt_descuento_sfs.BackColor = System.Drawing.Color.Silver;
            this.txt_descuento_sfs.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento_sfs.Location = new System.Drawing.Point(630, 403);
            this.txt_descuento_sfs.Name = "txt_descuento_sfs";
            this.txt_descuento_sfs.Size = new System.Drawing.Size(125, 27);
            this.txt_descuento_sfs.TabIndex = 22;
            this.txt_descuento_sfs.TextChanged += new System.EventHandler(this.txt_descuento_sfs_TextChanged);
            // 
            // txt_descuento_afp
            // 
            this.txt_descuento_afp.BackColor = System.Drawing.Color.Silver;
            this.txt_descuento_afp.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento_afp.Location = new System.Drawing.Point(442, 403);
            this.txt_descuento_afp.Name = "txt_descuento_afp";
            this.txt_descuento_afp.Size = new System.Drawing.Size(125, 27);
            this.txt_descuento_afp.TabIndex = 23;
            this.txt_descuento_afp.TextChanged += new System.EventHandler(this.txt_descuento_afp_TextChanged);
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.ForeColor = System.Drawing.Color.White;
            this.txt_nombre_empleado.Location = new System.Drawing.Point(542, 151);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(307, 30);
            this.txt_nombre_empleado.TabIndex = 24;
            this.txt_nombre_empleado.TextChanged += new System.EventHandler(this.txt_nombre_empleado_TextChanged);
            // 
            // lbl_segundotitulo
            // 
            this.lbl_segundotitulo.AutoSize = true;
            this.lbl_segundotitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundotitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_segundotitulo.Location = new System.Drawing.Point(357, 71);
            this.lbl_segundotitulo.Name = "lbl_segundotitulo";
            this.lbl_segundotitulo.Size = new System.Drawing.Size(492, 22);
            this.lbl_segundotitulo.TabIndex = 25;
            this.lbl_segundotitulo.Text = "CALCULAR EL SUELDO NETO DE LOS EMPLEADOS";
            // 
            // txt_sueldomas_incentivo
            // 
            this.txt_sueldomas_incentivo.BackColor = System.Drawing.Color.Silver;
            this.txt_sueldomas_incentivo.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sueldomas_incentivo.Location = new System.Drawing.Point(248, 403);
            this.txt_sueldomas_incentivo.Name = "txt_sueldomas_incentivo";
            this.txt_sueldomas_incentivo.Size = new System.Drawing.Size(125, 27);
            this.txt_sueldomas_incentivo.TabIndex = 27;
            this.txt_sueldomas_incentivo.TextChanged += new System.EventHandler(this.txt_sueldomas_incentivo_TextChanged);
            // 
            // lbl_sueldoporhijo
            // 
            this.lbl_sueldoporhijo.AutoSize = true;
            this.lbl_sueldoporhijo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldoporhijo.ForeColor = System.Drawing.Color.White;
            this.lbl_sueldoporhijo.Location = new System.Drawing.Point(225, 372);
            this.lbl_sueldoporhijo.Name = "lbl_sueldoporhijo";
            this.lbl_sueldoporhijo.Size = new System.Drawing.Size(171, 20);
            this.lbl_sueldoporhijo.TabIndex = 26;
            this.lbl_sueldoporhijo.Text = "SUELDO MAS INCENTIVO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1180, 544);
            this.Controls.Add(this.txt_sueldomas_incentivo);
            this.Controls.Add(this.lbl_sueldoporhijo);
            this.Controls.Add(this.lbl_segundotitulo);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.txt_descuento_afp);
            this.Controls.Add(this.txt_descuento_sfs);
            this.Controls.Add(this.txt_descuento_total);
            this.Controls.Add(this.txt_500porhijo);
            this.Controls.Add(this.txt_cantidad_hijos);
            this.Controls.Add(this.txt_sueldoneto);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.lbl_sueldo);
            this.Controls.Add(this.lbl_tituloexpre);
            this.Controls.Add(this.lbl_sueldoneto);
            this.Controls.Add(this.lbl_hijoscantidad);
            this.Controls.Add(this.lbl_sfs);
            this.Controls.Add(this.lbl_500porhijos);
            this.Controls.Add(this.lbl_descuento_total);
            this.Controls.Add(this.lbl_afp);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_salir);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_afp;
        private System.Windows.Forms.Label lbl_descuento_total;
        private System.Windows.Forms.Label lbl_500porhijos;
        private System.Windows.Forms.Label lbl_sfs;
        private System.Windows.Forms.Label lbl_hijoscantidad;
        private System.Windows.Forms.Label lbl_sueldoneto;
        private System.Windows.Forms.Label lbl_tituloexpre;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.TextBox txt_sueldoneto;
        private System.Windows.Forms.TextBox txt_cantidad_hijos;
        private System.Windows.Forms.TextBox txt_500porhijo;
        private System.Windows.Forms.TextBox txt_descuento_total;
        private System.Windows.Forms.TextBox txt_descuento_sfs;
        private System.Windows.Forms.TextBox txt_descuento_afp;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private System.Windows.Forms.Label lbl_segundotitulo;
        private System.Windows.Forms.TextBox txt_sueldomas_incentivo;
        private System.Windows.Forms.Label lbl_sueldoporhijo;
    }
}

