namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btPort = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnAvRec = new System.Windows.Forms.Button();
            this.gbResolution = new System.Windows.Forms.GroupBox();
            this.rbSixteenth = new System.Windows.Forms.RadioButton();
            this.rbEighth = new System.Windows.Forms.RadioButton();
            this.rbQuarter = new System.Windows.Forms.RadioButton();
            this.rbHalf = new System.Windows.Forms.RadioButton();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.lblTpm = new System.Windows.Forms.Label();
            this.lblStatusOnOff = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWise = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.tbRPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAppliquerRPM = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.gbResolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 250000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(436, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btPort
            // 
            this.btPort.Location = new System.Drawing.Point(342, 12);
            this.btPort.Name = "btPort";
            this.btPort.Size = new System.Drawing.Size(97, 23);
            this.btPort.TabIndex = 5;
            this.btPort.Text = "Modifier";
            this.btPort.UseVisualStyleBackColor = true;
            this.btPort.Click += new System.EventHandler(this.btPort_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.Green;
            this.btnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.ForeColor = System.Drawing.Color.White;
            this.btnOnOff.Location = new System.Drawing.Point(12, 55);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(108, 34);
            this.btnOnOff.TabIndex = 6;
            this.btnOnOff.Text = "ON";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnAvRec
            // 
            this.btnAvRec.Location = new System.Drawing.Point(213, 55);
            this.btnAvRec.Name = "btnAvRec";
            this.btnAvRec.Size = new System.Drawing.Size(111, 34);
            this.btnAvRec.TabIndex = 7;
            this.btnAvRec.Text = "Recule";
            this.btnAvRec.UseVisualStyleBackColor = true;
            this.btnAvRec.Click += new System.EventHandler(this.btnAvRec_Click);
            // 
            // gbResolution
            // 
            this.gbResolution.Controls.Add(this.rbSixteenth);
            this.gbResolution.Controls.Add(this.rbEighth);
            this.gbResolution.Controls.Add(this.rbQuarter);
            this.gbResolution.Controls.Add(this.rbHalf);
            this.gbResolution.Controls.Add(this.rbFull);
            this.gbResolution.Location = new System.Drawing.Point(12, 114);
            this.gbResolution.Name = "gbResolution";
            this.gbResolution.Size = new System.Drawing.Size(427, 104);
            this.gbResolution.TabIndex = 8;
            this.gbResolution.TabStop = false;
            this.gbResolution.Text = "Résolution";
            // 
            // rbSixteenth
            // 
            this.rbSixteenth.AutoSize = true;
            this.rbSixteenth.Location = new System.Drawing.Point(305, 36);
            this.rbSixteenth.Name = "rbSixteenth";
            this.rbSixteenth.Size = new System.Drawing.Size(120, 21);
            this.rbSixteenth.TabIndex = 4;
            this.rbSixteenth.Text = "Sixteenth Step";
            this.rbSixteenth.UseVisualStyleBackColor = true;
            this.rbSixteenth.Click += new System.EventHandler(this.rbSixteenth_Click);
            // 
            // rbEighth
            // 
            this.rbEighth.AutoSize = true;
            this.rbEighth.Location = new System.Drawing.Point(143, 63);
            this.rbEighth.Name = "rbEighth";
            this.rbEighth.Size = new System.Drawing.Size(102, 21);
            this.rbEighth.TabIndex = 3;
            this.rbEighth.Text = "Eighth Step";
            this.rbEighth.UseVisualStyleBackColor = true;
            this.rbEighth.Click += new System.EventHandler(this.rbSixteenth_Click);
            // 
            // rbQuarter
            // 
            this.rbQuarter.AutoSize = true;
            this.rbQuarter.Location = new System.Drawing.Point(143, 36);
            this.rbQuarter.Name = "rbQuarter";
            this.rbQuarter.Size = new System.Drawing.Size(111, 21);
            this.rbQuarter.TabIndex = 2;
            this.rbQuarter.Text = "Quarter Step";
            this.rbQuarter.UseVisualStyleBackColor = true;
            this.rbQuarter.Click += new System.EventHandler(this.rbSixteenth_Click);
            // 
            // rbHalf
            // 
            this.rbHalf.AutoSize = true;
            this.rbHalf.Location = new System.Drawing.Point(6, 63);
            this.rbHalf.Name = "rbHalf";
            this.rbHalf.Size = new System.Drawing.Size(87, 21);
            this.rbHalf.TabIndex = 1;
            this.rbHalf.Text = "Half Step";
            this.rbHalf.UseVisualStyleBackColor = true;
            this.rbHalf.Click += new System.EventHandler(this.rbSixteenth_Click);
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Checked = true;
            this.rbFull.Location = new System.Drawing.Point(6, 36);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(84, 21);
            this.rbFull.TabIndex = 0;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "Full Step";
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.Click += new System.EventHandler(this.rbSixteenth_Click);
            // 
            // lblTpm
            // 
            this.lblTpm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTpm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTpm.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpm.Location = new System.Drawing.Point(96, 326);
            this.lblTpm.Name = "lblTpm";
            this.lblTpm.Size = new System.Drawing.Size(259, 67);
            this.lblTpm.TabIndex = 13;
            this.lblTpm.Text = "-- tr/min";
            this.lblTpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusOnOff
            // 
            this.lblStatusOnOff.AutoSize = true;
            this.lblStatusOnOff.Location = new System.Drawing.Point(114, 405);
            this.lblStatusOnOff.Name = "lblStatusOnOff";
            this.lblStatusOnOff.Size = new System.Drawing.Size(35, 17);
            this.lblStatusOnOff.TabIndex = 14;
            this.lblStatusOnOff.Text = "OFF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Motor Status : ";
            // 
            // lblWise
            // 
            this.lblWise.AutoSize = true;
            this.lblWise.Location = new System.Drawing.Point(156, 405);
            this.lblWise.Name = "lblWise";
            this.lblWise.Size = new System.Drawing.Size(97, 17);
            this.lblWise.TabIndex = 16;
            this.lblWise.Text = "Anti Clockwise";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.Location = new System.Drawing.Point(270, 407);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(30, 17);
            this.lblResolution.TabIndex = 17;
            this.lblResolution.Text = "Full";
            // 
            // tbRPM
            // 
            this.tbRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRPM.Location = new System.Drawing.Point(159, 251);
            this.tbRPM.Name = "tbRPM";
            this.tbRPM.Size = new System.Drawing.Size(107, 30);
            this.tbRPM.TabIndex = 18;
            this.tbRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "RPM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "tr/min";
            // 
            // btnAppliquerRPM
            // 
            this.btnAppliquerRPM.Location = new System.Drawing.Point(342, 251);
            this.btnAppliquerRPM.Name = "btnAppliquerRPM";
            this.btnAppliquerRPM.Size = new System.Drawing.Size(84, 33);
            this.btnAppliquerRPM.TabIndex = 21;
            this.btnAppliquerRPM.Text = "Appliquer";
            this.btnAppliquerRPM.UseVisualStyleBackColor = true;
            this.btnAppliquerRPM.Click += new System.EventHandler(this.btnAppliquerRPM_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(364, 326);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 67);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoins.Location = new System.Drawing.Point(12, 326);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(75, 67);
            this.btnMoins.TabIndex = 23;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 469);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnAppliquerRPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRPM);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblWise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatusOnOff);
            this.Controls.Add(this.lblTpm);
            this.Controls.Add(this.gbResolution);
            this.Controls.Add(this.btnAvRec);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btPort);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stepper Motor Control A4988";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbResolution.ResumeLayout(false);
            this.gbResolution.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btnAvRec;
        private System.Windows.Forms.GroupBox gbResolution;
        private System.Windows.Forms.RadioButton rbSixteenth;
        private System.Windows.Forms.RadioButton rbEighth;
        private System.Windows.Forms.RadioButton rbQuarter;
        private System.Windows.Forms.RadioButton rbHalf;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.Label lblTpm;
        private System.Windows.Forms.Label lblStatusOnOff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWise;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.TextBox tbRPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAppliquerRPM;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
    }
}

