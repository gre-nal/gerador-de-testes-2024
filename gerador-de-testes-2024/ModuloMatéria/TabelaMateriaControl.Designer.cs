namespace gerador_de_testes_2024.ModuloMatéria
{
    partial class TabelaMateriaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            GridMateria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridMateria).BeginInit();
            SuspendLayout();
            // 
            // GridMateria
            // 
            GridMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMateria.Location = new Point(0, 0);
            GridMateria.Name = "GridMateria";
            GridMateria.Size = new Size(150, 150);
            GridMateria.TabIndex = 0;
            // 
            // TabelaMateriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GridMateria);
            Name = "TabelaMateriaControl";
            ((System.ComponentModel.ISupportInitialize)GridMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridMateria;
    }
}
