namespace Prueba_net_2.Vista
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkPizzaIndividual = new System.Windows.Forms.CheckBox();
            this.checkPizzaMediana = new System.Windows.Forms.CheckBox();
            this.checkPizzaFamiliar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBebidaIndividual = new System.Windows.Forms.CheckBox();
            this.checkBebidaFamiliar = new System.Windows.Forms.CheckBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalAgregado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Hat Spa";
            // 
            // checkPizzaIndividual
            // 
            this.checkPizzaIndividual.AutoSize = true;
            this.checkPizzaIndividual.Location = new System.Drawing.Point(243, 308);
            this.checkPizzaIndividual.Name = "checkPizzaIndividual";
            this.checkPizzaIndividual.Size = new System.Drawing.Size(154, 24);
            this.checkPizzaIndividual.TabIndex = 1;
            this.checkPizzaIndividual.Text = "Individual $8.000";
            this.checkPizzaIndividual.UseVisualStyleBackColor = true;
            this.checkPizzaIndividual.CheckedChanged += new System.EventHandler(this.checkPizzaIndividual_CheckedChanged);
            this.checkPizzaIndividual.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // checkPizzaMediana
            // 
            this.checkPizzaMediana.AutoSize = true;
            this.checkPizzaMediana.Location = new System.Drawing.Point(243, 362);
            this.checkPizzaMediana.Name = "checkPizzaMediana";
            this.checkPizzaMediana.Size = new System.Drawing.Size(158, 24);
            this.checkPizzaMediana.TabIndex = 2;
            this.checkPizzaMediana.Text = "Mediana $12.000";
            this.checkPizzaMediana.UseVisualStyleBackColor = true;
            this.checkPizzaMediana.CheckedChanged += new System.EventHandler(this.checkPizzaMediana_CheckedChanged);
            this.checkPizzaMediana.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // checkPizzaFamiliar
            // 
            this.checkPizzaFamiliar.AutoSize = true;
            this.checkPizzaFamiliar.Location = new System.Drawing.Point(243, 409);
            this.checkPizzaFamiliar.Name = "checkPizzaFamiliar";
            this.checkPizzaFamiliar.Size = new System.Drawing.Size(156, 24);
            this.checkPizzaFamiliar.TabIndex = 3;
            this.checkPizzaFamiliar.Text = "Familiar $ 22.000";
            this.checkPizzaFamiliar.UseVisualStyleBackColor = true;
            this.checkPizzaFamiliar.CheckedChanged += new System.EventHandler(this.checkPizzaFamiliar_CheckedChanged);
            this.checkPizzaFamiliar.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pizzas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bebidas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad";
            // 
            // checkBebidaIndividual
            // 
            this.checkBebidaIndividual.AutoSize = true;
            this.checkBebidaIndividual.Location = new System.Drawing.Point(609, 308);
            this.checkBebidaIndividual.Name = "checkBebidaIndividual";
            this.checkBebidaIndividual.Size = new System.Drawing.Size(154, 24);
            this.checkBebidaIndividual.TabIndex = 8;
            this.checkBebidaIndividual.Text = "Individual $1.500";
            this.checkBebidaIndividual.UseVisualStyleBackColor = true;
            this.checkBebidaIndividual.CheckedChanged += new System.EventHandler(this.checkBebidaIndividual_CheckedChanged);
            this.checkBebidaIndividual.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // checkBebidaFamiliar
            // 
            this.checkBebidaFamiliar.AutoSize = true;
            this.checkBebidaFamiliar.Location = new System.Drawing.Point(609, 362);
            this.checkBebidaFamiliar.Name = "checkBebidaFamiliar";
            this.checkBebidaFamiliar.Size = new System.Drawing.Size(143, 24);
            this.checkBebidaFamiliar.TabIndex = 9;
            this.checkBebidaFamiliar.Text = "Familiar $5.000";
            this.checkBebidaFamiliar.UseVisualStyleBackColor = true;
            this.checkBebidaFamiliar.CheckedChanged += new System.EventHandler(this.checkBebidaFamiliar_CheckedChanged);
            this.checkBebidaFamiliar.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(240, 532);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(157, 49);
            this.btnAgregarPedido.TabIndex = 14;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(609, 532);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(158, 49);
            this.btnCerrarCaja.TabIndex = 11;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total :";
            // 
            // lblTotalAgregado
            // 
            this.lblTotalAgregado.AutoSize = true;
            this.lblTotalAgregado.Location = new System.Drawing.Point(236, 654);
            this.lblTotalAgregado.Name = "lblTotalAgregado";
            this.lblTotalAgregado.Size = new System.Drawing.Size(31, 20);
            this.lblTotalAgregado.TabIndex = 13;
            this.lblTotalAgregado.Text = "$ 0";
            this.lblTotalAgregado.TextChanged += new System.EventHandler(this.btnAgregarPedido_Click);
            this.lblTotalAgregado.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regToolStripMenuItem
            // 
            this.regToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.registroToolStripMenuItem1});
            this.regToolStripMenuItem.Name = "regToolStripMenuItem";
            this.regToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.regToolStripMenuItem.Text = "Opciones";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.registroToolStripMenuItem1.Text = "Registro";
            this.registroToolStripMenuItem1.Click += new System.EventHandler(this.registroToolStripMenuItem1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.lblTotalAgregado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.checkBebidaFamiliar);
            this.Controls.Add(this.checkBebidaIndividual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkPizzaFamiliar);
            this.Controls.Add(this.checkPizzaMediana);
            this.Controls.Add(this.checkPizzaIndividual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPizzaIndividual;
        private System.Windows.Forms.CheckBox checkPizzaMediana;
        private System.Windows.Forms.CheckBox checkPizzaFamiliar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBebidaIndividual;
        private System.Windows.Forms.CheckBox checkBebidaFamiliar;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalAgregado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
    }
}