
namespace agenda
{
    partial class FormCompromisso
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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxTempo = new System.Windows.Forms.ComboBox();
            this.ButtonEditarNoti = new System.Windows.Forms.Button();
            this.ButtonEditarComp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxDataFim = new System.Windows.Forms.MaskedTextBox();
            this.ButtonSalvarNoti = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TempoNotificacao = new System.Windows.Forms.NumericUpDown();
            this.labelNotificaçãoTempo = new System.Windows.Forms.Label();
            this.ButtonSalvarComp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Boxdatainicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.ButtonExcluirNoti = new System.Windows.Forms.Button();
            this.ButtonExcluirComp = new System.Windows.Forms.Button();
            this.listBoxNoti = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonFechar = new System.Windows.Forms.Button();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.listBoxConvidados = new System.Windows.Forms.ListBox();
            this.textBoxConvidado = new System.Windows.Forms.TextBox();
            this.labelEmailDoConvidado = new System.Windows.Forms.Label();
            this.buttonExcluirConvidados = new System.Windows.Forms.Button();
            this.buttonEditarConvidados = new System.Windows.Forms.Button();
            this.buttonSalvarConvidados = new System.Windows.Forms.Button();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.numericUpDownTempoLembrete = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTipoLembrete = new System.Windows.Forms.ComboBox();
            this.labelLembretRepitir = new System.Windows.Forms.Label();
            this.labelRepitir = new System.Windows.Forms.Label();
            this.checkBoxDomingo = new System.Windows.Forms.CheckBox();
            this.checkBoxSegunda = new System.Windows.Forms.CheckBox();
            this.checkBoxTerca = new System.Windows.Forms.CheckBox();
            this.checkBoxSexta = new System.Windows.Forms.CheckBox();
            this.checkBoxQuinta = new System.Windows.Forms.CheckBox();
            this.checkBoxQuarta = new System.Windows.Forms.CheckBox();
            this.checkBoxSabado = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTerminarEm = new System.Windows.Forms.Label();
            this.checkBoxNunca = new System.Windows.Forms.CheckBox();
            this.CheckBoxData = new System.Windows.Forms.CheckBox();
            this.dateTimePickerLembrete = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownOcorrenciasLembrete = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TempoNotificacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempoLembrete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcorrenciasLembrete)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.BackColor = System.Drawing.Color.White;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(290, 872);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(171, 33);
            this.comboBoxTipo.TabIndex = 52;
            // 
            // comboBoxTempo
            // 
            this.comboBoxTempo.BackColor = System.Drawing.Color.White;
            this.comboBoxTempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTempo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTempo.FormattingEnabled = true;
            this.comboBoxTempo.Location = new System.Drawing.Point(53, 872);
            this.comboBoxTempo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTempo.Name = "comboBoxTempo";
            this.comboBoxTempo.Size = new System.Drawing.Size(171, 33);
            this.comboBoxTempo.TabIndex = 50;
            // 
            // ButtonEditarNoti
            // 
            this.ButtonEditarNoti.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonEditarNoti.Location = new System.Drawing.Point(354, 760);
            this.ButtonEditarNoti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEditarNoti.Name = "ButtonEditarNoti";
            this.ButtonEditarNoti.Size = new System.Drawing.Size(107, 38);
            this.ButtonEditarNoti.TabIndex = 49;
            this.ButtonEditarNoti.Text = "editar";
            this.ButtonEditarNoti.UseVisualStyleBackColor = false;
            this.ButtonEditarNoti.Click += new System.EventHandler(this.ButtonEditarNoti_Click);
            // 
            // ButtonEditarComp
            // 
            this.ButtonEditarComp.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonEditarComp.Location = new System.Drawing.Point(205, 431);
            this.ButtonEditarComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEditarComp.Name = "ButtonEditarComp";
            this.ButtonEditarComp.Size = new System.Drawing.Size(107, 38);
            this.ButtonEditarComp.TabIndex = 48;
            this.ButtonEditarComp.Text = "editar";
            this.ButtonEditarComp.UseVisualStyleBackColor = false;
            this.ButtonEditarComp.Click += new System.EventHandler(this.ButtonEditarComp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(488, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 34);
            this.label8.TabIndex = 46;
            this.label8.Text = "Compromisso";
            // 
            // BoxDataFim
            // 
            this.BoxDataFim.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.BoxDataFim.Location = new System.Drawing.Point(88, 377);
            this.BoxDataFim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxDataFim.Mask = "09/09/9900 09:09";
            this.BoxDataFim.Name = "BoxDataFim";
            this.BoxDataFim.ResetOnSpace = false;
            this.BoxDataFim.Size = new System.Drawing.Size(203, 31);
            this.BoxDataFim.SkipLiterals = false;
            this.BoxDataFim.TabIndex = 45;
            this.BoxDataFim.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // ButtonSalvarNoti
            // 
            this.ButtonSalvarNoti.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSalvarNoti.Location = new System.Drawing.Point(77, 760);
            this.ButtonSalvarNoti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSalvarNoti.Name = "ButtonSalvarNoti";
            this.ButtonSalvarNoti.Size = new System.Drawing.Size(107, 38);
            this.ButtonSalvarNoti.TabIndex = 44;
            this.ButtonSalvarNoti.Text = "salvar";
            this.ButtonSalvarNoti.UseVisualStyleBackColor = false;
            this.ButtonSalvarNoti.Click += new System.EventHandler(this.ButtonSalvarNoti_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(276, 837);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tipo de notificação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 837);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Unidade de tempo";
            // 
            // TempoNotificacao
            // 
            this.TempoNotificacao.BackColor = System.Drawing.Color.White;
            this.TempoNotificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempoNotificacao.ForeColor = System.Drawing.Color.Black;
            this.TempoNotificacao.Location = new System.Drawing.Point(562, 871);
            this.TempoNotificacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TempoNotificacao.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.TempoNotificacao.Name = "TempoNotificacao";
            this.TempoNotificacao.Size = new System.Drawing.Size(179, 28);
            this.TempoNotificacao.TabIndex = 41;
            this.TempoNotificacao.ThousandsSeparator = true;
            // 
            // labelNotificaçãoTempo
            // 
            this.labelNotificaçãoTempo.AutoSize = true;
            this.labelNotificaçãoTempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNotificaçãoTempo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNotificaçãoTempo.Location = new System.Drawing.Point(562, 837);
            this.labelNotificaçãoTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotificaçãoTempo.Name = "labelNotificaçãoTempo";
            this.labelNotificaçãoTempo.Size = new System.Drawing.Size(74, 24);
            this.labelNotificaçãoTempo.TabIndex = 40;
            this.labelNotificaçãoTempo.Text = "Tempo";
            // 
            // ButtonSalvarComp
            // 
            this.ButtonSalvarComp.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSalvarComp.Location = new System.Drawing.Point(90, 431);
            this.ButtonSalvarComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSalvarComp.Name = "ButtonSalvarComp";
            this.ButtonSalvarComp.Size = new System.Drawing.Size(107, 38);
            this.ButtonSalvarComp.TabIndex = 38;
            this.ButtonSalvarComp.Text = "salvar";
            this.ButtonSalvarComp.UseVisualStyleBackColor = false;
            this.ButtonSalvarComp.Click += new System.EventHandler(this.ButtonSalvarComp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(88, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Data fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Data inicio";
            // 
            // Boxdatainicio
            // 
            this.Boxdatainicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Boxdatainicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.Boxdatainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Boxdatainicio.Location = new System.Drawing.Point(88, 305);
            this.Boxdatainicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Boxdatainicio.Name = "Boxdatainicio";
            this.Boxdatainicio.Size = new System.Drawing.Size(205, 31);
            this.Boxdatainicio.TabIndex = 35;
            this.Boxdatainicio.Value = new System.DateTime(2021, 10, 4, 21, 21, 28, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descrição";
            // 
            // TextBoxDescricao
            // 
            this.TextBoxDescricao.BackColor = System.Drawing.Color.White;
            this.TextBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxDescricao.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDescricao.Location = new System.Drawing.Point(88, 199);
            this.TextBoxDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDescricao.Multiline = true;
            this.TextBoxDescricao.Name = "TextBoxDescricao";
            this.TextBoxDescricao.Size = new System.Drawing.Size(343, 42);
            this.TextBoxDescricao.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.Color.White;
            this.textBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitulo.ForeColor = System.Drawing.Color.Black;
            this.textBoxTitulo.Location = new System.Drawing.Point(88, 113);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(343, 30);
            this.textBoxTitulo.TabIndex = 31;
            // 
            // ButtonExcluirNoti
            // 
            this.ButtonExcluirNoti.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonExcluirNoti.Location = new System.Drawing.Point(619, 760);
            this.ButtonExcluirNoti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonExcluirNoti.Name = "ButtonExcluirNoti";
            this.ButtonExcluirNoti.Size = new System.Drawing.Size(107, 38);
            this.ButtonExcluirNoti.TabIndex = 53;
            this.ButtonExcluirNoti.Text = "excluir";
            this.ButtonExcluirNoti.UseVisualStyleBackColor = false;
            this.ButtonExcluirNoti.Click += new System.EventHandler(this.ButtonExcluirNoti_Click);
            // 
            // ButtonExcluirComp
            // 
            this.ButtonExcluirComp.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonExcluirComp.Location = new System.Drawing.Point(324, 431);
            this.ButtonExcluirComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonExcluirComp.Name = "ButtonExcluirComp";
            this.ButtonExcluirComp.Size = new System.Drawing.Size(107, 38);
            this.ButtonExcluirComp.TabIndex = 54;
            this.ButtonExcluirComp.Text = "excluir";
            this.ButtonExcluirComp.UseVisualStyleBackColor = false;
            this.ButtonExcluirComp.Click += new System.EventHandler(this.ButtonExcluirComp_Click);
            // 
            // listBoxNoti
            // 
            this.listBoxNoti.BackColor = System.Drawing.Color.White;
            this.listBoxNoti.FormattingEnabled = true;
            this.listBoxNoti.ItemHeight = 25;
            this.listBoxNoti.Location = new System.Drawing.Point(54, 604);
            this.listBoxNoti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxNoti.Name = "listBoxNoti";
            this.listBoxNoti.Size = new System.Drawing.Size(787, 129);
            this.listBoxNoti.TabIndex = 55;
            this.listBoxNoti.SelectedIndexChanged += new System.EventHandler(this.listBoxNoti_SelectedIndexChanged);
            this.listBoxNoti.DoubleClick += new System.EventHandler(this.listBoxNoti_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(37, 587);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1090, 352);
            this.textBox1.TabIndex = 57;
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonFechar.Location = new System.Drawing.Point(77, 948);
            this.ButtonFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(950, 33);
            this.ButtonFechar.TabIndex = 58;
            this.ButtonFechar.Text = "Fechar";
            this.ButtonFechar.UseVisualStyleBackColor = false;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.BackColor = System.Drawing.Color.White;
            this.textBoxLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocal.ForeColor = System.Drawing.Color.Black;
            this.textBoxLocal.Location = new System.Drawing.Point(880, 268);
            this.textBoxLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(171, 30);
            this.textBoxLocal.TabIndex = 59;
            this.textBoxLocal.TextChanged += new System.EventHandler(this.textBoxLocal_TextChanged);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLocal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLocal.Location = new System.Drawing.Point(880, 233);
            this.labelLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(61, 24);
            this.labelLocal.TabIndex = 60;
            this.labelLocal.Text = "Local";
            // 
            // listBoxConvidados
            // 
            this.listBoxConvidados.BackColor = System.Drawing.Color.White;
            this.listBoxConvidados.FormattingEnabled = true;
            this.listBoxConvidados.ItemHeight = 25;
            this.listBoxConvidados.Location = new System.Drawing.Point(485, 89);
            this.listBoxConvidados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxConvidados.Name = "listBoxConvidados";
            this.listBoxConvidados.Size = new System.Drawing.Size(300, 54);
            this.listBoxConvidados.TabIndex = 61;
            this.listBoxConvidados.SelectedIndexChanged += new System.EventHandler(this.listBoxConvidados_SelectedIndexChanged);
            this.listBoxConvidados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxConvidados_MouseDoubleClick);
            // 
            // textBoxConvidado
            // 
            this.textBoxConvidado.BackColor = System.Drawing.Color.White;
            this.textBoxConvidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxConvidado.ForeColor = System.Drawing.Color.Black;
            this.textBoxConvidado.Location = new System.Drawing.Point(874, 342);
            this.textBoxConvidado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxConvidado.Name = "textBoxConvidado";
            this.textBoxConvidado.Size = new System.Drawing.Size(177, 30);
            this.textBoxConvidado.TabIndex = 62;
            this.textBoxConvidado.TextChanged += new System.EventHandler(this.textBoxConvidado_TextChanged);
            // 
            // labelEmailDoConvidado
            // 
            this.labelEmailDoConvidado.AutoSize = true;
            this.labelEmailDoConvidado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEmailDoConvidado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmailDoConvidado.Location = new System.Drawing.Point(880, 312);
            this.labelEmailDoConvidado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmailDoConvidado.Name = "labelEmailDoConvidado";
            this.labelEmailDoConvidado.Size = new System.Drawing.Size(202, 24);
            this.labelEmailDoConvidado.TabIndex = 63;
            this.labelEmailDoConvidado.Text = "E-mail do convidado";
            // 
            // buttonExcluirConvidados
            // 
            this.buttonExcluirConvidados.BackColor = System.Drawing.SystemColors.Control;
            this.buttonExcluirConvidados.Location = new System.Drawing.Point(734, 505);
            this.buttonExcluirConvidados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExcluirConvidados.Name = "buttonExcluirConvidados";
            this.buttonExcluirConvidados.Size = new System.Drawing.Size(107, 38);
            this.buttonExcluirConvidados.TabIndex = 66;
            this.buttonExcluirConvidados.Text = "excluir";
            this.buttonExcluirConvidados.UseVisualStyleBackColor = false;
            this.buttonExcluirConvidados.Click += new System.EventHandler(this.buttonExcluirConvidados_Click);
            // 
            // buttonEditarConvidados
            // 
            this.buttonEditarConvidados.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEditarConvidados.Location = new System.Drawing.Point(612, 505);
            this.buttonEditarConvidados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditarConvidados.Name = "buttonEditarConvidados";
            this.buttonEditarConvidados.Size = new System.Drawing.Size(107, 38);
            this.buttonEditarConvidados.TabIndex = 65;
            this.buttonEditarConvidados.Text = "editar";
            this.buttonEditarConvidados.UseVisualStyleBackColor = false;
            this.buttonEditarConvidados.Click += new System.EventHandler(this.buttonEditarConvidados_Click);
            // 
            // buttonSalvarConvidados
            // 
            this.buttonSalvarConvidados.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSalvarConvidados.Location = new System.Drawing.Point(497, 505);
            this.buttonSalvarConvidados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSalvarConvidados.Name = "buttonSalvarConvidados";
            this.buttonSalvarConvidados.Size = new System.Drawing.Size(107, 38);
            this.buttonSalvarConvidados.TabIndex = 64;
            this.buttonSalvarConvidados.Text = "salvar";
            this.buttonSalvarConvidados.UseVisualStyleBackColor = false;
            this.buttonSalvarConvidados.Click += new System.EventHandler(this.buttonSalvarConvidados_Click);
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.BackColor = System.Drawing.Color.White;
            this.comboBoxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioridade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Location = new System.Drawing.Point(880, 184);
            this.comboBoxPrioridade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(171, 33);
            this.comboBoxPrioridade.TabIndex = 67;
            this.comboBoxPrioridade.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrioridade_SelectedIndexChanged);
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPrioridade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrioridade.Location = new System.Drawing.Point(880, 155);
            this.labelPrioridade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(106, 24);
            this.labelPrioridade.TabIndex = 68;
            this.labelPrioridade.Text = "prioridade";
            // 
            // numericUpDownTempoLembrete
            // 
            this.numericUpDownTempoLembrete.BackColor = System.Drawing.Color.White;
            this.numericUpDownTempoLembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownTempoLembrete.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownTempoLembrete.Location = new System.Drawing.Point(880, 122);
            this.numericUpDownTempoLembrete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownTempoLembrete.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericUpDownTempoLembrete.Name = "numericUpDownTempoLembrete";
            this.numericUpDownTempoLembrete.Size = new System.Drawing.Size(179, 28);
            this.numericUpDownTempoLembrete.TabIndex = 69;
            this.numericUpDownTempoLembrete.ThousandsSeparator = true;
            // 
            // comboBoxTipoLembrete
            // 
            this.comboBoxTipoLembrete.BackColor = System.Drawing.Color.White;
            this.comboBoxTipoLembrete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoLembrete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTipoLembrete.FormattingEnabled = true;
            this.comboBoxTipoLembrete.Location = new System.Drawing.Point(956, 416);
            this.comboBoxTipoLembrete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTipoLembrete.Name = "comboBoxTipoLembrete";
            this.comboBoxTipoLembrete.Size = new System.Drawing.Size(171, 33);
            this.comboBoxTipoLembrete.TabIndex = 70;
            this.comboBoxTipoLembrete.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoLembrete_SelectedIndexChanged);
            // 
            // labelLembretRepitir
            // 
            this.labelLembretRepitir.AutoSize = true;
            this.labelLembretRepitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLembretRepitir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLembretRepitir.Location = new System.Drawing.Point(884, 89);
            this.labelLembretRepitir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLembretRepitir.Name = "labelLembretRepitir";
            this.labelLembretRepitir.Size = new System.Drawing.Size(141, 24);
            this.labelLembretRepitir.TabIndex = 71;
            this.labelLembretRepitir.Text = "repitir a cada:";
            // 
            // labelRepitir
            // 
            this.labelRepitir.AutoSize = true;
            this.labelRepitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelRepitir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRepitir.Location = new System.Drawing.Point(488, 155);
            this.labelRepitir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepitir.Name = "labelRepitir";
            this.labelRepitir.Size = new System.Drawing.Size(73, 24);
            this.labelRepitir.TabIndex = 73;
            this.labelRepitir.Text = "repitir:";
            // 
            // checkBoxDomingo
            // 
            this.checkBoxDomingo.AutoSize = true;
            this.checkBoxDomingo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxDomingo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDomingo.Location = new System.Drawing.Point(484, 184);
            this.checkBoxDomingo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxDomingo.Name = "checkBoxDomingo";
            this.checkBoxDomingo.Size = new System.Drawing.Size(51, 29);
            this.checkBoxDomingo.TabIndex = 74;
            this.checkBoxDomingo.Text = "D";
            this.checkBoxDomingo.UseVisualStyleBackColor = false;
            this.checkBoxDomingo.CheckedChanged += new System.EventHandler(this.checkBoxDomingo_CheckedChanged);
            // 
            // checkBoxSegunda
            // 
            this.checkBoxSegunda.AutoSize = true;
            this.checkBoxSegunda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxSegunda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSegunda.Location = new System.Drawing.Point(485, 228);
            this.checkBoxSegunda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSegunda.Name = "checkBoxSegunda";
            this.checkBoxSegunda.Size = new System.Drawing.Size(48, 29);
            this.checkBoxSegunda.TabIndex = 75;
            this.checkBoxSegunda.Text = "S";
            this.checkBoxSegunda.UseVisualStyleBackColor = false;
            this.checkBoxSegunda.CheckedChanged += new System.EventHandler(this.checkBoxSegunda_CheckedChanged);
            // 
            // checkBoxTerca
            // 
            this.checkBoxTerca.AutoSize = true;
            this.checkBoxTerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxTerca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTerca.Location = new System.Drawing.Point(484, 267);
            this.checkBoxTerca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTerca.Name = "checkBoxTerca";
            this.checkBoxTerca.Size = new System.Drawing.Size(49, 29);
            this.checkBoxTerca.TabIndex = 76;
            this.checkBoxTerca.Text = "T";
            this.checkBoxTerca.UseVisualStyleBackColor = false;
            this.checkBoxTerca.CheckedChanged += new System.EventHandler(this.checkBoxTerca_CheckedChanged);
            // 
            // checkBoxSexta
            // 
            this.checkBoxSexta.AutoSize = true;
            this.checkBoxSexta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxSexta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSexta.Location = new System.Drawing.Point(484, 381);
            this.checkBoxSexta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSexta.Name = "checkBoxSexta";
            this.checkBoxSexta.Size = new System.Drawing.Size(48, 29);
            this.checkBoxSexta.TabIndex = 79;
            this.checkBoxSexta.Text = "S";
            this.checkBoxSexta.UseVisualStyleBackColor = false;
            this.checkBoxSexta.CheckedChanged += new System.EventHandler(this.checkBoxSexta_CheckedChanged);
            // 
            // checkBoxQuinta
            // 
            this.checkBoxQuinta.AutoSize = true;
            this.checkBoxQuinta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxQuinta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxQuinta.Location = new System.Drawing.Point(485, 342);
            this.checkBoxQuinta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxQuinta.Name = "checkBoxQuinta";
            this.checkBoxQuinta.Size = new System.Drawing.Size(52, 29);
            this.checkBoxQuinta.TabIndex = 78;
            this.checkBoxQuinta.Text = "Q";
            this.checkBoxQuinta.UseVisualStyleBackColor = false;
            this.checkBoxQuinta.CheckedChanged += new System.EventHandler(this.checkBoxQuinta_CheckedChanged);
            // 
            // checkBoxQuarta
            // 
            this.checkBoxQuarta.AutoSize = true;
            this.checkBoxQuarta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxQuarta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxQuarta.Location = new System.Drawing.Point(484, 303);
            this.checkBoxQuarta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxQuarta.Name = "checkBoxQuarta";
            this.checkBoxQuarta.Size = new System.Drawing.Size(52, 29);
            this.checkBoxQuarta.TabIndex = 77;
            this.checkBoxQuarta.Text = "Q";
            this.checkBoxQuarta.UseVisualStyleBackColor = false;
            this.checkBoxQuarta.CheckedChanged += new System.EventHandler(this.checkBoxQuarta_CheckedChanged);
            // 
            // checkBoxSabado
            // 
            this.checkBoxSabado.AutoSize = true;
            this.checkBoxSabado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxSabado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSabado.Location = new System.Drawing.Point(484, 420);
            this.checkBoxSabado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSabado.Name = "checkBoxSabado";
            this.checkBoxSabado.Size = new System.Drawing.Size(48, 29);
            this.checkBoxSabado.TabIndex = 80;
            this.checkBoxSabado.Text = "S";
            this.checkBoxSabado.UseVisualStyleBackColor = false;
            this.checkBoxSabado.CheckedChanged += new System.EventHandler(this.checkBoxSabado_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(37, 76);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1090, 491);
            this.textBox2.TabIndex = 81;
            // 
            // labelTerminarEm
            // 
            this.labelTerminarEm.AutoSize = true;
            this.labelTerminarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTerminarEm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTerminarEm.Location = new System.Drawing.Point(619, 155);
            this.labelTerminarEm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerminarEm.Name = "labelTerminarEm";
            this.labelTerminarEm.Size = new System.Drawing.Size(135, 24);
            this.labelTerminarEm.TabIndex = 82;
            this.labelTerminarEm.Text = "Terminar em:";
            this.labelTerminarEm.Click += new System.EventHandler(this.labelTerminarEm_Click);
            // 
            // checkBoxNunca
            // 
            this.checkBoxNunca.AutoSize = true;
            this.checkBoxNunca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxNunca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNunca.Location = new System.Drawing.Point(619, 201);
            this.checkBoxNunca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxNunca.Name = "checkBoxNunca";
            this.checkBoxNunca.Size = new System.Drawing.Size(93, 29);
            this.checkBoxNunca.TabIndex = 83;
            this.checkBoxNunca.Text = "Nunca";
            this.checkBoxNunca.UseVisualStyleBackColor = false;
            this.checkBoxNunca.CheckedChanged += new System.EventHandler(this.checkBoxNunca_CheckedChanged);
            // 
            // CheckBoxData
            // 
            this.CheckBoxData.AutoSize = true;
            this.CheckBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckBoxData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxData.Location = new System.Drawing.Point(619, 251);
            this.CheckBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBoxData.Name = "CheckBoxData";
            this.CheckBoxData.Size = new System.Drawing.Size(104, 29);
            this.CheckBoxData.TabIndex = 85;
            this.CheckBoxData.Text = "EmData";
            this.CheckBoxData.UseVisualStyleBackColor = false;
            this.CheckBoxData.CheckedChanged += new System.EventHandler(this.CheckBoxData_CheckedChanged);
            // 
            // dateTimePickerLembrete
            // 
            this.dateTimePickerLembrete.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerLembrete.CustomFormat = "";
            this.dateTimePickerLembrete.Location = new System.Drawing.Point(770, 418);
            this.dateTimePickerLembrete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerLembrete.Name = "dateTimePickerLembrete";
            this.dateTimePickerLembrete.Size = new System.Drawing.Size(178, 31);
            this.dateTimePickerLembrete.TabIndex = 86;
            // 
            // numericUpDownOcorrenciasLembrete
            // 
            this.numericUpDownOcorrenciasLembrete.BackColor = System.Drawing.Color.White;
            this.numericUpDownOcorrenciasLembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownOcorrenciasLembrete.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownOcorrenciasLembrete.Location = new System.Drawing.Point(575, 420);
            this.numericUpDownOcorrenciasLembrete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownOcorrenciasLembrete.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericUpDownOcorrenciasLembrete.Name = "numericUpDownOcorrenciasLembrete";
            this.numericUpDownOcorrenciasLembrete.Size = new System.Drawing.Size(179, 28);
            this.numericUpDownOcorrenciasLembrete.TabIndex = 87;
            this.numericUpDownOcorrenciasLembrete.ThousandsSeparator = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(791, 389);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 21);
            this.textBox3.TabIndex = 88;
            this.textBox3.Text = "LEMBRETE";
            // 
            // FormCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1252, 995);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.numericUpDownOcorrenciasLembrete);
            this.Controls.Add(this.dateTimePickerLembrete);
            this.Controls.Add(this.CheckBoxData);
            this.Controls.Add(this.checkBoxNunca);
            this.Controls.Add(this.labelTerminarEm);
            this.Controls.Add(this.checkBoxSabado);
            this.Controls.Add(this.checkBoxSexta);
            this.Controls.Add(this.checkBoxQuinta);
            this.Controls.Add(this.checkBoxQuarta);
            this.Controls.Add(this.checkBoxTerca);
            this.Controls.Add(this.checkBoxSegunda);
            this.Controls.Add(this.checkBoxDomingo);
            this.Controls.Add(this.labelRepitir);
            this.Controls.Add(this.labelLembretRepitir);
            this.Controls.Add(this.comboBoxTipoLembrete);
            this.Controls.Add(this.numericUpDownTempoLembrete);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.buttonExcluirConvidados);
            this.Controls.Add(this.buttonEditarConvidados);
            this.Controls.Add(this.buttonSalvarConvidados);
            this.Controls.Add(this.labelEmailDoConvidado);
            this.Controls.Add(this.textBoxConvidado);
            this.Controls.Add(this.listBoxConvidados);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.ButtonFechar);
            this.Controls.Add(this.listBoxNoti);
            this.Controls.Add(this.ButtonExcluirComp);
            this.Controls.Add(this.ButtonExcluirNoti);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.comboBoxTempo);
            this.Controls.Add(this.ButtonEditarNoti);
            this.Controls.Add(this.ButtonEditarComp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxDataFim);
            this.Controls.Add(this.ButtonSalvarNoti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TempoNotificacao);
            this.Controls.Add(this.labelNotificaçãoTempo);
            this.Controls.Add(this.ButtonSalvarComp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Boxdatainicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCompromisso";
            this.Load += new System.EventHandler(this.FormCompromisso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TempoNotificacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempoLembrete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcorrenciasLembrete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxTempo;
        private System.Windows.Forms.Button ButtonEditarNoti;
        private System.Windows.Forms.Button ButtonEditarComp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox BoxDataFim;
        private System.Windows.Forms.Button ButtonSalvarNoti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TempoNotificacao;
        private System.Windows.Forms.Label labelNotificaçãoTempo;
        private System.Windows.Forms.Button ButtonSalvarComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Boxdatainicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Button ButtonExcluirNoti;
        private System.Windows.Forms.Button ButtonExcluirComp;
        private System.Windows.Forms.ListBox listBoxNoti;
        private System.Windows.Forms.ListBox ListBoxParaCor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonFechar;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.ListBox listBoxConvidados;
        private System.Windows.Forms.TextBox textBoxConvidado;
        private System.Windows.Forms.Label labelEmailDoConvidado;
        private System.Windows.Forms.Button buttonExcluirConvidados;
        private System.Windows.Forms.Button buttonEditarConvidados;
        private System.Windows.Forms.Button buttonSalvarConvidados;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.NumericUpDown numericUpDownTempoLembrete;
        private System.Windows.Forms.ComboBox comboBoxTipoLembrete;
        private System.Windows.Forms.Label labelLembretRepitir;
        private System.Windows.Forms.Label labelRepitir;
        private System.Windows.Forms.CheckBox checkBoxDomingo;
        private System.Windows.Forms.CheckBox checkBoxSegunda;
        private System.Windows.Forms.CheckBox checkBoxTerca;
        private System.Windows.Forms.CheckBox checkBoxSexta;
        private System.Windows.Forms.CheckBox checkBoxQuinta;
        private System.Windows.Forms.CheckBox checkBoxQuarta;
        private System.Windows.Forms.CheckBox checkBoxSabado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelTerminarEm;
        private System.Windows.Forms.CheckBox checkBoxNunca;
        private System.Windows.Forms.CheckBox CheckBoxData;
        private System.Windows.Forms.DateTimePicker dateTimePickerLembrete;
        private System.Windows.Forms.NumericUpDown numericUpDownOcorrenciasLembrete;
        private System.Windows.Forms.TextBox textBox3;
    }
}