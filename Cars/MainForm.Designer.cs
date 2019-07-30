namespace CarRace
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tmrPaint = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbAI = new System.Windows.Forms.RadioButton();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericBet = new System.Windows.Forms.NumericUpDown();
            this.numericCar = new System.Windows.Forms.NumericUpDown();
            this.txtJoe = new System.Windows.Forms.TextBox();
            this.txtBob = new System.Windows.Forms.TextBox();
            this.txtAI = new System.Windows.Forms.TextBox();
            this.lblmax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblWhoBets = new System.Windows.Forms.Label();
            this.maxlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPaint
            // 
            this.tmrPaint.Enabled = true;
            this.tmrPaint.Interval = 25;
            this.tmrPaint.Tick += new System.EventHandler(this.tmrPaint_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(534, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 63);
            this.panel1.TabIndex = 7;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(88, 24);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(73, 31);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reset";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            this.btnReiniciar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.btnReiniciar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Race";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.lblDistancia);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblPrimero);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 63);
            this.panel3.TabIndex = 10;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(162, 44);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(13, 13);
            this.lblDistancia.TabIndex = 12;
            this.lblDistancia.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Traveled distance(in meters):";
            // 
            // lblPrimero
            // 
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimero.Location = new System.Drawing.Point(80, 26);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(31, 13);
            this.lblPrimero.TabIndex = 10;
            this.lblPrimero.Text = "none";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Race info";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.maxlbl);
            this.panel4.Controls.Add(this.lblWhoBets);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.lblmax);
            this.panel4.Controls.Add(this.txtAI);
            this.panel4.Controls.Add(this.txtBob);
            this.panel4.Controls.Add(this.txtJoe);
            this.panel4.Controls.Add(this.numericCar);
            this.panel4.Controls.Add(this.numericBet);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblMaxBet);
            this.panel4.Location = new System.Drawing.Point(66, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 74);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Location = new System.Drawing.Point(6, 5);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(42, 17);
            this.rbJoe.TabIndex = 0;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(6, 22);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(44, 17);
            this.rbBob.TabIndex = 1;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // rbAI
            // 
            this.rbAI.AutoSize = true;
            this.rbAI.Location = new System.Drawing.Point(6, 42);
            this.rbAI.Name = "rbAI";
            this.rbAI.Size = new System.Drawing.Size(34, 17);
            this.rbAI.TabIndex = 2;
            this.rbAI.TabStop = true;
            this.rbAI.Text = "Al";
            this.rbAI.UseVisualStyleBackColor = true;
            this.rbAI.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.Location = new System.Drawing.Point(55, 19);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(64, 13);
            this.lblMaxBet.TabIndex = 3;
            this.lblMaxBet.Text = "Max bet is $";
            this.lblMaxBet.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "bets $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "on car number #";
            // 
            // numericBet
            // 
            this.numericBet.Location = new System.Drawing.Point(236, 17);
            this.numericBet.Name = "numericBet";
            this.numericBet.Size = new System.Drawing.Size(59, 20);
            this.numericBet.TabIndex = 13;
            // 
            // numericCar
            // 
            this.numericCar.Location = new System.Drawing.Point(236, 48);
            this.numericCar.Name = "numericCar";
            this.numericCar.Size = new System.Drawing.Size(59, 20);
            this.numericCar.TabIndex = 14;
            // 
            // txtJoe
            // 
            this.txtJoe.Location = new System.Drawing.Point(374, 3);
            this.txtJoe.Name = "txtJoe";
            this.txtJoe.Size = new System.Drawing.Size(143, 20);
            this.txtJoe.TabIndex = 15;
            // 
            // txtBob
            // 
            this.txtBob.Location = new System.Drawing.Point(374, 25);
            this.txtBob.Name = "txtBob";
            this.txtBob.Size = new System.Drawing.Size(143, 20);
            this.txtBob.TabIndex = 16;
            // 
            // txtAI
            // 
            this.txtAI.Location = new System.Drawing.Point(374, 50);
            this.txtAI.Name = "txtAI";
            this.txtAI.Size = new System.Drawing.Size(143, 20);
            this.txtAI.TabIndex = 16;
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(104, 17);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(0, 13);
            this.lblmax.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJoe);
            this.groupBox1.Controls.Add(this.rbBob);
            this.groupBox1.Controls.Add(this.rbAI);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(55, 60);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(307, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Bet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lblWhoBets
            // 
            this.lblWhoBets.AutoSize = true;
            this.lblWhoBets.Location = new System.Drawing.Point(152, 19);
            this.lblWhoBets.Name = "lblWhoBets";
            this.lblWhoBets.Size = new System.Drawing.Size(0, 13);
            this.lblWhoBets.TabIndex = 20;
            // 
            // maxlbl
            // 
            this.maxlbl.AutoSize = true;
            this.maxlbl.Location = new System.Drawing.Point(132, 17);
            this.maxlbl.Name = "maxlbl";
            this.maxlbl.Size = new System.Drawing.Size(0, 13);
            this.maxlbl.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 537);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car race";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrimero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer tmrPaint;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbAI;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.TextBox txtAI;
        private System.Windows.Forms.TextBox txtBob;
        private System.Windows.Forms.TextBox txtJoe;
        private System.Windows.Forms.NumericUpDown numericCar;
        private System.Windows.Forms.NumericUpDown numericBet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblWhoBets;
        private System.Windows.Forms.Label maxlbl;
    }
}

