namespace Racing.Window
{
    partial class Main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.offMusic = new System.Windows.Forms.Button();
            this.OnMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Algerian", 36F);
            this.button1.Location = new System.Drawing.Point(257, 41);
            this.button1.MaximumSize = new System.Drawing.Size(323, 63);
            this.button1.MinimumSize = new System.Drawing.Size(323, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Algerian", 36F);
            this.button2.Location = new System.Drawing.Point(257, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Algerian", 36F);
            this.button3.Location = new System.Drawing.Point(257, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(323, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Creator by Anton Vorobiov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(650, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "ver 1.0";
            // 
            // offMusic
            // 
            this.offMusic.BackColor = System.Drawing.Color.Transparent;
            this.offMusic.Font = new System.Drawing.Font("Algerian", 14F);
            this.offMusic.Location = new System.Drawing.Point(687, 414);
            this.offMusic.Name = "offMusic";
            this.offMusic.Size = new System.Drawing.Size(100, 26);
            this.offMusic.TabIndex = 5;
            this.offMusic.Text = "Off ";
            this.offMusic.UseVisualStyleBackColor = false;
            this.offMusic.Click += new System.EventHandler(this.offMusic_Click);
            // 
            // OnMusic
            // 
            this.OnMusic.BackColor = System.Drawing.Color.Transparent;
            this.OnMusic.Font = new System.Drawing.Font("Algerian", 14F);
            this.OnMusic.Location = new System.Drawing.Point(687, 415);
            this.OnMusic.Name = "OnMusic";
            this.OnMusic.Size = new System.Drawing.Size(100, 26);
            this.OnMusic.TabIndex = 6;
            this.OnMusic.Text = "On";
            this.OnMusic.UseVisualStyleBackColor = false;
            this.OnMusic.Click += new System.EventHandler(this.OnMusic_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Racing.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.OnMusic);
            this.Controls.Add(this.offMusic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 150);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button offMusic;
        private System.Windows.Forms.Button OnMusic;
    }
}