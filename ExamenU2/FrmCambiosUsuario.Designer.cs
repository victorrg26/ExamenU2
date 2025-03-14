namespace ExamenU2
{
    partial class FrmCambiosUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiosUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtAPaterno = new TextBox();
            txtNombre = new TextBox();
            txtAMaterno = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 121);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(284, 121);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(476, 121);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 2;
            label3.Text = "APaterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 217);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 3;
            label4.Text = "AMaterno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(277, 217);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(476, 217);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 5;
            label6.Text = "Correo";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.InactiveCaption;
            txtId.Enabled = false;
            txtId.Location = new Point(48, 161);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 6;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtAPaterno
            // 
            txtAPaterno.BackColor = SystemColors.InactiveCaption;
            txtAPaterno.Location = new Point(476, 161);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(125, 27);
            txtAPaterno.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(284, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtAMaterno
            // 
            txtAMaterno.BackColor = SystemColors.InactiveCaption;
            txtAMaterno.Location = new Point(48, 261);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(125, 27);
            txtAMaterno.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.InactiveCaption;
            txtTelefono.Location = new Point(277, 261);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.InactiveCaption;
            txtCorreo.Location = new Point(476, 261);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 11;
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImage = (Image)resources.GetObject("btnActualizar.BackgroundImage");
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizar.Location = new Point(284, 346);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 46);
            btnActualizar.TabIndex = 12;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Location = new Point(549, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 46);
            btnCancelar.TabIndex = 13;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Location = new Point(413, 344);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 48);
            btnEliminar.TabIndex = 14;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(258, 27);
            label7.Name = "label7";
            label7.Size = new Size(286, 41);
            label7.TabIndex = 15;
            label7.Text = "Actualizar Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(583, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 99);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FrmCambiosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtAMaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtAPaterno);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCambiosUsuario";
            Text = "Actualizar Usuario";
            Load += FrmCambiosUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtAPaterno;
        private TextBox txtNombre;
        private TextBox txtAMaterno;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnActualizar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Label label7;
        private PictureBox pictureBox1;
    }
}