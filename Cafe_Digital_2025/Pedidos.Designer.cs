namespace Cafe_Digital_2025
{
    partial class Pedidos
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
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.txtBxProducto = new System.Windows.Forms.TextBox();
            this.txtBxCantidad = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartel1 = new Cafe_Digital_2025.Cartel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.Location = new System.Drawing.Point(281, 151);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(392, 20);
            this.txtBxNombre.TabIndex = 0;
            // 
            // txtBxProducto
            // 
            this.txtBxProducto.Location = new System.Drawing.Point(281, 191);
            this.txtBxProducto.Name = "txtBxProducto";
            this.txtBxProducto.Size = new System.Drawing.Size(392, 20);
            this.txtBxProducto.TabIndex = 1;
            // 
            // txtBxCantidad
            // 
            this.txtBxCantidad.Location = new System.Drawing.Point(281, 238);
            this.txtBxCantidad.Name = "txtBxCantidad";
            this.txtBxCantidad.Size = new System.Drawing.Size(392, 20);
            this.txtBxCantidad.TabIndex = 2;
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSize = true;
            this.NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCliente.ForeColor = System.Drawing.Color.Sienna;
            this.NombreCliente.Location = new System.Drawing.Point(133, 155);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(142, 16);
            this.NombreCliente.TabIndex = 5;
            this.NombreCliente.Text = "Nombre del cliente:";
            // 
            // producto
            // 
            this.producto.AutoSize = true;
            this.producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto.ForeColor = System.Drawing.Color.Sienna;
            this.producto.Location = new System.Drawing.Point(202, 192);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(73, 16);
            this.producto.TabIndex = 6;
            this.producto.Text = "Producto:";
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cantidad.ForeColor = System.Drawing.Color.Sienna;
            this.cantidad.Location = new System.Drawing.Point(202, 239);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(73, 16);
            this.cantidad.TabIndex = 7;
            this.cantidad.Text = "Cantidad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 100);
            this.panel1.TabIndex = 8;
            // 
            // cartel1
            // 
            this.cartel1.Location = new System.Drawing.Point(343, 280);
            this.cartel1.Name = "cartel1";
            this.cartel1.Size = new System.Drawing.Size(209, 111);
            this.cartel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(401, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(258, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(560, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(421, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Producto\r\nSeleccionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(295, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "REALIAZAR PEDIDO";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.txtBxCantidad);
            this.Controls.Add(this.txtBxProducto);
            this.Controls.Add(this.txtBxNombre);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.TextBox txtBxProducto;
        private System.Windows.Forms.TextBox txtBxCantidad;
        private System.Windows.Forms.Label NombreCliente;
        private System.Windows.Forms.Label producto;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Panel panel1;
        private Cartel cartel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}