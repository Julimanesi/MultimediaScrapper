﻿namespace GoogleScrapper
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            VideoTag = new TabPage();
            panelResultado = new Panel();
            DescargVideosBTN = new Button();
            SeleccionarTodosBTN = new Button();
            ResultadosTotalesLabel = new Label();
            AgregarEnviarSMplayerBTN = new Button();
            panelProgreso = new Panel();
            ResultadosActualesProgressBar = new ProgressBar();
            NumResultadosActulabel = new Label();
            VideoNumPagprogressBar = new ProgressBar();
            PaginasVisitadasLabel = new Label();
            NumeroPagTotalesLabel = new Label();
            LinkVideosLB = new ListBox();
            resultadoVideoBindingSource = new BindingSource(components);
            panel1 = new Panel();
            FechaFinlabel = new Label();
            FechaIniciolabel = new Label();
            label1 = new Label();
            BuscarVideoTB = new TextBox();
            SoloListaExtYtdlCKBX = new CheckBox();
            FechaFinDTP = new DateTimePicker();
            BuscarVideoBTN = new Button();
            FechaInicioDTP = new DateTimePicker();
            DuracionVideoCOMBX = new ComboBox();
            AltaCalidadCKBX = new CheckBox();
            FechaVideoCOMBX = new ComboBox();
            label2 = new Label();
            NumMinResultVideoNM = new NumericUpDown();
            YoutubeTag = new TabPage();
            ResultadosYouTubeFlowLayPanel = new FlowLayoutPanel();
            BotoneraYoutube = new Panel();
            DescargVideosYouTbBTN = new Button();
            SeleccionarTodosYouTubeBTN = new Button();
            ResultadosTotalesYouTbLabel = new Label();
            AgregarEnviarSMplayerYoutbBTN = new Button();
            panel2 = new Panel();
            CategoriaComboBox = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            DefinicionComboBox = new ComboBox();
            label12 = new Label();
            SubtitulosComboBox = new ComboBox();
            label11 = new Label();
            SafeSearchComboBox = new ComboBox();
            label10 = new Label();
            OrdenComboBox = new ComboBox();
            label9 = new Label();
            PaisComboBox = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            NumColumnasResultNM = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BuscarYoutubVideoTB = new TextBox();
            FinYoutbDTP = new DateTimePicker();
            BuscarYoutubeBTN = new Button();
            InicioYoutbDTP = new DateTimePicker();
            DuracionYoutubeVideoCBX = new ComboBox();
            label6 = new Label();
            MaxResultYoutubeNM = new NumericUpDown();
            ImagenTag = new TabPage();
            VerificarVideosbackgrWorker = new System.ComponentModel.BackgroundWorker();
            TipoComboBox = new ComboBox();
            label15 = new Label();
            tabControl1.SuspendLayout();
            VideoTag.SuspendLayout();
            panelResultado.SuspendLayout();
            panelProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultadoVideoBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumMinResultVideoNM).BeginInit();
            YoutubeTag.SuspendLayout();
            BotoneraYoutube.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumColumnasResultNM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxResultYoutubeNM).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(VideoTag);
            tabControl1.Controls.Add(YoutubeTag);
            tabControl1.Controls.Add(ImagenTag);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1179, 662);
            tabControl1.TabIndex = 0;
            // 
            // VideoTag
            // 
            VideoTag.Controls.Add(panelResultado);
            VideoTag.Controls.Add(panelProgreso);
            VideoTag.Controls.Add(LinkVideosLB);
            VideoTag.Controls.Add(panel1);
            VideoTag.Location = new Point(4, 29);
            VideoTag.Name = "VideoTag";
            VideoTag.Padding = new Padding(3);
            VideoTag.Size = new Size(1171, 629);
            VideoTag.TabIndex = 0;
            VideoTag.Text = "General Videos";
            VideoTag.UseVisualStyleBackColor = true;
            // 
            // panelResultado
            // 
            panelResultado.Controls.Add(DescargVideosBTN);
            panelResultado.Controls.Add(SeleccionarTodosBTN);
            panelResultado.Controls.Add(ResultadosTotalesLabel);
            panelResultado.Controls.Add(AgregarEnviarSMplayerBTN);
            panelResultado.Location = new Point(3, 237);
            panelResultado.Name = "panelResultado";
            panelResultado.Size = new Size(1165, 47);
            panelResultado.TabIndex = 20;
            panelResultado.Visible = false;
            // 
            // DescargVideosBTN
            // 
            DescargVideosBTN.Location = new Point(367, 7);
            DescargVideosBTN.Name = "DescargVideosBTN";
            DescargVideosBTN.Size = new Size(244, 29);
            DescargVideosBTN.TabIndex = 18;
            DescargVideosBTN.Text = "Descargar Videos Seleccionados";
            DescargVideosBTN.UseVisualStyleBackColor = true;
            DescargVideosBTN.Click += DescargVideosBTN_Click;
            // 
            // SeleccionarTodosBTN
            // 
            SeleccionarTodosBTN.Location = new Point(673, 7);
            SeleccionarTodosBTN.Name = "SeleccionarTodosBTN";
            SeleccionarTodosBTN.Size = new Size(163, 29);
            SeleccionarTodosBTN.TabIndex = 17;
            SeleccionarTodosBTN.Text = "Seleccionar Todos";
            SeleccionarTodosBTN.UseVisualStyleBackColor = true;
            SeleccionarTodosBTN.Click += SeleccionarTodosButton_Click;
            // 
            // ResultadosTotalesLabel
            // 
            ResultadosTotalesLabel.AutoSize = true;
            ResultadosTotalesLabel.Location = new Point(937, 11);
            ResultadosTotalesLabel.Name = "ResultadosTotalesLabel";
            ResultadosTotalesLabel.Size = new Size(131, 20);
            ResultadosTotalesLabel.TabIndex = 16;
            ResultadosTotalesLabel.Text = "ResultadosTotales:";
            // 
            // AgregarEnviarSMplayerBTN
            // 
            AgregarEnviarSMplayerBTN.Location = new Point(5, 6);
            AgregarEnviarSMplayerBTN.Name = "AgregarEnviarSMplayerBTN";
            AgregarEnviarSMplayerBTN.Size = new Size(301, 30);
            AgregarEnviarSMplayerBTN.TabIndex = 15;
            AgregarEnviarSMplayerBTN.Text = "Agregar/Enviar seleccionados a Smplayer";
            AgregarEnviarSMplayerBTN.UseVisualStyleBackColor = true;
            AgregarEnviarSMplayerBTN.Click += AgregarEnviarSmplayer_Click;
            // 
            // panelProgreso
            // 
            panelProgreso.Controls.Add(ResultadosActualesProgressBar);
            panelProgreso.Controls.Add(NumResultadosActulabel);
            panelProgreso.Controls.Add(VideoNumPagprogressBar);
            panelProgreso.Controls.Add(PaginasVisitadasLabel);
            panelProgreso.Controls.Add(NumeroPagTotalesLabel);
            panelProgreso.Location = new Point(3, 147);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.Size = new Size(1165, 84);
            panelProgreso.TabIndex = 19;
            panelProgreso.Visible = false;
            // 
            // ResultadosActualesProgressBar
            // 
            ResultadosActualesProgressBar.Location = new Point(255, 39);
            ResultadosActualesProgressBar.Name = "ResultadosActualesProgressBar";
            ResultadosActualesProgressBar.Size = new Size(289, 29);
            ResultadosActualesProgressBar.TabIndex = 16;
            // 
            // NumResultadosActulabel
            // 
            NumResultadosActulabel.AutoSize = true;
            NumResultadosActulabel.Location = new Point(5, 44);
            NumResultadosActulabel.Name = "NumResultadosActulabel";
            NumResultadosActulabel.Size = new Size(223, 20);
            NumResultadosActulabel.TabIndex = 15;
            NumResultadosActulabel.Text = "Numero de Resultados Actuales:";
            // 
            // VideoNumPagprogressBar
            // 
            VideoNumPagprogressBar.Location = new Point(699, 40);
            VideoNumPagprogressBar.Name = "VideoNumPagprogressBar";
            VideoNumPagprogressBar.Size = new Size(454, 28);
            VideoNumPagprogressBar.Step = 1;
            VideoNumPagprogressBar.TabIndex = 12;
            // 
            // PaginasVisitadasLabel
            // 
            PaginasVisitadasLabel.AutoSize = true;
            PaginasVisitadasLabel.Location = new Point(541, 44);
            PaginasVisitadasLabel.Name = "PaginasVisitadasLabel";
            PaginasVisitadasLabel.Size = new Size(125, 20);
            PaginasVisitadasLabel.TabIndex = 13;
            PaginasVisitadasLabel.Text = "Paginas Visitadas:";
            // 
            // NumeroPagTotalesLabel
            // 
            NumeroPagTotalesLabel.AutoSize = true;
            NumeroPagTotalesLabel.Location = new Point(5, 12);
            NumeroPagTotalesLabel.Name = "NumeroPagTotalesLabel";
            NumeroPagTotalesLabel.Size = new Size(226, 20);
            NumeroPagTotalesLabel.TabIndex = 14;
            NumeroPagTotalesLabel.Text = "Numero de Paginas encontradas:";
            // 
            // LinkVideosLB
            // 
            LinkVideosLB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LinkVideosLB.DataSource = resultadoVideoBindingSource;
            LinkVideosLB.DisplayMember = "Title";
            LinkVideosLB.FormattingEnabled = true;
            LinkVideosLB.HorizontalScrollbar = true;
            LinkVideosLB.ItemHeight = 20;
            LinkVideosLB.Location = new Point(3, 282);
            LinkVideosLB.Name = "LinkVideosLB";
            LinkVideosLB.SelectionMode = SelectionMode.MultiExtended;
            LinkVideosLB.Size = new Size(1165, 344);
            LinkVideosLB.TabIndex = 9;
            LinkVideosLB.ValueMember = "URLVideo";
            LinkVideosLB.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            LinkVideosLB.DoubleClick += LinVideoDoubleClick;
            // 
            // resultadoVideoBindingSource
            // 
            resultadoVideoBindingSource.DataSource = typeof(ResultadoVideo);
            // 
            // panel1
            // 
            panel1.Controls.Add(FechaFinlabel);
            panel1.Controls.Add(FechaIniciolabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BuscarVideoTB);
            panel1.Controls.Add(SoloListaExtYtdlCKBX);
            panel1.Controls.Add(FechaFinDTP);
            panel1.Controls.Add(BuscarVideoBTN);
            panel1.Controls.Add(FechaInicioDTP);
            panel1.Controls.Add(DuracionVideoCOMBX);
            panel1.Controls.Add(AltaCalidadCKBX);
            panel1.Controls.Add(FechaVideoCOMBX);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NumMinResultVideoNM);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 144);
            panel1.TabIndex = 21;
            // 
            // FechaFinlabel
            // 
            FechaFinlabel.AutoSize = true;
            FechaFinlabel.Location = new Point(678, 107);
            FechaFinlabel.Name = "FechaFinlabel";
            FechaFinlabel.Size = new Size(73, 20);
            FechaFinlabel.TabIndex = 20;
            FechaFinlabel.Text = "Fecha Fin:";
            FechaFinlabel.Visible = false;
            // 
            // FechaIniciolabel
            // 
            FechaIniciolabel.AutoSize = true;
            FechaIniciolabel.Location = new Point(168, 110);
            FechaIniciolabel.Name = "FechaIniciolabel";
            FechaIniciolabel.Size = new Size(90, 20);
            FechaIniciolabel.TabIndex = 19;
            FechaIniciolabel.Text = "Fecha Inicio:";
            FechaIniciolabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // BuscarVideoTB
            // 
            BuscarVideoTB.Location = new Point(61, 13);
            BuscarVideoTB.Name = "BuscarVideoTB";
            BuscarVideoTB.Size = new Size(550, 27);
            BuscarVideoTB.TabIndex = 0;
            // 
            // SoloListaExtYtdlCKBX
            // 
            SoloListaExtYtdlCKBX.AutoSize = true;
            SoloListaExtYtdlCKBX.Checked = true;
            SoloListaExtYtdlCKBX.CheckState = CheckState.Checked;
            SoloListaExtYtdlCKBX.Location = new Point(631, 15);
            SoloListaExtYtdlCKBX.Name = "SoloListaExtYtdlCKBX";
            SoloListaExtYtdlCKBX.Size = new Size(207, 24);
            SoloListaExtYtdlCKBX.TabIndex = 2;
            SoloListaExtYtdlCKBX.Text = "Solo Lista Extractores yt-dl";
            SoloListaExtYtdlCKBX.UseVisualStyleBackColor = true;
            // 
            // FechaFinDTP
            // 
            FechaFinDTP.Location = new Point(757, 102);
            FechaFinDTP.Name = "FechaFinDTP";
            FechaFinDTP.Size = new Size(295, 27);
            FechaFinDTP.TabIndex = 18;
            FechaFinDTP.Visible = false;
            // 
            // BuscarVideoBTN
            // 
            BuscarVideoBTN.Location = new Point(5, 103);
            BuscarVideoBTN.Name = "BuscarVideoBTN";
            BuscarVideoBTN.Size = new Size(94, 29);
            BuscarVideoBTN.TabIndex = 3;
            BuscarVideoBTN.Text = "Buscar";
            BuscarVideoBTN.UseVisualStyleBackColor = true;
            BuscarVideoBTN.Click += BuscarVideoBTN_Click;
            // 
            // FechaInicioDTP
            // 
            FechaInicioDTP.Location = new Point(264, 105);
            FechaInicioDTP.Name = "FechaInicioDTP";
            FechaInicioDTP.Size = new Size(293, 27);
            FechaInicioDTP.TabIndex = 17;
            FechaInicioDTP.Visible = false;
            // 
            // DuracionVideoCOMBX
            // 
            DuracionVideoCOMBX.FormattingEnabled = true;
            DuracionVideoCOMBX.Items.AddRange(new object[] { "Todas las duraciones", "Corto (de 0 a 4 min)", "Mediana (de 4 a 20 min)", "Larga (20 min o más)" });
            DuracionVideoCOMBX.Location = new Point(61, 60);
            DuracionVideoCOMBX.Name = "DuracionVideoCOMBX";
            DuracionVideoCOMBX.Size = new Size(264, 28);
            DuracionVideoCOMBX.TabIndex = 4;
            DuracionVideoCOMBX.Text = "Duracion";
            // 
            // AltaCalidadCKBX
            // 
            AltaCalidadCKBX.AutoSize = true;
            AltaCalidadCKBX.Location = new Point(673, 62);
            AltaCalidadCKBX.Name = "AltaCalidadCKBX";
            AltaCalidadCKBX.Size = new Size(113, 24);
            AltaCalidadCKBX.TabIndex = 16;
            AltaCalidadCKBX.Text = "Alta Calidad";
            AltaCalidadCKBX.UseVisualStyleBackColor = true;
            // 
            // FechaVideoCOMBX
            // 
            FechaVideoCOMBX.FormattingEnabled = true;
            FechaVideoCOMBX.Items.AddRange(new object[] { "De Cualquier Fecha", "Ultima Hora", "Ultimas 24 Horas", "Ultima Semana", "Ultimo Mes", "Ultimo Año", "Personalizar" });
            FechaVideoCOMBX.Location = new Point(388, 60);
            FechaVideoCOMBX.Name = "FechaVideoCOMBX";
            FechaVideoCOMBX.Size = new Size(252, 28);
            FechaVideoCOMBX.TabIndex = 5;
            FechaVideoCOMBX.Text = "Fecha";
            FechaVideoCOMBX.SelectedIndexChanged += FechaVideoCB_Changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(883, 17);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 7;
            label2.Text = "Nro minimo de resultados:";
            // 
            // NumMinResultVideoNM
            // 
            NumMinResultVideoNM.Location = new Point(1074, 15);
            NumMinResultVideoNM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumMinResultVideoNM.Name = "NumMinResultVideoNM";
            NumMinResultVideoNM.Size = new Size(79, 27);
            NumMinResultVideoNM.TabIndex = 6;
            NumMinResultVideoNM.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // YoutubeTag
            // 
            YoutubeTag.Controls.Add(ResultadosYouTubeFlowLayPanel);
            YoutubeTag.Controls.Add(BotoneraYoutube);
            YoutubeTag.Controls.Add(panel2);
            YoutubeTag.Location = new Point(4, 29);
            YoutubeTag.Name = "YoutubeTag";
            YoutubeTag.Size = new Size(1171, 629);
            YoutubeTag.TabIndex = 2;
            YoutubeTag.Text = "YouTube";
            YoutubeTag.UseVisualStyleBackColor = true;
            // 
            // ResultadosYouTubeFlowLayPanel
            // 
            ResultadosYouTubeFlowLayPanel.AutoScroll = true;
            ResultadosYouTubeFlowLayPanel.AutoSize = true;
            ResultadosYouTubeFlowLayPanel.Dock = DockStyle.Fill;
            ResultadosYouTubeFlowLayPanel.Location = new Point(0, 244);
            ResultadosYouTubeFlowLayPanel.Name = "ResultadosYouTubeFlowLayPanel";
            ResultadosYouTubeFlowLayPanel.Size = new Size(1171, 385);
            ResultadosYouTubeFlowLayPanel.TabIndex = 0;
            // 
            // BotoneraYoutube
            // 
            BotoneraYoutube.Controls.Add(DescargVideosYouTbBTN);
            BotoneraYoutube.Controls.Add(SeleccionarTodosYouTubeBTN);
            BotoneraYoutube.Controls.Add(ResultadosTotalesYouTbLabel);
            BotoneraYoutube.Controls.Add(AgregarEnviarSMplayerYoutbBTN);
            BotoneraYoutube.Dock = DockStyle.Top;
            BotoneraYoutube.Location = new Point(0, 197);
            BotoneraYoutube.Name = "BotoneraYoutube";
            BotoneraYoutube.Size = new Size(1171, 47);
            BotoneraYoutube.TabIndex = 23;
            BotoneraYoutube.Visible = false;
            // 
            // DescargVideosYouTbBTN
            // 
            DescargVideosYouTbBTN.Location = new Point(367, 7);
            DescargVideosYouTbBTN.Name = "DescargVideosYouTbBTN";
            DescargVideosYouTbBTN.Size = new Size(244, 29);
            DescargVideosYouTbBTN.TabIndex = 18;
            DescargVideosYouTbBTN.Text = "Descargar Videos Seleccionados";
            DescargVideosYouTbBTN.UseVisualStyleBackColor = true;
            DescargVideosYouTbBTN.Click += DescargVideosYouTbBTN_Click;
            // 
            // SeleccionarTodosYouTubeBTN
            // 
            SeleccionarTodosYouTubeBTN.Location = new Point(673, 7);
            SeleccionarTodosYouTubeBTN.Name = "SeleccionarTodosYouTubeBTN";
            SeleccionarTodosYouTubeBTN.Size = new Size(163, 29);
            SeleccionarTodosYouTubeBTN.TabIndex = 17;
            SeleccionarTodosYouTubeBTN.Text = "Seleccionar Todos";
            SeleccionarTodosYouTubeBTN.UseVisualStyleBackColor = true;
            SeleccionarTodosYouTubeBTN.Click += SeleccionarTodosYouTubeBTN_Click;
            // 
            // ResultadosTotalesYouTbLabel
            // 
            ResultadosTotalesYouTbLabel.AutoSize = true;
            ResultadosTotalesYouTbLabel.Location = new Point(937, 11);
            ResultadosTotalesYouTbLabel.Name = "ResultadosTotalesYouTbLabel";
            ResultadosTotalesYouTbLabel.Size = new Size(131, 20);
            ResultadosTotalesYouTbLabel.TabIndex = 16;
            ResultadosTotalesYouTbLabel.Text = "ResultadosTotales:";
            // 
            // AgregarEnviarSMplayerYoutbBTN
            // 
            AgregarEnviarSMplayerYoutbBTN.Location = new Point(5, 6);
            AgregarEnviarSMplayerYoutbBTN.Name = "AgregarEnviarSMplayerYoutbBTN";
            AgregarEnviarSMplayerYoutbBTN.Size = new Size(301, 30);
            AgregarEnviarSMplayerYoutbBTN.TabIndex = 15;
            AgregarEnviarSMplayerYoutbBTN.Text = "Agregar/Enviar seleccionados a Smplayer";
            AgregarEnviarSMplayerYoutbBTN.UseVisualStyleBackColor = true;
            AgregarEnviarSMplayerYoutbBTN.Click += AgregarEnviarSMplayerYoutbBTN_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Controls.Add(TipoComboBox);
            panel2.Controls.Add(CategoriaComboBox);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(DefinicionComboBox);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(SubtitulosComboBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(SafeSearchComboBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(OrdenComboBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(PaisComboBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(NumColumnasResultNM);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(BuscarYoutubVideoTB);
            panel2.Controls.Add(FinYoutbDTP);
            panel2.Controls.Add(BuscarYoutubeBTN);
            panel2.Controls.Add(InicioYoutbDTP);
            panel2.Controls.Add(DuracionYoutubeVideoCBX);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(MaxResultYoutubeNM);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1171, 197);
            panel2.TabIndex = 22;
            // 
            // CategoriaComboBox
            // 
            CategoriaComboBox.FormattingEnabled = true;
            CategoriaComboBox.Location = new Point(861, 14);
            CategoriaComboBox.Name = "CategoriaComboBox";
            CategoriaComboBox.Size = new Size(285, 28);
            CategoriaComboBox.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(778, 16);
            label14.Name = "label14";
            label14.Size = new Size(77, 20);
            label14.TabIndex = 35;
            label14.Text = "Categoria:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(523, 145);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 33;
            label13.Text = "Definicion:";
            // 
            // DefinicionComboBox
            // 
            DefinicionComboBox.FormattingEnabled = true;
            DefinicionComboBox.Location = new Point(607, 142);
            DefinicionComboBox.Name = "DefinicionComboBox";
            DefinicionComboBox.Size = new Size(168, 28);
            DefinicionComboBox.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(257, 145);
            label12.Name = "label12";
            label12.Size = new Size(78, 20);
            label12.TabIndex = 31;
            label12.Text = "Subtitulos:";
            // 
            // SubtitulosComboBox
            // 
            SubtitulosComboBox.FormattingEnabled = true;
            SubtitulosComboBox.Location = new Point(341, 142);
            SubtitulosComboBox.Name = "SubtitulosComboBox";
            SubtitulosComboBox.Size = new Size(168, 28);
            SubtitulosComboBox.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(607, 107);
            label11.Name = "label11";
            label11.Size = new Size(127, 20);
            label11.TabIndex = 29;
            label11.Text = "Busqueda Segura:";
            // 
            // SafeSearchComboBox
            // 
            SafeSearchComboBox.FormattingEnabled = true;
            SafeSearchComboBox.Location = new Point(740, 103);
            SafeSearchComboBox.Name = "SafeSearchComboBox";
            SafeSearchComboBox.Size = new Size(168, 28);
            SafeSearchComboBox.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(374, 106);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 27;
            label10.Text = "Orden:";
            // 
            // OrdenComboBox
            // 
            OrdenComboBox.FormattingEnabled = true;
            OrdenComboBox.Location = new Point(433, 103);
            OrdenComboBox.Name = "OrdenComboBox";
            OrdenComboBox.Size = new Size(168, 28);
            OrdenComboBox.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(114, 106);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 25;
            label9.Text = "Pais:";
            // 
            // PaisComboBox
            // 
            PaisComboBox.FormattingEnabled = true;
            PaisComboBox.Location = new Point(157, 104);
            PaisComboBox.Name = "PaisComboBox";
            PaisComboBox.Size = new Size(195, 28);
            PaisComboBox.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 63);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 23;
            label8.Text = "Duracion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(5, 145);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 22;
            label7.Text = "Numero de Columnas:";
            // 
            // NumColumnasResultNM
            // 
            NumColumnasResultNM.Location = new Point(167, 143);
            NumColumnasResultNM.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumColumnasResultNM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumColumnasResultNM.Name = "NumColumnasResultNM";
            NumColumnasResultNM.Size = new Size(62, 27);
            NumColumnasResultNM.TabIndex = 21;
            NumColumnasResultNM.Value = new decimal(new int[] { 3, 0, 0, 0 });
            NumColumnasResultNM.ValueChanged += NumColumnasResultNM_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(689, 63);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 20;
            label3.Text = "Fecha Fin:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 63);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 19;
            label4.Text = "Fecha Inicio:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 16);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 1;
            label5.Text = "Buscar:";
            // 
            // BuscarYoutubVideoTB
            // 
            BuscarYoutubVideoTB.Location = new Point(61, 13);
            BuscarYoutubVideoTB.Name = "BuscarYoutubVideoTB";
            BuscarYoutubVideoTB.Size = new Size(701, 27);
            BuscarYoutubVideoTB.TabIndex = 0;
            // 
            // FinYoutbDTP
            // 
            FinYoutbDTP.Location = new Point(768, 58);
            FinYoutbDTP.Name = "FinYoutbDTP";
            FinYoutbDTP.Size = new Size(295, 27);
            FinYoutbDTP.TabIndex = 18;
            FinYoutbDTP.Visible = false;
            // 
            // BuscarYoutubeBTN
            // 
            BuscarYoutubeBTN.Location = new Point(5, 103);
            BuscarYoutubeBTN.Name = "BuscarYoutubeBTN";
            BuscarYoutubeBTN.Size = new Size(94, 29);
            BuscarYoutubeBTN.TabIndex = 3;
            BuscarYoutubeBTN.Text = "Buscar";
            BuscarYoutubeBTN.UseVisualStyleBackColor = true;
            BuscarYoutubeBTN.Click += BuscarYoutubeBTN_Click;
            // 
            // InicioYoutbDTP
            // 
            InicioYoutbDTP.Location = new Point(390, 58);
            InicioYoutbDTP.Name = "InicioYoutbDTP";
            InicioYoutbDTP.Size = new Size(293, 27);
            InicioYoutbDTP.TabIndex = 17;
            InicioYoutbDTP.Visible = false;
            // 
            // DuracionYoutubeVideoCBX
            // 
            DuracionYoutubeVideoCBX.FormattingEnabled = true;
            DuracionYoutubeVideoCBX.Items.AddRange(new object[] { "Todas las duraciones", "Corto (de 0 a 4 min)", "Mediana (de 4 a 20 min)", "Larga (20 min o más)" });
            DuracionYoutubeVideoCBX.Location = new Point(86, 60);
            DuracionYoutubeVideoCBX.Name = "DuracionYoutubeVideoCBX";
            DuracionYoutubeVideoCBX.Size = new Size(202, 28);
            DuracionYoutubeVideoCBX.TabIndex = 4;
            DuracionYoutubeVideoCBX.Text = "Duracion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(802, 145);
            label6.Name = "label6";
            label6.Size = new Size(188, 20);
            label6.TabIndex = 7;
            label6.Text = "Nro maximo de resultados:";
            // 
            // MaxResultYoutubeNM
            // 
            MaxResultYoutubeNM.Location = new Point(993, 143);
            MaxResultYoutubeNM.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            MaxResultYoutubeNM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MaxResultYoutubeNM.Name = "MaxResultYoutubeNM";
            MaxResultYoutubeNM.Size = new Size(79, 27);
            MaxResultYoutubeNM.TabIndex = 6;
            MaxResultYoutubeNM.TextAlign = HorizontalAlignment.Right;
            MaxResultYoutubeNM.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // ImagenTag
            // 
            ImagenTag.Location = new Point(4, 29);
            ImagenTag.Name = "ImagenTag";
            ImagenTag.Padding = new Padding(3);
            ImagenTag.Size = new Size(1171, 629);
            ImagenTag.TabIndex = 1;
            ImagenTag.Text = "Imagen";
            ImagenTag.UseVisualStyleBackColor = true;
            // 
            // VerificarVideosbackgrWorker
            // 
            VerificarVideosbackgrWorker.WorkerReportsProgress = true;
            VerificarVideosbackgrWorker.DoWork += BWVerificarVideo_Dowork;
            VerificarVideosbackgrWorker.ProgressChanged += BWVerificarVideo_Progreso;
            VerificarVideosbackgrWorker.RunWorkerCompleted += BWVerificarVideo_Resultado;
            // 
            // TipoComboBox
            // 
            TipoComboBox.FormattingEnabled = true;
            TipoComboBox.Location = new Point(985, 103);
            TipoComboBox.Name = "TipoComboBox";
            TipoComboBox.Size = new Size(168, 28);
            TipoComboBox.TabIndex = 37;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(937, 107);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 38;
            label15.Text = "Tipo:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 662);
            Controls.Add(tabControl1);
            MinimumSize = new Size(1197, 709);
            Name = "MainForm";
            Text = "Multimedia Scrapper";
            Load += MainForm_Load;
            Resize += Ajustar_imagenes;
            tabControl1.ResumeLayout(false);
            VideoTag.ResumeLayout(false);
            panelResultado.ResumeLayout(false);
            panelResultado.PerformLayout();
            panelProgreso.ResumeLayout(false);
            panelProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultadoVideoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumMinResultVideoNM).EndInit();
            YoutubeTag.ResumeLayout(false);
            YoutubeTag.PerformLayout();
            BotoneraYoutube.ResumeLayout(false);
            BotoneraYoutube.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumColumnasResultNM).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxResultYoutubeNM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage VideoTag;
        private TabPage ImagenTag;
        private ComboBox DuracionVideoCOMBX;
        private Button BuscarVideoBTN;
        private CheckBox SoloListaExtYtdlCKBX;
        private Label label1;
        private TextBox BuscarVideoTB;
        private ComboBox FechaVideoCOMBX;
        private Label label2;
        private NumericUpDown NumMinResultVideoNM;
        private ListBox LinkVideosLB;
        private BindingSource resultadoVideoBindingSource;
        private Label PaginasVisitadasLabel;
        private ProgressBar VideoNumPagprogressBar;
        private Label NumeroPagTotalesLabel;
        private Button AgregarEnviarSMplayerBTN;
        private CheckBox AltaCalidadCKBX;
        private DateTimePicker FechaFinDTP;
        private DateTimePicker FechaInicioDTP;
        private Panel panelResultado;
        private Panel panelProgreso;
        private Label ResultadosTotalesLabel;
        private Panel panel1;
        private Label FechaFinlabel;
        private Label FechaIniciolabel;
        private Button SeleccionarTodosBTN;
        private Label NumResultadosActulabel;
        private System.ComponentModel.BackgroundWorker VerificarVideosbackgrWorker;
        private ProgressBar ResultadosActualesProgressBar;
        private Button DescargVideosBTN;
        private TabPage YoutubeTag;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox BuscarYoutubVideoTB;
        private DateTimePicker FinYoutbDTP;
        private Button BuscarYoutubeBTN;
        private DateTimePicker InicioYoutbDTP;
        private ComboBox DuracionYoutubeVideoCBX;
        private Label label6;
        private NumericUpDown MaxResultYoutubeNM;
        private Panel BotoneraYoutube;
        private Button DescargVideosYouTbBTN;
        private Button SeleccionarTodosYouTubeBTN;
        private Label ResultadosTotalesYouTbLabel;
        private Button AgregarEnviarSMplayerYoutbBTN;
        private FlowLayoutPanel ResultadosYouTubeFlowLayPanel;
        private NumericUpDown NumColumnasResultNM;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox PaisComboBox;
        private Label label10;
        private ComboBox OrdenComboBox;
        private Label label11;
        private ComboBox SafeSearchComboBox;
        private Label label12;
        private ComboBox SubtitulosComboBox;
        private Label label13;
        private ComboBox DefinicionComboBox;
        private Label label14;
        private ComboBox CategoriaComboBox;
        private ComboBox TipoComboBox;
        private Label label15;
    }
}