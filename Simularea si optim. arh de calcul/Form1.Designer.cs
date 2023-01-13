
namespace Simularea_si_optim.arh_de_calcul
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cycle = new System.Windows.Forms.TextBox();
            this.tick = new System.Windows.Forms.TextBox();
            this.issueRateFinal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Latenta = new System.Windows.Forms.NumericUpDown();
            this.NrRegistri = new System.Windows.Forms.ComboBox();
            this.Memoria = new System.Windows.Forms.ComboBox();
            this.IBS = new System.Windows.Forms.ComboBox();
            this.IRmax = new System.Windows.Forms.ComboBox();
            this.FR = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipCacheU = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SizeDC = new System.Windows.Forms.ComboBox();
            this.SizeBlockDC = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SizeIC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SizeBlockIC = new System.Windows.Forms.ComboBox();
            this.TipCacheB = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nrInstructiuni = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.nrBranch = new System.Windows.Forms.TextBox();
            this.nrStore = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nrLoad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.numeFisier = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.startSimBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Latenta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cycle);
            this.groupBox1.Controls.Add(this.tick);
            this.groupBox1.Controls.Add(this.issueRateFinal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(496, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultate";
            // 
            // cycle
            // 
            this.cycle.Location = new System.Drawing.Point(100, 36);
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(100, 20);
            this.cycle.TabIndex = 6;
            // 
            // tick
            // 
            this.tick.Location = new System.Drawing.Point(100, 106);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(100, 20);
            this.tick.TabIndex = 5;
            // 
            // issueRateFinal
            // 
            this.issueRateFinal.Location = new System.Drawing.Point(100, 72);
            this.issueRateFinal.Name = "issueRateFinal";
            this.issueRateFinal.Size = new System.Drawing.Size(100, 20);
            this.issueRateFinal.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Issue Rate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ticks:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "One-cycle:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Latenta);
            this.groupBox2.Controls.Add(this.NrRegistri);
            this.groupBox2.Controls.Add(this.Memoria);
            this.groupBox2.Controls.Add(this.IBS);
            this.groupBox2.Controls.Add(this.IRmax);
            this.groupBox2.Controls.Add(this.FR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametri Simulator";
            // 
            // Latenta
            // 
            this.Latenta.Location = new System.Drawing.Point(166, 138);
            this.Latenta.Name = "Latenta";
            this.Latenta.Size = new System.Drawing.Size(48, 20);
            this.Latenta.TabIndex = 11;
            this.Latenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NrRegistri
            // 
            this.NrRegistri.FormattingEnabled = true;
            this.NrRegistri.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.NrRegistri.Location = new System.Drawing.Point(166, 208);
            this.NrRegistri.Name = "NrRegistri";
            this.NrRegistri.Size = new System.Drawing.Size(48, 21);
            this.NrRegistri.TabIndex = 10;
            this.NrRegistri.Text = "2";
            // 
            // Memoria
            // 
            this.Memoria.FormattingEnabled = true;
            this.Memoria.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.Memoria.Location = new System.Drawing.Point(166, 174);
            this.Memoria.Name = "Memoria";
            this.Memoria.Size = new System.Drawing.Size(48, 21);
            this.Memoria.TabIndex = 9;
            this.Memoria.Text = "10";
            // 
            // IBS
            // 
            this.IBS.FormattingEnabled = true;
            this.IBS.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32"});
            this.IBS.Location = new System.Drawing.Point(166, 101);
            this.IBS.Name = "IBS";
            this.IBS.Size = new System.Drawing.Size(48, 21);
            this.IBS.TabIndex = 7;
            this.IBS.Text = "4";
            // 
            // IRmax
            // 
            this.IRmax.FormattingEnabled = true;
            this.IRmax.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.IRmax.Location = new System.Drawing.Point(166, 65);
            this.IRmax.Name = "IRmax";
            this.IRmax.Size = new System.Drawing.Size(48, 21);
            this.IRmax.TabIndex = 6;
            this.IRmax.Text = "2";
            // 
            // FR
            // 
            this.FR.FormattingEnabled = true;
            this.FR.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.FR.Location = new System.Drawing.Point(166, 32);
            this.FR.Name = "FR";
            this.FR.Size = new System.Drawing.Size(48, 21);
            this.FR.TabIndex = 4;
            this.FR.Text = "4";
            this.FR.SelectedIndexChanged += new System.EventHandler(this.FR_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nr. SetRegistri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Memoria principala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Latenta(for hit in cache):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Instruction Buffer Size(IBS):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Issue Rate Maxim(IRmax):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fetch Rate(FR):";
            // 
            // TipCacheU
            // 
            this.TipCacheU.AutoSize = true;
            this.TipCacheU.Checked = true;
            this.TipCacheU.Location = new System.Drawing.Point(30, 178);
            this.TipCacheU.Name = "TipCacheU";
            this.TipCacheU.Size = new System.Drawing.Size(59, 17);
            this.TipCacheU.TabIndex = 2;
            this.TipCacheU.TabStop = true;
            this.TipCacheU.Text = "Uniport";
            this.TipCacheU.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.TipCacheB);
            this.groupBox3.Controls.Add(this.TipCacheU);
            this.groupBox3.Location = new System.Drawing.Point(285, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 241);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametri Cache(Mapare Directa)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SizeDC);
            this.groupBox5.Controls.Add(this.SizeBlockDC);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(269, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Cache";
            // 
            // SizeDC
            // 
            this.SizeDC.FormattingEnabled = true;
            this.SizeDC.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.SizeDC.Location = new System.Drawing.Point(93, 60);
            this.SizeDC.Name = "SizeDC";
            this.SizeDC.Size = new System.Drawing.Size(56, 21);
            this.SizeDC.TabIndex = 7;
            this.SizeDC.Text = "4";
            // 
            // SizeBlockDC
            // 
            this.SizeBlockDC.FormattingEnabled = true;
            this.SizeBlockDC.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192"});
            this.SizeBlockDC.Location = new System.Drawing.Point(93, 25);
            this.SizeBlockDC.Name = "SizeBlockDC";
            this.SizeBlockDC.Size = new System.Drawing.Size(56, 21);
            this.SizeBlockDC.TabIndex = 6;
            this.SizeBlockDC.Text = "64";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Size_DC:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Block size:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.SizeIC);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.SizeBlockIC);
            this.groupBox4.Location = new System.Drawing.Point(46, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Instruction Cache";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "=FR";
            // 
            // SizeIC
            // 
            this.SizeIC.FormattingEnabled = true;
            this.SizeIC.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.SizeIC.Location = new System.Drawing.Point(100, 63);
            this.SizeIC.Name = "SizeIC";
            this.SizeIC.Size = new System.Drawing.Size(56, 21);
            this.SizeIC.TabIndex = 4;
            this.SizeIC.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Size_IC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Block size:";
            // 
            // SizeBlockIC
            // 
            this.SizeBlockIC.Enabled = false;
            this.SizeBlockIC.FormattingEnabled = true;
            this.SizeBlockIC.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192"});
            this.SizeBlockIC.Location = new System.Drawing.Point(100, 25);
            this.SizeBlockIC.Name = "SizeBlockIC";
            this.SizeBlockIC.Size = new System.Drawing.Size(56, 21);
            this.SizeBlockIC.TabIndex = 0;
            this.SizeBlockIC.Text = "64";
            this.SizeBlockIC.SelectedIndexChanged += new System.EventHandler(this.SizeBlockIC_SelectedIndexChanged);
            // 
            // TipCacheB
            // 
            this.TipCacheB.AutoSize = true;
            this.TipCacheB.Location = new System.Drawing.Point(30, 208);
            this.TipCacheB.Name = "TipCacheB";
            this.TipCacheB.Size = new System.Drawing.Size(52, 17);
            this.TipCacheB.TabIndex = 3;
            this.TipCacheB.Text = "Biport";
            this.TipCacheB.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nrInstructiuni);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.nrBranch);
            this.groupBox6.Controls.Add(this.nrStore);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.nrLoad);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(176, 271);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(302, 143);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Instructiuni";
            // 
            // nrInstructiuni
            // 
            this.nrInstructiuni.Location = new System.Drawing.Point(100, 114);
            this.nrInstructiuni.Name = "nrInstructiuni";
            this.nrInstructiuni.Size = new System.Drawing.Size(100, 20);
            this.nrInstructiuni.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Total:";
            // 
            // nrBranch
            // 
            this.nrBranch.Location = new System.Drawing.Point(100, 86);
            this.nrBranch.Name = "nrBranch";
            this.nrBranch.Size = new System.Drawing.Size(100, 20);
            this.nrBranch.TabIndex = 5;
            // 
            // nrStore
            // 
            this.nrStore.Location = new System.Drawing.Point(100, 55);
            this.nrStore.Name = "nrStore";
            this.nrStore.Size = new System.Drawing.Size(100, 20);
            this.nrStore.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Store:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Branch:";
            // 
            // nrLoad
            // 
            this.nrLoad.Location = new System.Drawing.Point(100, 23);
            this.nrLoad.Name = "nrLoad";
            this.nrLoad.Size = new System.Drawing.Size(100, 20);
            this.nrLoad.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Load:";
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(32, 287);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseFileBtn.TabIndex = 8;
            this.chooseFileBtn.Text = "Alege fisier";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // numeFisier
            // 
            this.numeFisier.Location = new System.Drawing.Point(32, 319);
            this.numeFisier.Name = "numeFisier";
            this.numeFisier.Size = new System.Drawing.Size(75, 20);
            this.numeFisier.TabIndex = 9;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(32, 391);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // startSimBtn
            // 
            this.startSimBtn.Location = new System.Drawing.Point(32, 350);
            this.startSimBtn.Name = "startSimBtn";
            this.startSimBtn.Size = new System.Drawing.Size(75, 35);
            this.startSimBtn.TabIndex = 12;
            this.startSimBtn.Text = "Start Simulare";
            this.startSimBtn.UseVisualStyleBackColor = true;
            this.startSimBtn.Click += new System.EventHandler(this.startSimBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startSimBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.numeFisier);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simulator Cache";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Latenta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton TipCacheU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.TextBox issueRateFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Latenta;
        private System.Windows.Forms.ComboBox NrRegistri;
        private System.Windows.Forms.ComboBox IBS;
        private System.Windows.Forms.ComboBox IRmax;
        private System.Windows.Forms.ComboBox FR;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox SizeDC;
        private System.Windows.Forms.ComboBox SizeBlockDC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SizeIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SizeBlockIC;
        private System.Windows.Forms.RadioButton TipCacheB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox nrBranch;
        private System.Windows.Forms.TextBox nrStore;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nrLoad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox nrInstructiuni;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.TextBox numeFisier;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox Memoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tick;
        private System.Windows.Forms.TextBox cycle;
        private System.Windows.Forms.Button startSimBtn;
    }
}

