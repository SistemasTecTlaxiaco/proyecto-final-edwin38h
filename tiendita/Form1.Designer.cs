
namespace Admin2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buscador = new System.Windows.Forms.TextBox();
            this.recivido = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.Agregador = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.Eliminador = new System.Windows.Forms.Button();
            this.visualizar = new System.Windows.Forms.Button();
            this.idd = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 99);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(403, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ADMINISTRADOR DE VENTAS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Venta";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(130, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inventario";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(185, 142);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 17);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Buscar Producto";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(36, 357);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 17);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Dinero Recivido";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buscador
            // 
            this.buscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buscador.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buscador.Location = new System.Drawing.Point(51, 169);
            this.buscador.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(382, 23);
            this.buscador.TabIndex = 4;
            this.buscador.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // recivido
            // 
            this.recivido.Location = new System.Drawing.Point(222, 353);
            this.recivido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.recivido.Name = "recivido";
            this.recivido.Size = new System.Drawing.Size(155, 24);
            this.recivido.TabIndex = 5;
            this.recivido.TextChanged += new System.EventHandler(this.recivido_TextChanged);
            this.recivido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recivido_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button3.Location = new System.Drawing.Point(319, 404);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "Vender";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button4.Location = new System.Drawing.Point(1064, 404);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 38);
            this.button4.TabIndex = 13;
            this.button4.Text = "Cerrar Cajero";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.Location = new System.Drawing.Point(532, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(656, 241);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button5.Location = new System.Drawing.Point(185, 200);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 46);
            this.button5.TabIndex = 15;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Agregador
            // 
            this.Agregador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Agregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Agregador.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Agregador.Location = new System.Drawing.Point(51, 200);
            this.Agregador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Agregador.Name = "Agregador";
            this.Agregador.Size = new System.Drawing.Size(111, 46);
            this.Agregador.TabIndex = 16;
            this.Agregador.Text = "Agregar";
            this.Agregador.UseVisualStyleBackColor = false;
            this.Agregador.Click += new System.EventHandler(this.Agregador_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.actualizar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.actualizar.Location = new System.Drawing.Point(319, 200);
            this.actualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(115, 46);
            this.actualizar.TabIndex = 17;
            this.actualizar.Text = "actuzalizar";
            this.actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // Eliminador
            // 
            this.Eliminador.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminador.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Eliminador.Location = new System.Drawing.Point(185, 281);
            this.Eliminador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Eliminador.Name = "Eliminador";
            this.Eliminador.Size = new System.Drawing.Size(115, 45);
            this.Eliminador.TabIndex = 18;
            this.Eliminador.Text = "Eliminar";
            this.Eliminador.UseVisualStyleBackColor = false;
            this.Eliminador.Click += new System.EventHandler(this.Eliminador_Click);
            // 
            // visualizar
            // 
            this.visualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visualizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.visualizar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.visualizar.Location = new System.Drawing.Point(51, 404);
            this.visualizar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(111, 38);
            this.visualizar.TabIndex = 19;
            this.visualizar.Text = "visualizar";
            this.visualizar.UseVisualStyleBackColor = false;
            this.visualizar.Click += new System.EventHandler(this.visualizar_Click);
            // 
            // idd
            // 
            this.idd.Location = new System.Drawing.Point(91, 291);
            this.idd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idd.Name = "idd";
            this.idd.Size = new System.Drawing.Size(70, 24);
            this.idd.TabIndex = 20;
            this.idd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idd_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(36, 291);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(38, 17);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1250, 461);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.idd);
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.Eliminador);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.Agregador);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.recivido);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.TextBox recivido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Agregador;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button Eliminador;
        private System.Windows.Forms.Button visualizar;
        private System.Windows.Forms.TextBox idd;
        private System.Windows.Forms.TextBox textBox5;
    }
}

