
namespace WindowsFormsAppRetoCrud
{
    partial class FormRegistroMercancías
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
            this.dataGridViewMercancías = new System.Windows.Forms.DataGridView();
            this.panelBar = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.tabControlOpers = new System.Windows.Forms.TabControl();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.numericUpDownExistencia = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescripción = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelEniminableM = new System.Windows.Forms.Label();
            this.labelStatusM = new System.Windows.Forms.Label();
            this.labelComentarioM = new System.Windows.Forms.Label();
            this.labelExistenciaM = new System.Windows.Forms.Label();
            this.labelDescripciónM = new System.Windows.Forms.Label();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMercancías)).BeginInit();
            this.panelBar.SuspendLayout();
            this.tabControlOpers.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMercancías
            // 
            this.dataGridViewMercancías.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMercancías.Location = new System.Drawing.Point(22, 109);
            this.dataGridViewMercancías.Name = "dataGridViewMercancías";
            this.dataGridViewMercancías.RowHeadersWidth = 51;
            this.dataGridViewMercancías.RowTemplate.Height = 24;
            this.dataGridViewMercancías.Size = new System.Drawing.Size(669, 392);
            this.dataGridViewMercancías.TabIndex = 0;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelBar.Controls.Add(this.buttonInfo);
            this.panelBar.Controls.Add(this.buttonCerrar);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1298, 51);
            this.panelBar.TabIndex = 1;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(1184, 0);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(57, 51);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "?";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(1241, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(57, 51);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // tabControlOpers
            // 
            this.tabControlOpers.Controls.Add(this.tabPageInsert);
            this.tabControlOpers.Location = new System.Drawing.Point(781, 114);
            this.tabControlOpers.Name = "tabControlOpers";
            this.tabControlOpers.SelectedIndex = 0;
            this.tabControlOpers.Size = new System.Drawing.Size(505, 387);
            this.tabControlOpers.TabIndex = 2;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPageInsert.Controls.Add(this.comboBoxStatus);
            this.tabPageInsert.Controls.Add(this.radioButtonNo);
            this.tabPageInsert.Controls.Add(this.radioButtonYes);
            this.tabPageInsert.Controls.Add(this.textBoxComentario);
            this.tabPageInsert.Controls.Add(this.numericUpDownExistencia);
            this.tabPageInsert.Controls.Add(this.textBoxDescripción);
            this.tabPageInsert.Controls.Add(this.labelTitulo);
            this.tabPageInsert.Controls.Add(this.labelEniminableM);
            this.tabPageInsert.Controls.Add(this.labelStatusM);
            this.tabPageInsert.Controls.Add(this.labelComentarioM);
            this.tabPageInsert.Controls.Add(this.labelExistenciaM);
            this.tabPageInsert.Controls.Add(this.labelDescripciónM);
            this.tabPageInsert.ForeColor = System.Drawing.Color.DarkOrange;
            this.tabPageInsert.Location = new System.Drawing.Point(4, 30);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(497, 353);
            this.tabPageInsert.TabIndex = 0;
            this.tabPageInsert.Text = "Insertar";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.comboBoxStatus.Location = new System.Drawing.Point(348, 131);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(143, 30);
            this.comboBoxStatus.TabIndex = 11;
            this.comboBoxStatus.Text = "Seleccione 1";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(317, 311);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(52, 25);
            this.radioButtonNo.TabIndex = 10;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(267, 311);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(44, 25);
            this.radioButtonYes.TabIndex = 9;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Si";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentario.Location = new System.Drawing.Point(137, 190);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(354, 89);
            this.textBoxComentario.TabIndex = 8;
            // 
            // numericUpDownExistencia
            // 
            this.numericUpDownExistencia.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExistencia.Location = new System.Drawing.Point(137, 132);
            this.numericUpDownExistencia.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.numericUpDownExistencia.Name = "numericUpDownExistencia";
            this.numericUpDownExistencia.Size = new System.Drawing.Size(115, 29);
            this.numericUpDownExistencia.TabIndex = 7;
            // 
            // textBoxDescripción
            // 
            this.textBoxDescripción.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripción.Location = new System.Drawing.Point(137, 67);
            this.textBoxDescripción.Name = "textBoxDescripción";
            this.textBoxDescripción.Size = new System.Drawing.Size(354, 29);
            this.textBoxDescripción.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(200, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(100, 29);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Insertar:";
            // 
            // labelEniminableM
            // 
            this.labelEniminableM.AutoSize = true;
            this.labelEniminableM.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEniminableM.Location = new System.Drawing.Point(106, 312);
            this.labelEniminableM.Name = "labelEniminableM";
            this.labelEniminableM.Size = new System.Drawing.Size(153, 23);
            this.labelEniminableM.TabIndex = 4;
            this.labelEniminableM.Text = "No es Eliminable?";
            // 
            // labelStatusM
            // 
            this.labelStatusM.AutoSize = true;
            this.labelStatusM.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusM.Location = new System.Drawing.Point(276, 135);
            this.labelStatusM.Name = "labelStatusM";
            this.labelStatusM.Size = new System.Drawing.Size(66, 23);
            this.labelStatusM.TabIndex = 3;
            this.labelStatusM.Text = "Status:";
            // 
            // labelComentarioM
            // 
            this.labelComentarioM.AutoSize = true;
            this.labelComentarioM.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentarioM.Location = new System.Drawing.Point(21, 225);
            this.labelComentarioM.Name = "labelComentarioM";
            this.labelComentarioM.Size = new System.Drawing.Size(112, 23);
            this.labelComentarioM.TabIndex = 2;
            this.labelComentarioM.Text = "Comentario:";
            // 
            // labelExistenciaM
            // 
            this.labelExistenciaM.AutoSize = true;
            this.labelExistenciaM.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExistenciaM.Location = new System.Drawing.Point(31, 132);
            this.labelExistenciaM.Name = "labelExistenciaM";
            this.labelExistenciaM.Size = new System.Drawing.Size(97, 23);
            this.labelExistenciaM.TabIndex = 1;
            this.labelExistenciaM.Text = "Existencia:";
            // 
            // labelDescripciónM
            // 
            this.labelDescripciónM.AutoSize = true;
            this.labelDescripciónM.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripciónM.Location = new System.Drawing.Point(21, 69);
            this.labelDescripciónM.Name = "labelDescripciónM";
            this.labelDescripciónM.Size = new System.Drawing.Size(110, 23);
            this.labelDescripciónM.TabIndex = 0;
            this.labelDescripciónM.Text = "Descripción:";
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.Transparent;
            this.buttonInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertar.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonInsertar.Location = new System.Drawing.Point(980, 507);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(98, 48);
            this.buttonInsertar.TabIndex = 3;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonLimpiar.Location = new System.Drawing.Point(1084, 507);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(98, 48);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonEliminar.Location = new System.Drawing.Point(1188, 507);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(98, 48);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonSelect.Location = new System.Drawing.Point(22, 507);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(124, 48);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Seleccionar";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // FormRegistroMercancías
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 567);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.tabControlOpers);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.dataGridViewMercancías);
            this.Name = "FormRegistroMercancías";
            this.Text = "FormMantenimiento";
            this.Load += new System.EventHandler(this.FormRegistroMercancías_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMercancías)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.tabControlOpers.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMercancías;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.TabControl tabControlOpers;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.Label labelEniminableM;
        private System.Windows.Forms.Label labelStatusM;
        private System.Windows.Forms.Label labelComentarioM;
        private System.Windows.Forms.Label labelExistenciaM;
        private System.Windows.Forms.Label labelDescripciónM;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.NumericUpDown numericUpDownExistencia;
        private System.Windows.Forms.TextBox textBoxDescripción;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonInfo;
    }
}