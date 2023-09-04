namespace Practico1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox = new CheckBox();
            btnEliminar = new Button();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDate = new DateTimePicker();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnLimpiar = new Button();
            btnModificar = new Button();
            lblValorUF = new Label();
            lblValorDolar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Rut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 91);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Empresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 122);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 0;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 155);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 1;
            label5.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 183);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 1;
            label6.Text = "Fecha Registro";
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(139, 92);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(15, 14);
            checkBox.TabIndex = 2;
            checkBox.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(81, 27);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(139, 25);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(227, 23);
            txtRut.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(139, 119);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(227, 23);
            txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(139, 155);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(227, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(139, 183);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(227, 23);
            txtDate.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(0, 27);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(949, 327);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnEliminar);
            panel1.Location = new Point(35, 264);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 75);
            panel1.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(256, 27);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button2_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(175, 27);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += button1_Click;
            // 
            // lblValorUF
            // 
            lblValorUF.AutoSize = true;
            lblValorUF.Location = new Point(35, 362);
            lblValorUF.Name = "lblValorUF";
            lblValorUF.Size = new Size(81, 15);
            lblValorUF.TabIndex = 8;
            lblValorUF.Text = "Valor de la UF:";
            // 
            // lblValorDolar
            // 
            lblValorDolar.AutoSize = true;
            lblValorDolar.Location = new Point(35, 398);
            lblValorDolar.Name = "lblValorDolar";
            lblValorDolar.Size = new Size(86, 15);
            lblValorDolar.TabIndex = 8;
            lblValorDolar.Text = "Valor del Dólar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 435);
            Controls.Add(lblValorDolar);
            Controls.Add(lblValorUF);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(txtDate);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(checkBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
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
        private CheckBox checkBox;
        private Button btnEliminar;
        private TextBox txtRut;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private DateTimePicker txtDate;
        private Button btnGuardar;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label lblValorUF;
        private Label lblValorDolar;
        private Button btnLimpiar;
        private Button btnModificar;
    }
}