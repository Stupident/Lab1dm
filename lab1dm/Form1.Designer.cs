namespace lab1dm
{
    partial class Main
    {

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.shortF = new System.Windows.Forms.Button();
            this.calcZ = new System.Windows.Forms.Button();
            this.allRes = new System.Windows.Forms.Button();
            this.manInput = new System.Windows.Forms.GroupBox();
            this.manCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manSetC = new System.Windows.Forms.TextBox();
            this.manSetB = new System.Windows.Forms.TextBox();
            this.manSetA = new System.Windows.Forms.TextBox();
            this.radioAutoGen = new System.Windows.Forms.RadioButton();
            this.radioManInput = new System.Windows.Forms.RadioButton();
            this.selectBox = new System.Windows.Forms.GroupBox();
            this.autoGen = new System.Windows.Forms.GroupBox();
            this.AutoGenC = new System.Windows.Forms.NumericUpDown();
            this.AutoGenB = new System.Windows.Forms.NumericUpDown();
            this.AutoGenA = new System.Windows.Forms.NumericUpDown();
            this.generate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uTopBox = new System.Windows.Forms.NumericUpDown();
            this.uDownBox = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.setsBox = new System.Windows.Forms.GroupBox();
            this.regenerate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.setCBox = new System.Windows.Forms.TextBox();
            this.setBBox = new System.Windows.Forms.TextBox();
            this.setABox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.variantLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.origF = new System.Windows.Forms.Button();
            this.manInput.SuspendLayout();
            this.selectBox.SuspendLayout();
            this.autoGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGenC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGenB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGenA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDownBox)).BeginInit();
            this.setsBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortF
            // 
            this.shortF.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.shortF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.shortF.ForeColor = System.Drawing.SystemColors.Window;
            this.shortF.Location = new System.Drawing.Point(28, 450);
            this.shortF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shortF.Name = "shortF";
            this.shortF.Size = new System.Drawing.Size(189, 47);
            this.shortF.TabIndex = 7;
            this.shortF.Text = "Calculate the shorted formula";
            this.shortF.UseVisualStyleBackColor = false;
            this.shortF.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // calcZ
            // 
            this.calcZ.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.calcZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.calcZ.ForeColor = System.Drawing.SystemColors.Window;
            this.calcZ.Location = new System.Drawing.Point(263, 450);
            this.calcZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcZ.Name = "calcZ";
            this.calcZ.Size = new System.Drawing.Size(163, 47);
            this.calcZ.TabIndex = 8;
            this.calcZ.Text = "Calculate set Z";
            this.calcZ.UseVisualStyleBackColor = false;
            this.calcZ.Click += new System.EventHandler(this.calcZ_Click);
            // 
            // allRes
            // 
            this.allRes.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.allRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.allRes.ForeColor = System.Drawing.SystemColors.Window;
            this.allRes.Location = new System.Drawing.Point(472, 450);
            this.allRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allRes.Name = "allRes";
            this.allRes.Size = new System.Drawing.Size(163, 47);
            this.allRes.TabIndex = 9;
            this.allRes.Text = "View all results";
            this.allRes.UseVisualStyleBackColor = false;
            this.allRes.Click += new System.EventHandler(this.button3_Click);
            // 
            // manInput
            // 
            this.manInput.Controls.Add(this.manCreate);
            this.manInput.Controls.Add(this.label3);
            this.manInput.Controls.Add(this.label2);
            this.manInput.Controls.Add(this.label1);
            this.manInput.Controls.Add(this.manSetC);
            this.manInput.Controls.Add(this.manSetB);
            this.manInput.Controls.Add(this.manSetA);
            this.manInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.manInput.ForeColor = System.Drawing.SystemColors.Window;
            this.manInput.Location = new System.Drawing.Point(264, 136);
            this.manInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manInput.Name = "manInput";
            this.manInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manInput.Size = new System.Drawing.Size(370, 280);
            this.manInput.TabIndex = 10;
            this.manInput.TabStop = false;
            this.manInput.Text = "Manual input";
            this.toolTip1.SetToolTip(this.manInput, "Enter set integer elements");
            this.manInput.Visible = false;
            // 
            // manCreate
            // 
            this.manCreate.BackColor = System.Drawing.Color.LightPink;
            this.manCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.manCreate.ForeColor = System.Drawing.Color.Black;
            this.manCreate.Location = new System.Drawing.Point(112, 232);
            this.manCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manCreate.Name = "manCreate";
            this.manCreate.Size = new System.Drawing.Size(139, 28);
            this.manCreate.TabIndex = 19;
            this.manCreate.Text = "Create";
            this.manCreate.UseVisualStyleBackColor = false;
            this.manCreate.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Set C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set A:";
            // 
            // manSetC
            // 
            this.manSetC.Location = new System.Drawing.Point(41, 187);
            this.manSetC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manSetC.Name = "manSetC";
            this.manSetC.Size = new System.Drawing.Size(289, 26);
            this.manSetC.TabIndex = 2;
            // 
            // manSetB
            // 
            this.manSetB.Location = new System.Drawing.Point(41, 121);
            this.manSetB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manSetB.Name = "manSetB";
            this.manSetB.Size = new System.Drawing.Size(289, 26);
            this.manSetB.TabIndex = 1;
            // 
            // manSetA
            // 
            this.manSetA.Location = new System.Drawing.Point(41, 53);
            this.manSetA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manSetA.Name = "manSetA";
            this.manSetA.Size = new System.Drawing.Size(289, 26);
            this.manSetA.TabIndex = 0;
            // 
            // radioAutoGen
            // 
            this.radioAutoGen.AutoSize = true;
            this.radioAutoGen.ForeColor = System.Drawing.SystemColors.Window;
            this.radioAutoGen.Location = new System.Drawing.Point(11, 26);
            this.radioAutoGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAutoGen.Name = "radioAutoGen";
            this.radioAutoGen.Size = new System.Drawing.Size(179, 24);
            this.radioAutoGen.TabIndex = 11;
            this.radioAutoGen.TabStop = true;
            this.radioAutoGen.Text = "Automatic generation";
            this.radioAutoGen.UseVisualStyleBackColor = true;
            this.radioAutoGen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioManInput
            // 
            this.radioManInput.AutoSize = true;
            this.radioManInput.ForeColor = System.Drawing.SystemColors.Window;
            this.radioManInput.Location = new System.Drawing.Point(11, 59);
            this.radioManInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioManInput.Name = "radioManInput";
            this.radioManInput.Size = new System.Drawing.Size(118, 24);
            this.radioManInput.TabIndex = 12;
            this.radioManInput.TabStop = true;
            this.radioManInput.Text = "Manual input";
            this.radioManInput.UseVisualStyleBackColor = true;
            this.radioManInput.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // selectBox
            // 
            this.selectBox.Controls.Add(this.radioAutoGen);
            this.selectBox.Controls.Add(this.radioManInput);
            this.selectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectBox.ForeColor = System.Drawing.SystemColors.Window;
            this.selectBox.Location = new System.Drawing.Point(376, 14);
            this.selectBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectBox.Name = "selectBox";
            this.selectBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectBox.Size = new System.Drawing.Size(259, 90);
            this.selectBox.TabIndex = 13;
            this.selectBox.TabStop = false;
            this.selectBox.Text = "Select input method";
            // 
            // autoGen
            // 
            this.autoGen.Controls.Add(this.AutoGenC);
            this.autoGen.Controls.Add(this.AutoGenB);
            this.autoGen.Controls.Add(this.AutoGenA);
            this.autoGen.Controls.Add(this.generate);
            this.autoGen.Controls.Add(this.label4);
            this.autoGen.Controls.Add(this.label5);
            this.autoGen.Controls.Add(this.label6);
            this.autoGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.autoGen.ForeColor = System.Drawing.SystemColors.Window;
            this.autoGen.Location = new System.Drawing.Point(300, 136);
            this.autoGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoGen.Name = "autoGen";
            this.autoGen.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoGen.Size = new System.Drawing.Size(294, 280);
            this.autoGen.TabIndex = 11;
            this.autoGen.TabStop = false;
            this.autoGen.Text = "Auto generate";
            this.toolTip4.SetToolTip(this.autoGen, "Input the power of sets");
            this.autoGen.Visible = false;
            // 
            // AutoGenC
            // 
            this.AutoGenC.Location = new System.Drawing.Point(132, 178);
            this.AutoGenC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoGenC.Name = "AutoGenC";
            this.AutoGenC.Size = new System.Drawing.Size(93, 26);
            this.AutoGenC.TabIndex = 18;
            this.AutoGenC.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AutoGenB
            // 
            this.AutoGenB.Location = new System.Drawing.Point(132, 108);
            this.AutoGenB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoGenB.Name = "AutoGenB";
            this.AutoGenB.Size = new System.Drawing.Size(93, 26);
            this.AutoGenB.TabIndex = 17;
            this.AutoGenB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AutoGenA
            // 
            this.AutoGenA.Location = new System.Drawing.Point(132, 42);
            this.AutoGenA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutoGenA.Name = "AutoGenA";
            this.AutoGenA.Size = new System.Drawing.Size(93, 26);
            this.AutoGenA.TabIndex = 16;
            this.AutoGenA.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.LightPink;
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.generate.ForeColor = System.Drawing.Color.Black;
            this.generate.Location = new System.Drawing.Point(73, 229);
            this.generate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(148, 28);
            this.generate.TabIndex = 15;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(66, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Set C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(66, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Set B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(66, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Set A:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.uTopBox);
            this.groupBox1.Controls.Add(this.uDownBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(28, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(189, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input the range";
            this.toolTip1.SetToolTip(this.groupBox1, "Input the range of sets");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(33, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // uTopBox
            // 
            this.uTopBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uTopBox.Location = new System.Drawing.Point(33, 123);
            this.uTopBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uTopBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.uTopBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.uTopBox.Name = "uTopBox";
            this.uTopBox.Size = new System.Drawing.Size(120, 26);
            this.uTopBox.TabIndex = 7;
            this.uTopBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // uDownBox
            // 
            this.uDownBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uDownBox.Location = new System.Drawing.Point(33, 54);
            this.uDownBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uDownBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.uDownBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.uDownBox.Name = "uDownBox";
            this.uDownBox.Size = new System.Drawing.Size(120, 26);
            this.uDownBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(32, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(32, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "From:";
            // 
            // setsBox
            // 
            this.setsBox.Controls.Add(this.regenerate);
            this.setsBox.Controls.Add(this.label9);
            this.setsBox.Controls.Add(this.label10);
            this.setsBox.Controls.Add(this.label11);
            this.setsBox.Controls.Add(this.setCBox);
            this.setsBox.Controls.Add(this.setBBox);
            this.setsBox.Controls.Add(this.setABox);
            this.setsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.setsBox.ForeColor = System.Drawing.SystemColors.Window;
            this.setsBox.Location = new System.Drawing.Point(264, 136);
            this.setsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setsBox.Name = "setsBox";
            this.setsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setsBox.Size = new System.Drawing.Size(370, 250);
            this.setsBox.TabIndex = 11;
            this.setsBox.TabStop = false;
            this.setsBox.Text = "Sets";
            // 
            // regenerate
            // 
            this.regenerate.BackColor = System.Drawing.Color.LightPink;
            this.regenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.regenerate.ForeColor = System.Drawing.Color.Black;
            this.regenerate.Location = new System.Drawing.Point(115, 245);
            this.regenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regenerate.Name = "regenerate";
            this.regenerate.Size = new System.Drawing.Size(139, 28);
            this.regenerate.TabIndex = 19;
            this.regenerate.Text = "Regenerate";
            this.regenerate.UseVisualStyleBackColor = false;
            this.regenerate.Visible = false;
            this.regenerate.Click += new System.EventHandler(this.regenerate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(40, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Set C:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(40, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Set B:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(40, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Set A:";
            // 
            // setCBox
            // 
            this.setCBox.Location = new System.Drawing.Point(40, 198);
            this.setCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setCBox.Name = "setCBox";
            this.setCBox.ReadOnly = true;
            this.setCBox.Size = new System.Drawing.Size(289, 26);
            this.setCBox.TabIndex = 2;
            // 
            // setBBox
            // 
            this.setBBox.Location = new System.Drawing.Point(40, 128);
            this.setBBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setBBox.Name = "setBBox";
            this.setBBox.ReadOnly = true;
            this.setBBox.Size = new System.Drawing.Size(289, 26);
            this.setBBox.TabIndex = 1;
            // 
            // setABox
            // 
            this.setABox.Location = new System.Drawing.Point(40, 58);
            this.setABox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setABox.Name = "setABox";
            this.setABox.ReadOnly = true;
            this.setABox.Size = new System.Drawing.Size(289, 26);
            this.setABox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.variantLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(28, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(251, 90);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Author";
            // 
            // variantLabel
            // 
            this.variantLabel.AutoSize = true;
            this.variantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.variantLabel.Location = new System.Drawing.Point(17, 65);
            this.variantLabel.Name = "variantLabel";
            this.variantLabel.Size = new System.Drawing.Size(57, 17);
            this.variantLabel.TabIndex = 3;
            this.variantLabel.Text = "Variant:";
            this.toolTip3.SetToolTip(this.variantLabel, "Click to view variant of work");
            this.variantLabel.Click += new System.EventHandler(this.variantLabel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(115, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Number in list: 19";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(17, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Group: IO-92";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(17, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mykhailiuk Yevhenii";
            // 
            // origF
            // 
            this.origF.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.origF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.origF.ForeColor = System.Drawing.SystemColors.Window;
            this.origF.Location = new System.Drawing.Point(28, 369);
            this.origF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.origF.Name = "origF";
            this.origF.Size = new System.Drawing.Size(189, 47);
            this.origF.TabIndex = 0;
            this.origF.Text = "Calculate the original formula";
            this.origF.UseVisualStyleBackColor = false;
            this.origF.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(120)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(664, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.setsBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autoGen);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.manInput);
            this.Controls.Add(this.allRes);
            this.Controls.Add(this.calcZ);
            this.Controls.Add(this.shortF);
            this.Controls.Add(this.origF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "De_Mka";
            this.manInput.ResumeLayout(false);
            this.manInput.PerformLayout();
            this.selectBox.ResumeLayout(false);
            this.selectBox.PerformLayout();
            this.autoGen.ResumeLayout(false);
            this.autoGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGenC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGenB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoGenA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uDownBox)).EndInit();
            this.setsBox.ResumeLayout(false);
            this.setsBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button shortF;
        private System.Windows.Forms.Button calcZ;
        private System.Windows.Forms.Button allRes;
        private System.Windows.Forms.GroupBox manInput;
        private System.Windows.Forms.RadioButton radioAutoGen;
        private System.Windows.Forms.RadioButton radioManInput;
        private System.Windows.Forms.GroupBox selectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox manSetC;
        private System.Windows.Forms.TextBox manSetB;
        private System.Windows.Forms.TextBox manSetA;
        private System.Windows.Forms.GroupBox autoGen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox setsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox setCBox;
        private System.Windows.Forms.TextBox setBBox;
        private System.Windows.Forms.TextBox setABox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label variantLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown uDownBox;
        private System.Windows.Forms.NumericUpDown uTopBox;
        private System.Windows.Forms.NumericUpDown AutoGenC;
        private System.Windows.Forms.NumericUpDown AutoGenB;
        private System.Windows.Forms.NumericUpDown AutoGenA;
        private System.Windows.Forms.Button manCreate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button regenerate;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button origF;
        private System.Windows.Forms.Button button1;
    }
}

