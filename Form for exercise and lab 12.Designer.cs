
namespace Form_For_Exercise_and_Lab_12
{
    partial class Formfinal
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formfinal));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnpaper = new System.Windows.Forms.Button();
            this.btnrock = new System.Windows.Forms.Button();
            this.btnscissors = new System.Windows.Forms.Button();
            this.SubPanel = new System.Windows.Forms.Panel();
            this.lblPC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainPanel.Controls.Add(this.btnpaper);
            this.MainPanel.Controls.Add(this.btnrock);
            this.MainPanel.Controls.Add(this.btnscissors);
            this.MainPanel.Location = new System.Drawing.Point(112, 455);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1060, 250);
            this.MainPanel.TabIndex = 0;
            // 
            // btnpaper
            // 
            this.btnpaper.BackColor = System.Drawing.Color.Teal;
            this.btnpaper.Font = new System.Drawing.Font("Gadugi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaper.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnpaper.Location = new System.Drawing.Point(795, 90);
            this.btnpaper.Name = "btnpaper";
            this.btnpaper.Size = new System.Drawing.Size(180, 80);
            this.btnpaper.TabIndex = 2;
            this.btnpaper.Text = "Paper";
            this.btnpaper.UseVisualStyleBackColor = false;
            this.btnpaper.Click += new System.EventHandler(this.btnpaper_Click);
            // 
            // btnrock
            // 
            this.btnrock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnrock.Font = new System.Drawing.Font("Gadugi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrock.ForeColor = System.Drawing.Color.Gold;
            this.btnrock.Location = new System.Drawing.Point(435, 90);
            this.btnrock.Name = "btnrock";
            this.btnrock.Size = new System.Drawing.Size(180, 80);
            this.btnrock.TabIndex = 1;
            this.btnrock.Text = "Rock";
            this.btnrock.UseVisualStyleBackColor = false;
            this.btnrock.Click += new System.EventHandler(this.btnrock_Click);
            // 
            // btnscissors
            // 
            this.btnscissors.BackColor = System.Drawing.Color.SlateGray;
            this.btnscissors.Font = new System.Drawing.Font("Gadugi", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscissors.ForeColor = System.Drawing.Color.Orange;
            this.btnscissors.Location = new System.Drawing.Point(80, 90);
            this.btnscissors.Name = "btnscissors";
            this.btnscissors.Size = new System.Drawing.Size(180, 80);
            this.btnscissors.TabIndex = 0;
            this.btnscissors.Text = "Scissors";
            this.btnscissors.UseVisualStyleBackColor = false;
            this.btnscissors.Click += new System.EventHandler(this.btnscissors_Click);
            // 
            // SubPanel
            // 
            this.SubPanel.BackColor = System.Drawing.Color.Ivory;
            this.SubPanel.Controls.Add(this.lblPC);
            this.SubPanel.Controls.Add(this.label3);
            this.SubPanel.Controls.Add(this.lblPlayer);
            this.SubPanel.Controls.Add(this.label1);
            this.SubPanel.Location = new System.Drawing.Point(140, 70);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(1000, 170);
            this.SubPanel.TabIndex = 1;
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.BackColor = System.Drawing.Color.OrangeRed;
            this.lblPC.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblPC.Location = new System.Drawing.Point(715, 80);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(0, 34);
            this.lblPC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(660, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "↓PC\'s  Value↓";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Khaki;
            this.lblPlayer.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(155, 80);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 34);
            this.lblPlayer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "↓Player\'s Value↓";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Salmon;
            this.Exit.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.Exit.Location = new System.Drawing.Point(120, 380);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 60);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 54F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblResult.Image = ((System.Drawing.Image)(resources.GetObject("lblResult.Image")));
            this.lblResult.Location = new System.Drawing.Point(420, 255);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 84);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Formfinal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1284, 712);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SubPanel);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Formfinal";
            this.RightToLeftLayout = true;
            this.Text = "Form For 12";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.MainPanel.ResumeLayout(false);
            this.SubPanel.ResumeLayout(false);
            this.SubPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SubPanel;
        private System.Windows.Forms.Button btnpaper;
        private System.Windows.Forms.Button btnrock;
        private System.Windows.Forms.Button btnscissors;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

