namespace gerador_de_testes2024
{
    partial class TelaPrincipalForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            telaInicialToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            disciplinasMenuItem = new ToolStripMenuItem();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            questoesToolStripMenuItem = new ToolStripMenuItem();
            testesToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCopiar = new ToolStripButton();
            btnVisualizar = new ToolStripButton();
            btnPDF = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { telaInicialToolStripMenuItem1, cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(938, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // telaInicialToolStripMenuItem1
            // 
            telaInicialToolStripMenuItem1.Image = gerador_de_testes_2024.Properties.Resources.btnHome;
            telaInicialToolStripMenuItem1.Name = "telaInicialToolStripMenuItem1";
            telaInicialToolStripMenuItem1.Size = new Size(78, 24);
            telaInicialToolStripMenuItem1.Text = "Home";
            telaInicialToolStripMenuItem1.Click += telaInicialToolStripMenuItem1_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinasMenuItem, materiaToolStripMenuItem, questoesToolStripMenuItem, testesToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = gerador_de_testes_2024.Properties.Resources.btnCrud;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(108, 24);
            cadastrosToolStripMenuItem.Text = "Categorias";
            // 
            // disciplinasMenuItem
            // 
            disciplinasMenuItem.Name = "disciplinasMenuItem";
            disciplinasMenuItem.Size = new Size(149, 24);
            disciplinasMenuItem.Text = "Disciplinas";
            disciplinasMenuItem.Click += DisciplinaToolStripMenuItem_Click;
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(149, 24);
            materiaToolStripMenuItem.Text = "Matéria";
            materiaToolStripMenuItem.Click += materiaToolStripMenuItem_Click_1;
            // 
            // questoesToolStripMenuItem
            // 
            questoesToolStripMenuItem.Name = "questoesToolStripMenuItem";
            questoesToolStripMenuItem.Size = new Size(149, 24);
            questoesToolStripMenuItem.Text = "Questões";
            questoesToolStripMenuItem.Click += questoesToolStripMenuItem_Click;
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(149, 24);
            testesToolStripMenuItem.Text = "Testes";
            testesToolStripMenuItem.Click += testesToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ButtonFace;
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 532);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(938, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ButtonFace;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnCopiar, btnVisualizar, btnPDF, toolStripSeparator3, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.No;
            toolStrip1.Size = new Size(938, 81);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = gerador_de_testes_2024.Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(78, 78);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = gerador_de_testes_2024.Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(78, 78);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = gerador_de_testes_2024.Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(78, 78);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 81);
            // 
            // btnCopiar
            // 
            btnCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopiar.Enabled = false;
            btnCopiar.Image = gerador_de_testes_2024.Properties.Resources.btnCopiar;
            btnCopiar.ImageScaling = ToolStripItemImageScaling.None;
            btnCopiar.ImageTransparentColor = Color.Magenta;
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Padding = new Padding(5);
            btnCopiar.Size = new Size(78, 78);
            btnCopiar.Click += btnDuplicar_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Image = gerador_de_testes_2024.Properties.Resources.btnVisualizar;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(5);
            btnVisualizar.Size = new Size(78, 78);
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnPDF
            // 
            btnPDF.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPDF.Enabled = false;
            btnPDF.Image = gerador_de_testes_2024.Properties.Resources.btnPDF;
            btnPDF.ImageScaling = ToolStripItemImageScaling.None;
            btnPDF.ImageTransparentColor = Color.Magenta;
            btnPDF.Name = "btnPDF";
            btnPDF.Padding = new Padding(5);
            btnPDF.Size = new Size(62, 78);
            btnPDF.Click += btnPDF_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 81);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.BackColor = SystemColors.ControlLightLight;
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 78);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.BackgroundImage = (Image)resources.GetObject("pnlRegistros.BackgroundImage");
            pnlRegistros.BackgroundImageLayout = ImageLayout.Center;
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 109);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(938, 423);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 557);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de testes";
            FormClosed += TelaPrincipalForm_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem disciplinasMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem questoesToolStripMenuItem;
        private ToolStripMenuItem materiaToolStripMenuItem;
        private ToolStripButton btnCopiar;
        private ToolStripButton btnVisualizar;
        private ToolStripButton btnPDF;
        private ToolStripMenuItem testesToolStripMenuItem;
        private ToolStripMenuItem telaInicialToolStripMenuItem1;
    }
}
