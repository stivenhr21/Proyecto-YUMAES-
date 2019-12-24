namespace InventarioYumaes
{
    partial class MantenimientoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProducto));
            this.btnsalirmc = new System.Windows.Forms.Button();
            this.btneliminarmc = new System.Windows.Forms.Button();
            this.btnguardarmc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtprecio = new CadenaConexion.ErrorTxtBox();
            this.txtnombrepro = new CadenaConexion.ErrorTxtBox();
            this.txtcodigo = new CadenaConexion.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalirmc
            // 
            this.btnsalirmc.Location = new System.Drawing.Point(216, 200);
            this.btnsalirmc.Name = "btnsalirmc";
            this.btnsalirmc.Size = new System.Drawing.Size(75, 23);
            this.btnsalirmc.TabIndex = 9;
            this.btnsalirmc.Text = "Salir";
            this.btnsalirmc.UseVisualStyleBackColor = true;
            this.btnsalirmc.Click += new System.EventHandler(this.Btnsalirmc_Click);
            // 
            // btneliminarmc
            // 
            this.btneliminarmc.Location = new System.Drawing.Point(125, 200);
            this.btneliminarmc.Name = "btneliminarmc";
            this.btneliminarmc.Size = new System.Drawing.Size(75, 23);
            this.btneliminarmc.TabIndex = 7;
            this.btneliminarmc.Text = "Eliminar";
            this.btneliminarmc.UseVisualStyleBackColor = true;
            this.btneliminarmc.Click += new System.EventHandler(this.Btneliminarmc_Click);
            // 
            // btnguardarmc
            // 
            this.btnguardarmc.Location = new System.Drawing.Point(31, 200);
            this.btnguardarmc.Name = "btnguardarmc";
            this.btnguardarmc.Size = new System.Drawing.Size(75, 23);
            this.btnguardarmc.TabIndex = 6;
            this.btnguardarmc.Text = "Guardar";
            this.btnguardarmc.UseVisualStyleBackColor = true;
            this.btnguardarmc.Click += new System.EventHandler(this.Btnguardarmc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(125, 151);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(166, 20);
            this.txtprecio.SoloNumeros = false;
            this.txtprecio.TabIndex = 18;
            this.txtprecio.Validar = true;
            // 
            // txtnombrepro
            // 
            this.txtnombrepro.Location = new System.Drawing.Point(125, 90);
            this.txtnombrepro.Name = "txtnombrepro";
            this.txtnombrepro.Size = new System.Drawing.Size(166, 20);
            this.txtnombrepro.SoloNumeros = false;
            this.txtnombrepro.TabIndex = 17;
            this.txtnombrepro.Validar = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(125, 27);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(166, 20);
            this.txtcodigo.SoloNumeros = true;
            this.txtcodigo.TabIndex = 16;
            this.txtcodigo.Validar = true;
            this.txtcodigo.TextChanged += new System.EventHandler(this.Txtcodigo_TextChanged);
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 237);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnombrepro);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalirmc);
            this.Controls.Add(this.btneliminarmc);
            this.Controls.Add(this.btnguardarmc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoProducto";
            this.Load += new System.EventHandler(this.MantenimientoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalirmc;
        private System.Windows.Forms.Button btneliminarmc;
        private System.Windows.Forms.Button btnguardarmc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CadenaConexion.ErrorTxtBox txtcodigo;
        private CadenaConexion.ErrorTxtBox txtnombrepro;
        private CadenaConexion.ErrorTxtBox txtprecio;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}