namespace InventarioYumaes
{
    partial class MantenimientoCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCliente));
            this.btnguardarmc = new System.Windows.Forms.Button();
            this.btneliminarmc = new System.Windows.Forms.Button();
            this.btnsalirmc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtdireccion = new CadenaConexion.ErrorTxtBox();
            this.txttelefono = new CadenaConexion.ErrorTxtBox();
            this.txtnombrecli = new CadenaConexion.ErrorTxtBox();
            this.txtid_cliente = new CadenaConexion.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardarmc
            // 
            this.btnguardarmc.Location = new System.Drawing.Point(25, 233);
            this.btnguardarmc.Name = "btnguardarmc";
            this.btnguardarmc.Size = new System.Drawing.Size(82, 23);
            this.btnguardarmc.TabIndex = 1;
            this.btnguardarmc.Text = "Guardar";
            this.btnguardarmc.UseVisualStyleBackColor = true;
            this.btnguardarmc.Click += new System.EventHandler(this.Btnguardarmc_Click);
            // 
            // btneliminarmc
            // 
            this.btneliminarmc.Location = new System.Drawing.Point(119, 233);
            this.btneliminarmc.Name = "btneliminarmc";
            this.btneliminarmc.Size = new System.Drawing.Size(81, 23);
            this.btneliminarmc.TabIndex = 2;
            this.btneliminarmc.Text = "Eliminar";
            this.btneliminarmc.UseVisualStyleBackColor = true;
            this.btneliminarmc.Click += new System.EventHandler(this.Btneliminarmc_Click);
            // 
            // btnsalirmc
            // 
            this.btnsalirmc.Location = new System.Drawing.Point(215, 233);
            this.btnsalirmc.Name = "btnsalirmc";
            this.btnsalirmc.Size = new System.Drawing.Size(81, 23);
            this.btnsalirmc.TabIndex = 4;
            this.btnsalirmc.Text = "Salir";
            this.btnsalirmc.UseVisualStyleBackColor = true;
            this.btnsalirmc.Click += new System.EventHandler(this.Btnsalirmc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "id_cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Direcciòn";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(141, 185);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(155, 20);
            this.txtdireccion.SoloNumeros = false;
            this.txtdireccion.TabIndex = 30;
            this.txtdireccion.Validar = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(141, 132);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(155, 20);
            this.txttelefono.SoloNumeros = false;
            this.txttelefono.TabIndex = 29;
            this.txttelefono.Validar = true;
            // 
            // txtnombrecli
            // 
            this.txtnombrecli.Location = new System.Drawing.Point(141, 79);
            this.txtnombrecli.Name = "txtnombrecli";
            this.txtnombrecli.Size = new System.Drawing.Size(155, 20);
            this.txtnombrecli.SoloNumeros = false;
            this.txtnombrecli.TabIndex = 27;
            this.txtnombrecli.Validar = true;
            // 
            // txtid_cliente
            // 
            this.txtid_cliente.Location = new System.Drawing.Point(141, 27);
            this.txtid_cliente.Name = "txtid_cliente";
            this.txtid_cliente.Size = new System.Drawing.Size(155, 20);
            this.txtid_cliente.SoloNumeros = false;
            this.txtid_cliente.TabIndex = 26;
            this.txtid_cliente.Validar = true;
            this.txtid_cliente.TextChanged += new System.EventHandler(this.Txtid_cliente_TextChanged);
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 269);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtnombrecli);
            this.Controls.Add(this.txtid_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalirmc);
            this.Controls.Add(this.btneliminarmc);
            this.Controls.Add(this.btnguardarmc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoCliente";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardarmc;
        private System.Windows.Forms.Button btneliminarmc;
        private System.Windows.Forms.Button btnsalirmc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CadenaConexion.ErrorTxtBox txtid_cliente;
        private CadenaConexion.ErrorTxtBox txtnombrecli;
        private CadenaConexion.ErrorTxtBox txttelefono;
        private CadenaConexion.ErrorTxtBox txtdireccion;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}