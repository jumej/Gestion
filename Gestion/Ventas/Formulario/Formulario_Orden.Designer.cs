namespace Gestion.Ventas.Formulario
{
    partial class Formulario_Orden
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
            this.lblMesa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwMenu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwOrden = new System.Windows.Forms.DataGridView();
            this.txtTotalOrden = new System.Windows.Forms.TextBox();
            this.btnOrden = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(988, 20);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(52, 21);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(838, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de mesa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(201, 17);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 29);
            this.cbCategoria.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista de productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(760, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total a pagar:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgwMenu);
            this.panel3.Location = new System.Drawing.Point(101, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 243);
            this.panel3.TabIndex = 10;
            // 
            // dgwMenu
            // 
            this.dgwMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgwMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMenu.Location = new System.Drawing.Point(-1, -1);
            this.dgwMenu.Name = "dgwMenu";
            this.dgwMenu.Size = new System.Drawing.Size(910, 243);
            this.dgwMenu.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgwOrden);
            this.panel1.Location = new System.Drawing.Point(213, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 270);
            this.panel1.TabIndex = 9;
            // 
            // dgwOrden
            // 
            this.dgwOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrden.Location = new System.Drawing.Point(3, 15);
            this.dgwOrden.Name = "dgwOrden";
            this.dgwOrden.Size = new System.Drawing.Size(418, 229);
            this.dgwOrden.TabIndex = 2;
            // 
            // txtTotalOrden
            // 
            this.txtTotalOrden.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotalOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalOrden.Enabled = false;
            this.txtTotalOrden.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrden.ForeColor = System.Drawing.Color.Black;
            this.txtTotalOrden.Location = new System.Drawing.Point(960, 506);
            this.txtTotalOrden.MaxLength = 80;
            this.txtTotalOrden.Name = "txtTotalOrden";
            this.txtTotalOrden.Size = new System.Drawing.Size(159, 57);
            this.txtTotalOrden.TabIndex = 17;
            this.txtTotalOrden.Text = "0.00";
            this.txtTotalOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOrden
            // 
            this.btnOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrden.BackColor = System.Drawing.Color.Transparent;
            this.btnOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrden.Enabled = false;
            this.btnOrden.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOrden.FlatAppearance.BorderSize = 2;
            this.btnOrden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrden.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrden.ForeColor = System.Drawing.Color.Black;
            this.btnOrden.Image = global::Gestion.Properties.Resources.Printer;
            this.btnOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrden.Location = new System.Drawing.Point(887, 429);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(232, 71);
            this.btnOrden.TabIndex = 18;
            this.btnOrden.TabStop = false;
            this.btnOrden.Text = "Hacer orden";
            this.btnOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrden.UseVisualStyleBackColor = false;
            // 
            // Formulario_Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 759);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.txtTotalOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMesa);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formulario_Orden";
            this.Text = "Formulario_Orden";
            this.Load += new System.EventHandler(this.Formulario_Orden_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgwMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwOrden;
        private System.Windows.Forms.TextBox txtTotalOrden;
        private System.Windows.Forms.Button btnOrden;
    }
}