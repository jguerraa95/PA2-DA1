namespace PA2_GUI
{
    partial class PacienteCRUD
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
            dataGridView1 = new DataGridView();
            LblDni = new Label();
            TxtDni = new TextBox();
            BtnAgregar = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            BtnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(983, 392);
            dataGridView1.TabIndex = 0;
            // 
            // LblDni
            // 
            LblDni.AutoSize = true;
            LblDni.Location = new Point(33, 17);
            LblDni.Name = "LblDni";
            LblDni.Size = new Size(139, 15);
            LblDni.TabIndex = 1;
            LblDni.Text = "Ingresar DNI del paciente";
            // 
            // TxtDni
            // 
            TxtDni.Location = new Point(187, 14);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(142, 23);
            TxtDni.TabIndex = 2;
            TxtDni.TextChanged += textBox1_TextChanged;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(453, 476);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(111, 36);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(584, 476);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(111, 36);
            BtnActualizar.TabIndex = 4;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(713, 476);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(111, 36);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(884, 476);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(111, 36);
            BtnCerrar.TabIndex = 6;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // PacienteCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 535);
            Controls.Add(BtnCerrar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtDni);
            Controls.Add(LblDni);
            Controls.Add(dataGridView1);
            Name = "PacienteCRUD";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label LblDni;
        private TextBox TxtDni;
        private Button BtnAgregar;
        private Button BtnActualizar;
        private Button BtnEliminar;
        private Button BtnCerrar;
    }
}