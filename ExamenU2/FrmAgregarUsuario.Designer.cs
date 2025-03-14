namespace ExamenU2
{
    partial class FrmAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarUsuario));
            btnAgregar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregar.Location = new Point(444, 339);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 50);
            btnAgregar.TabIndex = 0;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Location = new Point(590, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 50);
            btnCancelar.TabIndex = 1;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 113);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(246, 113);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 4;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(462, 113);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 5;
            label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(199, 208);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(463, 208);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 7;
            label6.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.PeachPuff;
            txtNombre.Location = new Point(68, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtAPaterno
            // 
            txtAPaterno.BackColor = Color.PeachPuff;
            txtAPaterno.Location = new Point(266, 159);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(125, 27);
            txtAPaterno.TabIndex = 10;
            // 
            // txtAMaterno
            // 
            txtAMaterno.BackColor = Color.PeachPuff;
            txtAMaterno.Location = new Point(490, 159);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(125, 27);
            txtAMaterno.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.PeachPuff;
            txtTelefono.Location = new Point(190, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.PeachPuff;
            txtCorreo.Location = new Point(444, 252);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 42);
            label1.Name = "label1";
            label1.Size = new Size(255, 41);
            label1.TabIndex = 14;
            label1.Text = "Agregar Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(579, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 101);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FrmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtAMaterno);
            Controls.Add(txtAPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "FrmAgregarUsuario";
            Text = "Agregar Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnCancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label label1;
        private PictureBox pictureBox1;
    }
}