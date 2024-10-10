namespace Henriquez_Marcos_Paint
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnPincel = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnBorrador = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnFull = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnLimpiar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnColorfondo = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnGotero = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnSpray = new ToolStripButton();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            Brocha1 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            btnTriagulo = new Button();
            btnStrella = new Button();
            btnLinea = new Button();
            btnRectangulo = new Button();
            btnCirculo = new Button();
            panel3 = new Panel();
            trackr = new TrackBar();
            pictureBox3 = new PictureBox();
            trackSize = new TrackBar();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pic_color = new Panel();
            Olores = new Label();
            btnColor = new Button();
            saveFileDialog1 = new SaveFileDialog();
            Canva = new PictureBox();
            colorDialog1 = new ColorDialog();
            panelInicio = new Panel();
            btnStart = new Button();
            lbText2 = new Label();
            lbText1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            colorDialog2 = new ColorDialog();
            colorDialog3 = new ColorDialog();
            pictureBox5 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canva).BeginInit();
            panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, archivoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, salirToolStripMenuItem, guardarComoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(150, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(150, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(150, 22);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(108, 185, 179);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnPincel, toolStripSeparator1, btnBorrador, toolStripSeparator2, btnFull, toolStripSeparator5, btnLimpiar, toolStripSeparator3, btnColorfondo, toolStripSeparator4, btnGotero, toolStripSeparator6, btnSpray });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(24, 598);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnPincel
            // 
            btnPincel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPincel.Image = Properties.Resources.Paintbrush;
            btnPincel.ImageTransparentColor = Color.Magenta;
            btnPincel.Name = "btnPincel";
            btnPincel.Size = new Size(21, 20);
            btnPincel.Text = "Pincel";
            btnPincel.Click += btnPincel_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(21, 6);
            // 
            // btnBorrador
            // 
            btnBorrador.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBorrador.Image = Properties.Resources.Erase;
            btnBorrador.ImageTransparentColor = Color.Magenta;
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(21, 20);
            btnBorrador.Text = "Borrador";
            btnBorrador.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(21, 6);
            // 
            // btnFull
            // 
            btnFull.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFull.Image = Properties.Resources.Fill_Color;
            btnFull.ImageTransparentColor = Color.Magenta;
            btnFull.Name = "btnFull";
            btnFull.Size = new Size(21, 20);
            btnFull.Text = "toolStripButton1";
            btnFull.Click += btnFull_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(21, 6);
            // 
            // btnLimpiar
            // 
            btnLimpiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLimpiar.Image = Properties.Resources.Trash;
            btnLimpiar.ImageTransparentColor = Color.Magenta;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(21, 20);
            btnLimpiar.Text = "Limpiar todo";
            btnLimpiar.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(21, 6);
            // 
            // btnColorfondo
            // 
            btnColorfondo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnColorfondo.ForeColor = Color.Black;
            btnColorfondo.Image = Properties.Resources.Picture;
            btnColorfondo.ImageTransparentColor = Color.Magenta;
            btnColorfondo.Name = "btnColorfondo";
            btnColorfondo.Size = new Size(21, 20);
            btnColorfondo.Text = "Cambiar color de fondo";
            btnColorfondo.Click += btnColorfondo_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(21, 6);
            // 
            // btnGotero
            // 
            btnGotero.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGotero.Image = Properties.Resources.Color_Dropper;
            btnGotero.ImageTransparentColor = Color.Magenta;
            btnGotero.Name = "btnGotero";
            btnGotero.Size = new Size(21, 20);
            btnGotero.Text = "toolStripButton1";
            btnGotero.Click += btnGotero_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(21, 6);
            // 
            // btnSpray
            // 
            btnSpray.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSpray.Image = Properties.Resources.Spray;
            btnSpray.ImageTransparentColor = Color.Magenta;
            btnSpray.Name = "btnSpray";
            btnSpray.Size = new Size(21, 20);
            btnSpray.Text = "toolStripButton1";
            btnSpray.Click += btnSpray_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 185, 179);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(24, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 103);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(85, 144, 140);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(Brocha1);
            panel4.Location = new Point(561, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 104);
            panel4.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bricha3;
            pictureBox4.Location = new Point(20, 36);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 21);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Brocha1
            // 
            Brocha1.BackColor = Color.White;
            Brocha1.Location = new Point(20, 10);
            Brocha1.Name = "Brocha1";
            Brocha1.Size = new Size(140, 20);
            Brocha1.TabIndex = 0;
            Brocha1.Click += Brocha1_Click;
            Brocha1.Paint += Brocha1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(85, 144, 140);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(panel5);
            panel6.Location = new Point(367, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(179, 100);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 69);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "Figuras";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(btnTriagulo);
            panel5.Controls.Add(btnStrella);
            panel5.Controls.Add(btnLinea);
            panel5.Controls.Add(btnRectangulo);
            panel5.Controls.Add(btnCirculo);
            panel5.Location = new Point(23, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(136, 62);
            panel5.TabIndex = 6;
            // 
            // btnTriagulo
            // 
            btnTriagulo.FlatAppearance.BorderSize = 0;
            btnTriagulo.FlatStyle = FlatStyle.Flat;
            btnTriagulo.Image = Properties.Resources.Triangle1;
            btnTriagulo.Location = new Point(107, 4);
            btnTriagulo.Name = "btnTriagulo";
            btnTriagulo.Size = new Size(20, 20);
            btnTriagulo.TabIndex = 6;
            btnTriagulo.UseVisualStyleBackColor = true;
            btnTriagulo.Click += btnTriagulo_Click;
            // 
            // btnStrella
            // 
            btnStrella.FlatAppearance.BorderSize = 0;
            btnStrella.FlatStyle = FlatStyle.Flat;
            btnStrella.Image = Properties.Resources.Star;
            btnStrella.Location = new Point(81, 4);
            btnStrella.Name = "btnStrella";
            btnStrella.Size = new Size(20, 20);
            btnStrella.TabIndex = 5;
            btnStrella.UseVisualStyleBackColor = true;
            btnStrella.Click += btnStrella_Click;
            // 
            // btnLinea
            // 
            btnLinea.FlatAppearance.BorderSize = 0;
            btnLinea.FlatStyle = FlatStyle.Flat;
            btnLinea.Image = Properties.Resources.Line;
            btnLinea.Location = new Point(55, 4);
            btnLinea.Name = "btnLinea";
            btnLinea.Size = new Size(20, 20);
            btnLinea.TabIndex = 4;
            btnLinea.UseVisualStyleBackColor = true;
            btnLinea.Click += btnLinea_Click;
            // 
            // btnRectangulo
            // 
            btnRectangulo.FlatAppearance.BorderSize = 0;
            btnRectangulo.FlatStyle = FlatStyle.Flat;
            btnRectangulo.Image = Properties.Resources.Rectangle;
            btnRectangulo.Location = new Point(29, 4);
            btnRectangulo.Name = "btnRectangulo";
            btnRectangulo.Size = new Size(20, 20);
            btnRectangulo.TabIndex = 2;
            btnRectangulo.UseVisualStyleBackColor = true;
            btnRectangulo.Click += btnRectangulo_Click;
            // 
            // btnCirculo
            // 
            btnCirculo.FlatAppearance.BorderSize = 0;
            btnCirculo.FlatStyle = FlatStyle.Flat;
            btnCirculo.Image = Properties.Resources.Circled_Thin;
            btnCirculo.Location = new Point(3, 4);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(20, 20);
            btnCirculo.TabIndex = 0;
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(85, 144, 140);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(trackr);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(trackSize);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(172, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(179, 100);
            panel3.TabIndex = 5;
            // 
            // trackr
            // 
            trackr.Location = new Point(57, 49);
            trackr.Maximum = 30;
            trackr.Minimum = 15;
            trackr.Name = "trackr";
            trackr.Size = new Size(104, 45);
            trackr.TabIndex = 9;
            trackr.Value = 15;
            trackr.Scroll += trackr_Scroll;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Centralized_Network;
            pictureBox3.Location = new Point(18, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 35);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // trackSize
            // 
            trackSize.Location = new Point(57, 12);
            trackSize.Minimum = 2;
            trackSize.Name = "trackSize";
            trackSize.Size = new Size(104, 45);
            trackSize.TabIndex = 6;
            trackSize.Value = 2;
            trackSize.Scroll += trackSize_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, -1);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 7;
            label1.Text = "Tamaño";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Paint;
            pictureBox2.Location = new Point(18, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 35);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(85, 144, 140);
            panel2.Controls.Add(pic_color);
            panel2.Controls.Add(Olores);
            panel2.Controls.Add(btnColor);
            panel2.Location = new Point(12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 103);
            panel2.TabIndex = 0;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.Black;
            pic_color.Location = new Point(84, 26);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(50, 47);
            pic_color.TabIndex = 5;
            // 
            // Olores
            // 
            Olores.AutoSize = true;
            Olores.BackColor = Color.Transparent;
            Olores.Location = new Point(11, 53);
            Olores.Name = "Olores";
            Olores.Size = new Size(0, 15);
            Olores.TabIndex = 3;
            Olores.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnColor
            // 
            btnColor.FlatAppearance.BorderSize = 0;
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Image = Properties.Resources.Paint_Palette4;
            btnColor.Location = new Point(11, 16);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(67, 62);
            btnColor.TabIndex = 4;
            btnColor.Text = "Colores";
            btnColor.TextAlign = ContentAlignment.BottomCenter;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Canva
            // 
            Canva.BackColor = Color.White;
            Canva.Dock = DockStyle.Fill;
            Canva.Location = new Point(24, 127);
            Canva.Name = "Canva";
            Canva.Size = new Size(936, 495);
            Canva.TabIndex = 3;
            Canva.TabStop = false;
            Canva.Paint += Canva_Paint;
            Canva.MouseClick += Canva_MouseClick;
            Canva.MouseDown += Canva_MouseDown;
            Canva.MouseMove += Canva_MouseMove;
            Canva.MouseUp += Canva_MouseUp;
            // 
            // panelInicio
            // 
            panelInicio.BackColor = Color.Black;
            panelInicio.Controls.Add(btnStart);
            panelInicio.Controls.Add(lbText2);
            panelInicio.Controls.Add(lbText1);
            panelInicio.Controls.Add(pictureBox1);
            panelInicio.Location = new Point(-1000, 500);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(957, 622);
            panelInicio.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 12F);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(-1000, 500);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(98, 29);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbText2
            // 
            lbText2.AutoSize = true;
            lbText2.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold);
            lbText2.ForeColor = Color.White;
            lbText2.Location = new Point(-1000, 500);
            lbText2.Name = "lbText2";
            lbText2.Size = new Size(96, 30);
            lbText2.TabIndex = 2;
            lbText2.Text = "© D-Lux";
            // 
            // lbText1
            // 
            lbText1.AutoSize = true;
            lbText1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lbText1.ForeColor = Color.White;
            lbText1.Location = new Point(-1000, 500);
            lbText1.Name = "lbText1";
            lbText1.Size = new Size(170, 54);
            lbText1.TabIndex = 1;
            lbText1.Text = "Canvart";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Dlux;
            pictureBox1.Location = new Point(-1000, 500);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 150;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.TexturaB1;
            pictureBox5.Location = new Point(20, 63);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(140, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 622);
            Controls.Add(panelInicio);
            Controls.Add(Canva);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Canvart";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Canva).EndInit();
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnPincel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnBorrador;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnLimpiar;
        private ToolStripSeparator toolStripSeparator3;
        private Panel panel1;
        private Label Olores;
        private Panel panel3;
        private PictureBox pictureBox2;
        private ToolStripButton btnColorfondo;
        private ToolStripSeparator toolStripSeparator4;
        private Label label1;
        private TrackBar trackSize;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
        private Button btnColor;
        private Panel pic_color;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Button btnRectangulo;
        private Button btnCirculo;
        private Button btnLinea;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private PictureBox Canva;
        private Button btnStrella;
        private Button btnTriagulo;
        private ColorDialog colorDialog1;
        private ToolStripButton btnFull;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnGotero;
        private Panel panelInicio;
        private PictureBox pictureBox1;
        private Label lbText1;
        private Label lbText2;
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnSpray;
        private PictureBox pictureBox3;
        private TrackBar trackr;
        private Panel panel4;
        private Panel Brocha1;
        private ColorDialog colorDialog2;
        private ColorDialog colorDialog3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
