

namespace Mijanka
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureRailA = new System.Windows.Forms.PictureBox();
            this.pictureRailB = new System.Windows.Forms.PictureBox();
            this.pictureDoubleRail = new System.Windows.Forms.PictureBox();
            this.pictureTrainA = new System.Windows.Forms.PictureBox();
            this.pictureTrainUp = new System.Windows.Forms.PictureBox();
            this.pictureTrainDown = new System.Windows.Forms.PictureBox();
            this.pictureTrainB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slowAB = new System.Windows.Forms.Button();
            this.superSlowAB = new System.Windows.Forms.Button();
            this.normalAB = new System.Windows.Forms.Button();
            this.fastAB = new System.Windows.Forms.Button();
            this.superFastAB = new System.Windows.Forms.Button();
            this.superFastBA = new System.Windows.Forms.Button();
            this.fastBA = new System.Windows.Forms.Button();
            this.normalBA = new System.Windows.Forms.Button();
            this.superSlowBA = new System.Windows.Forms.Button();
            this.slowBA = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.domainUpDownBA = new System.Windows.Forms.DomainUpDown();
            this.buttonSpeedBA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRailA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRailB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoubleRail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureRailA
            // 
            this.pictureRailA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureRailA.Image = ((System.Drawing.Image)(resources.GetObject("pictureRailA.Image")));
            this.pictureRailA.Location = new System.Drawing.Point(40, 214);
            this.pictureRailA.Name = "pictureRailA";
            this.pictureRailA.Size = new System.Drawing.Size(300, 20);
            this.pictureRailA.TabIndex = 0;
            this.pictureRailA.TabStop = false;
            // 
            // pictureRailB
            // 
            this.pictureRailB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureRailB.Image = ((System.Drawing.Image)(resources.GetObject("pictureRailB.Image")));
            this.pictureRailB.Location = new System.Drawing.Point(660, 214);
            this.pictureRailB.Name = "pictureRailB";
            this.pictureRailB.Size = new System.Drawing.Size(300, 20);
            this.pictureRailB.TabIndex = 1;
            this.pictureRailB.TabStop = false;
            // 
            // pictureDoubleRail
            // 
            this.pictureDoubleRail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureDoubleRail.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureDoubleRail.ErrorImage")));
            this.pictureDoubleRail.Image = ((System.Drawing.Image)(resources.GetObject("pictureDoubleRail.Image")));
            this.pictureDoubleRail.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureDoubleRail.InitialImage")));
            this.pictureDoubleRail.Location = new System.Drawing.Point(340, 198);
            this.pictureDoubleRail.Name = "pictureDoubleRail";
            this.pictureDoubleRail.Size = new System.Drawing.Size(320, 50);
            this.pictureDoubleRail.TabIndex = 2;
            this.pictureDoubleRail.TabStop = false;
            // 
            // pictureTrainA
            // 
            this.pictureTrainA.BackColor = System.Drawing.Color.Red;
            this.pictureTrainA.Location = new System.Drawing.Point(40, 219);
            this.pictureTrainA.Name = "pictureTrainA";
            this.pictureTrainA.Size = new System.Drawing.Size(20, 10);
            this.pictureTrainA.TabIndex = 3;
            this.pictureTrainA.TabStop = false;
            this.pictureTrainA.Visible = false;
            // 
            // pictureTrainUp
            // 
            this.pictureTrainUp.BackColor = System.Drawing.Color.Red;
            this.pictureTrainUp.Location = new System.Drawing.Point(340, 203);
            this.pictureTrainUp.Name = "pictureTrainUp";
            this.pictureTrainUp.Size = new System.Drawing.Size(20, 10);
            this.pictureTrainUp.TabIndex = 4;
            this.pictureTrainUp.TabStop = false;
            this.pictureTrainUp.Visible = false;
            // 
            // pictureTrainDown
            // 
            this.pictureTrainDown.BackColor = System.Drawing.Color.Red;
            this.pictureTrainDown.Location = new System.Drawing.Point(340, 233);
            this.pictureTrainDown.Name = "pictureTrainDown";
            this.pictureTrainDown.Size = new System.Drawing.Size(20, 10);
            this.pictureTrainDown.TabIndex = 5;
            this.pictureTrainDown.TabStop = false;
            this.pictureTrainDown.Visible = false;
            // 
            // pictureTrainB
            // 
            this.pictureTrainB.BackColor = System.Drawing.Color.Red;
            this.pictureTrainB.Location = new System.Drawing.Point(660, 219);
            this.pictureTrainB.Name = "pictureTrainB";
            this.pictureTrainB.Size = new System.Drawing.Size(20, 10);
            this.pictureTrainB.TabIndex = 6;
            this.pictureTrainB.TabStop = false;
            this.pictureTrainB.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slowAB
            // 
            this.slowAB.Location = new System.Drawing.Point(40, 151);
            this.slowAB.Name = "slowAB";
            this.slowAB.Size = new System.Drawing.Size(76, 22);
            this.slowAB.TabIndex = 7;
            this.slowAB.Text = "slow";
            this.slowAB.UseVisualStyleBackColor = true;
            this.slowAB.Click += new System.EventHandler(this.slowAB_Click);
            // 
            // superSlowAB
            // 
            this.superSlowAB.Location = new System.Drawing.Point(40, 179);
            this.superSlowAB.Name = "superSlowAB";
            this.superSlowAB.Size = new System.Drawing.Size(76, 22);
            this.superSlowAB.TabIndex = 8;
            this.superSlowAB.Text = "super slow";
            this.superSlowAB.UseVisualStyleBackColor = true;
            this.superSlowAB.Click += new System.EventHandler(this.superSlowAB_Click);
            // 
            // normalAB
            // 
            this.normalAB.Location = new System.Drawing.Point(40, 123);
            this.normalAB.Name = "normalAB";
            this.normalAB.Size = new System.Drawing.Size(76, 22);
            this.normalAB.TabIndex = 9;
            this.normalAB.Text = "normal";
            this.normalAB.UseVisualStyleBackColor = true;
            this.normalAB.Click += new System.EventHandler(this.normalAB_Click);
            // 
            // fastAB
            // 
            this.fastAB.Location = new System.Drawing.Point(40, 95);
            this.fastAB.Name = "fastAB";
            this.fastAB.Size = new System.Drawing.Size(76, 22);
            this.fastAB.TabIndex = 10;
            this.fastAB.Text = "fast";
            this.fastAB.UseVisualStyleBackColor = true;
            this.fastAB.Click += new System.EventHandler(this.fastAB_Click);
            // 
            // superFastAB
            // 
            this.superFastAB.Location = new System.Drawing.Point(40, 67);
            this.superFastAB.Name = "superFastAB";
            this.superFastAB.Size = new System.Drawing.Size(76, 22);
            this.superFastAB.TabIndex = 11;
            this.superFastAB.Text = "super fast";
            this.superFastAB.UseVisualStyleBackColor = true;
            this.superFastAB.Click += new System.EventHandler(this.superFastAB_Click);
            // 
            // superFastBA
            // 
            this.superFastBA.Location = new System.Drawing.Point(884, 67);
            this.superFastBA.Name = "superFastBA";
            this.superFastBA.Size = new System.Drawing.Size(76, 22);
            this.superFastBA.TabIndex = 16;
            this.superFastBA.Text = "super fast";
            this.superFastBA.UseVisualStyleBackColor = true;
            this.superFastBA.Click += new System.EventHandler(this.superFastBA_Click);
            // 
            // fastBA
            // 
            this.fastBA.Location = new System.Drawing.Point(884, 95);
            this.fastBA.Name = "fastBA";
            this.fastBA.Size = new System.Drawing.Size(76, 22);
            this.fastBA.TabIndex = 15;
            this.fastBA.Text = "fast";
            this.fastBA.UseVisualStyleBackColor = true;
            this.fastBA.Click += new System.EventHandler(this.fastBA_Click);
            // 
            // normalBA
            // 
            this.normalBA.Location = new System.Drawing.Point(884, 123);
            this.normalBA.Name = "normalBA";
            this.normalBA.Size = new System.Drawing.Size(76, 22);
            this.normalBA.TabIndex = 14;
            this.normalBA.Text = "normal";
            this.normalBA.UseVisualStyleBackColor = true;
            this.normalBA.Click += new System.EventHandler(this.normalBA_Click);
            // 
            // superSlowBA
            // 
            this.superSlowBA.Location = new System.Drawing.Point(884, 179);
            this.superSlowBA.Name = "superSlowBA";
            this.superSlowBA.Size = new System.Drawing.Size(76, 23);
            this.superSlowBA.TabIndex = 13;
            this.superSlowBA.Text = "super slow";
            this.superSlowBA.UseVisualStyleBackColor = true;
            this.superSlowBA.Click += new System.EventHandler(this.superSlowBA_Click);
            // 
            // slowBA
            // 
            this.slowBA.Location = new System.Drawing.Point(884, 151);
            this.slowBA.Name = "slowBA";
            this.slowBA.Size = new System.Drawing.Size(76, 22);
            this.slowBA.TabIndex = 12;
            this.slowBA.Text = "slow";
            this.slowBA.UseVisualStyleBackColor = true;
            this.slowBA.Click += new System.EventHandler(this.slowBA_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Red;
            this.labelA.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelA.Location = new System.Drawing.Point(40, 237);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(49, 54);
            this.labelA.TabIndex = 17;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Lime;
            this.labelB.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelB.Location = new System.Drawing.Point(911, 237);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(46, 54);
            this.labelB.TabIndex = 18;
            this.labelB.Text = "B";
            // 
            // domainUpDownBA
            // 
            this.domainUpDownBA.Location = new System.Drawing.Point(848, 38);
            this.domainUpDownBA.Name = "domainUpDownBA";
            this.domainUpDownBA.Size = new System.Drawing.Size(30, 23);
            this.domainUpDownBA.TabIndex = 19;
            this.domainUpDownBA.Text = "1";
            // 
            // buttonSpeedBA
            // 
            this.buttonSpeedBA.Location = new System.Drawing.Point(884, 39);
            this.buttonSpeedBA.Name = "buttonSpeedBA";
            this.buttonSpeedBA.Size = new System.Drawing.Size(76, 22);
            this.buttonSpeedBA.TabIndex = 20;
            this.buttonSpeedBA.Text = "speed";
            this.buttonSpeedBA.UseVisualStyleBackColor = true;
            this.buttonSpeedBA.Click += new System.EventHandler(this.buttonSpeedBA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 357);
            this.Controls.Add(this.buttonSpeedBA);
            this.Controls.Add(this.domainUpDownBA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.superFastBA);
            this.Controls.Add(this.fastBA);
            this.Controls.Add(this.normalBA);
            this.Controls.Add(this.superSlowBA);
            this.Controls.Add(this.slowBA);
            this.Controls.Add(this.superFastAB);
            this.Controls.Add(this.fastAB);
            this.Controls.Add(this.normalAB);
            this.Controls.Add(this.superSlowAB);
            this.Controls.Add(this.slowAB);
            this.Controls.Add(this.pictureTrainB);
            this.Controls.Add(this.pictureTrainDown);
            this.Controls.Add(this.pictureTrainUp);
            this.Controls.Add(this.pictureTrainA);
            this.Controls.Add(this.pictureDoubleRail);
            this.Controls.Add(this.pictureRailB);
            this.Controls.Add(this.pictureRailA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRailA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRailB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDoubleRail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrainB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRailA;
        private System.Windows.Forms.PictureBox pictureRailB;
        private System.Windows.Forms.PictureBox pictureDoubleRail;
        private System.Windows.Forms.PictureBox pictureTrainA;
        private System.Windows.Forms.PictureBox pictureTrainUp;
        private System.Windows.Forms.PictureBox pictureTrainDown;
        private System.Windows.Forms.PictureBox pictureTrainB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button slowAB;
        private System.Windows.Forms.Button superSlowAB;
        private System.Windows.Forms.Button normalAB;
        private System.Windows.Forms.Button fastAB;
        private System.Windows.Forms.Button superFastAB;
        private System.Windows.Forms.Button superFastBA;
        private System.Windows.Forms.Button fastBA;
        private System.Windows.Forms.Button normalBA;
        private System.Windows.Forms.Button superSlowBA;
        private System.Windows.Forms.Button slowBA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.DomainUpDown domainUpDownBA;
        private System.Windows.Forms.Button buttonSpeedBA;
    }
}

