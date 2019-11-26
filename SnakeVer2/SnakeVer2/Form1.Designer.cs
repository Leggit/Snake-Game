namespace SnakeVer2
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
            this.components = new System.ComponentModel.Container();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.actionBtn = new System.Windows.Forms.Button();
            this.speedSetter = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speedSetter)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Green;
            this.gamePanel.Location = new System.Drawing.Point(180, 13);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(527, 538);
            this.gamePanel.TabIndex = 1;
            // 
            // scoreLbl
            // 
            this.scoreLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(13, 127);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(161, 54);
            this.scoreLbl.TabIndex = 3;
            this.scoreLbl.Text = "1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score: ";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // actionBtn
            // 
            this.actionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.actionBtn.Location = new System.Drawing.Point(13, 13);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(161, 57);
            this.actionBtn.TabIndex = 5;
            this.actionBtn.Text = "Start";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // speedSetter
            // 
            this.speedSetter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.speedSetter.LargeChange = 1;
            this.speedSetter.Location = new System.Drawing.Point(13, 213);
            this.speedSetter.Maximum = 5;
            this.speedSetter.Minimum = 1;
            this.speedSetter.Name = "speedSetter";
            this.speedSetter.Size = new System.Drawing.Size(161, 69);
            this.speedSetter.TabIndex = 7;
            this.speedSetter.Value = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Difficulty:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedSetter);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.gamePanel);
            this.MaximumSize = new System.Drawing.Size(757, 629);
            this.MinimumSize = new System.Drawing.Size(757, 629);
            this.Name = "Form1";
            this.Text = "SNAYKE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speedSetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.TrackBar speedSetter;
        private System.Windows.Forms.Label label2;
    }
}

