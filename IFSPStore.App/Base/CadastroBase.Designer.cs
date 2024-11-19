namespace IFSPStore.App.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            botao_de_cancelar = new ReaLTaiizor.Controls.MaterialButton();
            botao_salvar = new ReaLTaiizor.Controls.MaterialButton();
            tabPage2 = new TabPage();
            botao_editar = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewConsulta = new DataGridView();
            botao_excluir = new ReaLTaiizor.Controls.MaterialButton();
            botao_novo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            TabControlCadastro.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).BeginInit();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPage1);
            TabControlCadastro.Controls.Add(tabPage2);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(3, 64);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(916, 563);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(botao_de_cancelar);
            tabPage1.Controls.Add(botao_salvar);
            tabPage1.ImageKey = "cadastro.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(908, 528);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // botao_de_cancelar
            // 
            botao_de_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botao_de_cancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botao_de_cancelar.Depth = 0;
            botao_de_cancelar.HighEmphasis = true;
            botao_de_cancelar.Icon = null;
            botao_de_cancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botao_de_cancelar.Location = new Point(574, 475);
            botao_de_cancelar.Margin = new Padding(4, 6, 4, 6);
            botao_de_cancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botao_de_cancelar.Name = "botao_de_cancelar";
            botao_de_cancelar.NoAccentTextColor = Color.Empty;
            botao_de_cancelar.Size = new Size(96, 36);
            botao_de_cancelar.TabIndex = 3;
            botao_de_cancelar.Text = "cancelar";
            botao_de_cancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botao_de_cancelar.UseAccentColor = false;
            botao_de_cancelar.UseVisualStyleBackColor = true;
            botao_de_cancelar.Click += botao_de_cancelar_Click;
            // 
            // botao_salvar
            // 
            botao_salvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botao_salvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botao_salvar.Depth = 0;
            botao_salvar.HighEmphasis = true;
            botao_salvar.Icon = null;
            botao_salvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botao_salvar.Location = new Point(691, 475);
            botao_salvar.Margin = new Padding(4, 6, 4, 6);
            botao_salvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botao_salvar.Name = "botao_salvar";
            botao_salvar.NoAccentTextColor = Color.Empty;
            botao_salvar.Size = new Size(76, 36);
            botao_salvar.TabIndex = 2;
            botao_salvar.Text = "salvar";
            botao_salvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botao_salvar.UseAccentColor = false;
            botao_salvar.UseVisualStyleBackColor = true;
            botao_salvar.Click += botao_salvar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(botao_editar);
            tabPage2.Controls.Add(dataGridViewConsulta);
            tabPage2.Controls.Add(botao_excluir);
            tabPage2.Controls.Add(botao_novo);
            tabPage2.ImageKey = "consulta.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(908, 528);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // botao_editar
            // 
            botao_editar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botao_editar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botao_editar.Depth = 0;
            botao_editar.HighEmphasis = true;
            botao_editar.Icon = null;
            botao_editar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botao_editar.Location = new Point(626, 473);
            botao_editar.Margin = new Padding(4, 6, 4, 6);
            botao_editar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botao_editar.Name = "botao_editar";
            botao_editar.NoAccentTextColor = Color.Empty;
            botao_editar.Size = new Size(71, 36);
            botao_editar.TabIndex = 4;
            botao_editar.Text = "editar";
            botao_editar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botao_editar.UseAccentColor = false;
            botao_editar.UseVisualStyleBackColor = true;
            botao_editar.Click += botao_editar_Click;
            // 
            // dataGridViewConsulta
            // 
            dataGridViewConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsulta.Location = new Point(3, 3);
            dataGridViewConsulta.Name = "dataGridViewConsulta";
            dataGridViewConsulta.RowHeadersWidth = 51;
            dataGridViewConsulta.Size = new Size(902, 447);
            dataGridViewConsulta.TabIndex = 3;
            // 
            // botao_excluir
            // 
            botao_excluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botao_excluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botao_excluir.Depth = 0;
            botao_excluir.DrawShadows = false;
            botao_excluir.HighEmphasis = true;
            botao_excluir.Icon = null;
            botao_excluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botao_excluir.Location = new Point(721, 473);
            botao_excluir.Margin = new Padding(4, 6, 4, 6);
            botao_excluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botao_excluir.Name = "botao_excluir";
            botao_excluir.NoAccentTextColor = Color.Empty;
            botao_excluir.Size = new Size(80, 36);
            botao_excluir.TabIndex = 2;
            botao_excluir.Text = "excluir";
            botao_excluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botao_excluir.UseAccentColor = false;
            botao_excluir.UseVisualStyleBackColor = true;
            botao_excluir.Click += botao_excluir_Click;
            // 
            // botao_novo
            // 
            botao_novo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            botao_novo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            botao_novo.Depth = 0;
            botao_novo.HighEmphasis = true;
            botao_novo.Icon = null;
            botao_novo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            botao_novo.Location = new Point(537, 473);
            botao_novo.Margin = new Padding(4, 6, 4, 6);
            botao_novo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            botao_novo.Name = "botao_novo";
            botao_novo.NoAccentTextColor = Color.Empty;
            botao_novo.Size = new Size(64, 36);
            botao_novo.TabIndex = 0;
            botao_novo.Text = "novo";
            botao_novo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            botao_novo.UseAccentColor = false;
            botao_novo.UseVisualStyleBackColor = true;
            botao_novo.Click += botao_novo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cadastro.png");
            imageList1.Images.SetKeyName(1, "consulta.png");
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 630);
            Controls.Add(TabControlCadastro);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControlCadastro;
            Name = "CadastroBase";
            Text = "CadastroBase";
            TabControlCadastro.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton botao_salvar;
        private ReaLTaiizor.Controls.MaterialButton botao_cancelar;
        private ReaLTaiizor.Controls.MaterialButton botao_novo;
        private DataGridView dataGridViewConsulta;
        private ImageList imageList1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ReaLTaiizor.Controls.MaterialButton botao_editar;
        private ReaLTaiizor.Controls.MaterialButton botao_de_cancelar;
        protected ReaLTaiizor.Controls.MaterialButton botao_excluir;
        protected ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        protected TabPage tabPage1;
        protected TabPage tabPage2;
    }
}