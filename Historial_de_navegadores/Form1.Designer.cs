namespace Historial_de_navegadores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_barra_lateral = new System.Windows.Forms.Panel();
            this.panel_ocultar_panel = new System.Windows.Forms.Panel();
            this.panel_configuracion = new System.Windows.Forms.Panel();
            this.panel_explorer = new System.Windows.Forms.Panel();
            this.panel_chrome = new System.Windows.Forms.Panel();
            this.panel_firefox = new System.Windows.Forms.Panel();
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.panel_formulario1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_urls = new System.Windows.Forms.CheckBox();
            this.checkBox_descargas = new System.Windows.Forms.CheckBox();
            this.checkBox_visitas = new System.Windows.Forms.CheckBox();
            this.panel_cerrar_dataG = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_cerrar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_lista = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_cargando = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_barra_lateral.SuspendLayout();
            this.panel_formulario1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barra_lateral
            // 
            this.panel_barra_lateral.BackColor = System.Drawing.Color.Transparent;
            this.panel_barra_lateral.Controls.Add(this.panel_ocultar_panel);
            this.panel_barra_lateral.Controls.Add(this.panel_configuracion);
            this.panel_barra_lateral.Controls.Add(this.panel_explorer);
            this.panel_barra_lateral.Controls.Add(this.panel_chrome);
            this.panel_barra_lateral.Controls.Add(this.panel_firefox);
            this.panel_barra_lateral.Location = new System.Drawing.Point(108, 82);
            this.panel_barra_lateral.Name = "panel_barra_lateral";
            this.panel_barra_lateral.Size = new System.Drawing.Size(102, 361);
            this.panel_barra_lateral.TabIndex = 2;
            // 
            // panel_ocultar_panel
            // 
            this.panel_ocultar_panel.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.boton_cerrar5;
            this.panel_ocultar_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ocultar_panel.Location = new System.Drawing.Point(73, 3);
            this.panel_ocultar_panel.Name = "panel_ocultar_panel";
            this.panel_ocultar_panel.Size = new System.Drawing.Size(29, 29);
            this.panel_ocultar_panel.TabIndex = 5;
            this.panel_ocultar_panel.Click += new System.EventHandler(this.panel_ocultar_panel_Click);
            this.panel_ocultar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_ocultar_panel_MouseMove);
            // 
            // panel_configuracion
            // 
            this.panel_configuracion.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.HP_Control;
            this.panel_configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_configuracion.Location = new System.Drawing.Point(39, 245);
            this.panel_configuracion.Name = "panel_configuracion";
            this.panel_configuracion.Size = new System.Drawing.Size(54, 37);
            this.panel_configuracion.TabIndex = 4;
            this.panel_configuracion.Click += new System.EventHandler(this.panel_configuracion_Click);
            this.panel_configuracion.MouseLeave += new System.EventHandler(this.panel_configuracion_MouseLeave);
            this.panel_configuracion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_configuracion_MouseMove);
            // 
            // panel_explorer
            // 
            this.panel_explorer.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.HP_Explorer;
            this.panel_explorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_explorer.Location = new System.Drawing.Point(22, 196);
            this.panel_explorer.Name = "panel_explorer";
            this.panel_explorer.Size = new System.Drawing.Size(54, 37);
            this.panel_explorer.TabIndex = 4;
            this.panel_explorer.Click += new System.EventHandler(this.panel_explorer_Click);
            this.panel_explorer.MouseLeave += new System.EventHandler(this.panel_explorer_MouseLeave);
            this.panel_explorer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_explorer_MouseMove);
            // 
            // panel_chrome
            // 
            this.panel_chrome.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.HP_Chrome;
            this.panel_chrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_chrome.Location = new System.Drawing.Point(22, 142);
            this.panel_chrome.Name = "panel_chrome";
            this.panel_chrome.Size = new System.Drawing.Size(54, 37);
            this.panel_chrome.TabIndex = 4;
            this.panel_chrome.Click += new System.EventHandler(this.panel_chrome_Click);
            this.panel_chrome.MouseLeave += new System.EventHandler(this.panel_chrome_MouseLeave);
            this.panel_chrome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_chrome_MouseMove);
            // 
            // panel_firefox
            // 
            this.panel_firefox.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.HP_Firefox;
            this.panel_firefox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_firefox.Location = new System.Drawing.Point(39, 93);
            this.panel_firefox.Name = "panel_firefox";
            this.panel_firefox.Size = new System.Drawing.Size(54, 37);
            this.panel_firefox.TabIndex = 3;
            this.panel_firefox.Click += new System.EventHandler(this.panel_firefox_Click);
            this.panel_firefox.MouseLeave += new System.EventHandler(this.panel_firefox_MouseLeave);
            this.panel_firefox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_firefox_MouseMove);
            // 
            // panel_opciones
            // 
            this.panel_opciones.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.Holograma_planeta_dimension;
            this.panel_opciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_opciones.Location = new System.Drawing.Point(71, 23);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(69, 50);
            this.panel_opciones.TabIndex = 1;
            this.panel_opciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_opciones_MouseDown);
            this.panel_opciones.MouseLeave += new System.EventHandler(this.panel_opciones_MouseLeave);
            this.panel_opciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_opciones_MouseMove);
            // 
            // panel_formulario1
            // 
            this.panel_formulario1.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.Ventanas_futuristas;
            this.panel_formulario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_formulario1.Controls.Add(this.label_cargando);
            this.panel_formulario1.Controls.Add(this.panel_opciones);
            this.panel_formulario1.Controls.Add(this.groupBox1);
            this.panel_formulario1.Controls.Add(this.panel_cerrar);
            this.panel_formulario1.Controls.Add(this.label1);
            this.panel_formulario1.Controls.Add(this.listBox_lista);
            this.panel_formulario1.Location = new System.Drawing.Point(212, 59);
            this.panel_formulario1.Name = "panel_formulario1";
            this.panel_formulario1.Size = new System.Drawing.Size(831, 393);
            this.panel_formulario1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_urls);
            this.groupBox1.Controls.Add(this.checkBox_descargas);
            this.groupBox1.Controls.Add(this.checkBox_visitas);
            this.groupBox1.Controls.Add(this.panel_cerrar_dataG);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(86, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox_urls
            // 
            this.checkBox_urls.AutoSize = true;
            this.checkBox_urls.ForeColor = System.Drawing.Color.White;
            this.checkBox_urls.Location = new System.Drawing.Point(378, 12);
            this.checkBox_urls.Name = "checkBox_urls";
            this.checkBox_urls.Size = new System.Drawing.Size(44, 17);
            this.checkBox_urls.TabIndex = 10;
            this.checkBox_urls.Text = "Urls";
            this.checkBox_urls.UseVisualStyleBackColor = true;
            this.checkBox_urls.CheckedChanged += new System.EventHandler(this.checkBox_urls_CheckedChanged);
            // 
            // checkBox_descargas
            // 
            this.checkBox_descargas.AutoSize = true;
            this.checkBox_descargas.ForeColor = System.Drawing.Color.White;
            this.checkBox_descargas.Location = new System.Drawing.Point(262, 12);
            this.checkBox_descargas.Name = "checkBox_descargas";
            this.checkBox_descargas.Size = new System.Drawing.Size(77, 17);
            this.checkBox_descargas.TabIndex = 9;
            this.checkBox_descargas.Text = "Descargas";
            this.checkBox_descargas.UseVisualStyleBackColor = true;
            this.checkBox_descargas.CheckedChanged += new System.EventHandler(this.checkBox_descargas_CheckedChanged);
            // 
            // checkBox_visitas
            // 
            this.checkBox_visitas.AutoSize = true;
            this.checkBox_visitas.ForeColor = System.Drawing.Color.White;
            this.checkBox_visitas.Location = new System.Drawing.Point(157, 12);
            this.checkBox_visitas.Name = "checkBox_visitas";
            this.checkBox_visitas.Size = new System.Drawing.Size(56, 17);
            this.checkBox_visitas.TabIndex = 8;
            this.checkBox_visitas.Text = "Visitas";
            this.checkBox_visitas.UseVisualStyleBackColor = true;
            this.checkBox_visitas.CheckedChanged += new System.EventHandler(this.checkBox_visitas_CheckedChanged);
            // 
            // panel_cerrar_dataG
            // 
            this.panel_cerrar_dataG.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel_cerrar_dataG.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.boton_cerrar5;
            this.panel_cerrar_dataG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_cerrar_dataG.Location = new System.Drawing.Point(668, 11);
            this.panel_cerrar_dataG.Name = "panel_cerrar_dataG";
            this.panel_cerrar_dataG.Size = new System.Drawing.Size(27, 26);
            this.panel_cerrar_dataG.TabIndex = 7;
            this.panel_cerrar_dataG.Click += new System.EventHandler(this.panel_cerrar_dataG_Click);
            this.panel_cerrar_dataG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_cerrar_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 296);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel_cerrar
            // 
            this.panel_cerrar.BackgroundImage = global::Historial_de_navegadores.Properties.Resources.boton_cerrar5;
            this.panel_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_cerrar.Location = new System.Drawing.Point(745, 23);
            this.panel_cerrar.Name = "panel_cerrar";
            this.panel_cerrar.Size = new System.Drawing.Size(29, 29);
            this.panel_cerrar.TabIndex = 2;
            this.panel_cerrar.Click += new System.EventHandler(this.panel_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // listBox_lista
            // 
            this.listBox_lista.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox_lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_lista.ForeColor = System.Drawing.Color.White;
            this.listBox_lista.FormattingEnabled = true;
            this.listBox_lista.HorizontalScrollbar = true;
            this.listBox_lista.Location = new System.Drawing.Point(64, 43);
            this.listBox_lista.Name = "listBox_lista";
            this.listBox_lista.ScrollAlwaysVisible = true;
            this.listBox_lista.Size = new System.Drawing.Size(730, 312);
            this.listBox_lista.TabIndex = 4;
            this.listBox_lista.SelectedIndexChanged += new System.EventHandler(this.listBox_lista_SelectedIndexChanged);
            this.listBox_lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_lista_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Transparent;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // label_cargando
            // 
            this.label_cargando.AutoSize = true;
            this.label_cargando.BackColor = System.Drawing.SystemColors.Desktop;
            this.label_cargando.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cargando.ForeColor = System.Drawing.Color.White;
            this.label_cargando.Location = new System.Drawing.Point(58, 165);
            this.label_cargando.Name = "label_cargando";
            this.label_cargando.Size = new System.Drawing.Size(151, 32);
            this.label_cargando.TabIndex = 11;
            this.label_cargando.Text = "CARGANDO...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(468, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "HISTORIAL DE NAVEGADORES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1073, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_barra_lateral);
            this.Controls.Add(this.panel_formulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_barra_lateral.ResumeLayout(false);
            this.panel_formulario1.ResumeLayout(false);
            this.panel_formulario1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_formulario1;
        private System.Windows.Forms.Panel panel_opciones;
        private System.Windows.Forms.Panel panel_cerrar;
        private System.Windows.Forms.Panel panel_barra_lateral;
        private System.Windows.Forms.Panel panel_firefox;
        private System.Windows.Forms.Panel panel_configuracion;
        private System.Windows.Forms.Panel panel_explorer;
        private System.Windows.Forms.Panel panel_chrome;
        private System.Windows.Forms.Panel panel_ocultar_panel;
        private System.Windows.Forms.ListBox listBox_lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_cerrar_dataG;
        private System.Windows.Forms.CheckBox checkBox_descargas;
        private System.Windows.Forms.CheckBox checkBox_visitas;
        private System.Windows.Forms.CheckBox checkBox_urls;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_cargando;
        private System.Windows.Forms.Label label2;
    }
}

