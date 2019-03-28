namespace DragonSlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblArmor = new System.Windows.Forms.Label();
            this.pnlDragonHealth = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPlayerHealth = new System.Windows.Forms.Panel();
            this.btnUseElixir = new System.Windows.Forms.Button();
            this.btnViolentFlurry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlGame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 417);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(529, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 254);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Dragon Slayer \r\n\r\n\r\n\r\nA Game by Chris Aspden.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(529, 394);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(774, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 448);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 327);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(516, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 327);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(9, 419);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(158, 26);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(251, 419);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(158, 26);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.lblArmor);
            this.pnlGame.Controls.Add(this.pnlDragonHealth);
            this.pnlGame.Controls.Add(this.panel3);
            this.pnlGame.Controls.Add(this.panel2);
            this.pnlGame.Controls.Add(this.btnUseElixir);
            this.pnlGame.Controls.Add(this.btnViolentFlurry);
            this.pnlGame.Controls.Add(this.btnRoll);
            this.pnlGame.Controls.Add(this.btnAttack);
            this.pnlGame.Controls.Add(this.pictureBox3);
            this.pnlGame.Controls.Add(this.pictureBox2);
            this.pnlGame.Location = new System.Drawing.Point(3, 2);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1037, 513);
            this.pnlGame.TabIndex = 6;
            this.pnlGame.Visible = false;
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Location = new System.Drawing.Point(384, 394);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(25, 13);
            this.lblArmor.TabIndex = 9;
            this.lblArmor.Text = "100";
            // 
            // pnlDragonHealth
            // 
            this.pnlDragonHealth.BackColor = System.Drawing.Color.Yellow;
            this.pnlDragonHealth.Location = new System.Drawing.Point(516, 347);
            this.pnlDragonHealth.Name = "pnlDragonHealth";
            this.pnlDragonHealth.Size = new System.Drawing.Size(400, 30);
            this.pnlDragonHealth.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(516, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 30);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pnlPlayerHealth);
            this.panel2.Location = new System.Drawing.Point(9, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 30);
            this.panel2.TabIndex = 6;
            // 
            // pnlPlayerHealth
            // 
            this.pnlPlayerHealth.BackColor = System.Drawing.Color.Yellow;
            this.pnlPlayerHealth.Location = new System.Drawing.Point(0, 0);
            this.pnlPlayerHealth.Name = "pnlPlayerHealth";
            this.pnlPlayerHealth.Size = new System.Drawing.Size(400, 30);
            this.pnlPlayerHealth.TabIndex = 7;
            // 
            // btnUseElixir
            // 
            this.btnUseElixir.Location = new System.Drawing.Point(251, 466);
            this.btnUseElixir.Name = "btnUseElixir";
            this.btnUseElixir.Size = new System.Drawing.Size(158, 26);
            this.btnUseElixir.TabIndex = 5;
            this.btnUseElixir.Text = "Use Elixir";
            this.btnUseElixir.UseVisualStyleBackColor = true;
            this.btnUseElixir.Click += new System.EventHandler(this.btnUseElixir_Click);
            // 
            // btnViolentFlurry
            // 
            this.btnViolentFlurry.Enabled = false;
            this.btnViolentFlurry.Location = new System.Drawing.Point(9, 466);
            this.btnViolentFlurry.Name = "btnViolentFlurry";
            this.btnViolentFlurry.Size = new System.Drawing.Size(158, 26);
            this.btnViolentFlurry.TabIndex = 4;
            this.btnViolentFlurry.Text = "Violent Flurry";
            this.btnViolentFlurry.UseVisualStyleBackColor = true;
            this.btnViolentFlurry.Click += new System.EventHandler(this.btnViolentFlurry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 518);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btnUseElixir;
        private System.Windows.Forms.Button btnViolentFlurry;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlDragonHealth;
        private System.Windows.Forms.Panel pnlPlayerHealth;
        private System.Windows.Forms.Label lblArmor;
    }
}

