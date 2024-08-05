namespace GestionTareasPendientes
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
            texto = new Label();
            lstTareas = new ListBox();
            txtTarea = new TextBox();
            btnEliminarTarea = new Button();
            btnLimpiarLista = new Button();
            btnAgregarTarea = new Button();
            SuspendLayout();
            // 
            // texto
            // 
            texto.AutoSize = true;
            texto.Location = new Point(160, 31);
            texto.Name = "texto";
            texto.Size = new Size(99, 15);
            texto.TabIndex = 0;
            texto.Text = "Ingreso de tareas:";
            texto.Click += label1_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(160, 93);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(549, 259);
            lstTareas.TabIndex = 4;
            lstTareas.SelectedIndexChanged += lstTareas_SelectedIndexChanged;
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(265, 28);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(444, 23);
            txtTarea.TabIndex = 1;
            txtTarea.TextChanged += txtTarea_TextChanged;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Location = new Point(356, 358);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(171, 38);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // btnLimpiarLista
            // 
            btnLimpiarLista.Location = new Point(356, 402);
            btnLimpiarLista.Name = "btnLimpiarLista";
            btnLimpiarLista.Size = new Size(171, 36);
            btnLimpiarLista.TabIndex = 5;
            btnLimpiarLista.Text = "Limpiar Tareas";
            btnLimpiarLista.UseVisualStyleBackColor = true;
            btnLimpiarLista.Click += btnLimpiarLista_Click;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(356, 57);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(171, 30);
            btnAgregarTarea.TabIndex = 2;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarTarea);
            Controls.Add(btnLimpiarLista);
            Controls.Add(btnEliminarTarea);
            Controls.Add(txtTarea);
            Controls.Add(lstTareas);
            Controls.Add(texto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label texto;
        private ListBox lstTareas;
        private TextBox txtTarea;
        private Button btnEliminarTarea;
        private Button btnLimpiarLista;
        private Button btnAgregarTarea;
    }
}
