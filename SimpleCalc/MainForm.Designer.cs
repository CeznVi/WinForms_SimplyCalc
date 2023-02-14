namespace SimpleCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.button_Mplus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_MS = new System.Windows.Forms.Button();
            this.button_MR = new System.Windows.Forms.Button();
            this.button_MC = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(344, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.инженерныйToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1,
            this.toolStripSeparator1,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(0, 24);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxResult.Size = new System.Drawing.Size(344, 44);
            this.textBoxResult.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button_Mplus);
            this.panel.Controls.Add(this.button_Minus);
            this.panel.Controls.Add(this.button_MS);
            this.panel.Controls.Add(this.button_MR);
            this.panel.Controls.Add(this.button_MC);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 68);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 373);
            this.panel.TabIndex = 2;
            // 
            // button_Mplus
            // 
            this.button_Mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Mplus.Location = new System.Drawing.Point(210, 6);
            this.button_Mplus.Name = "button_Mplus";
            this.button_Mplus.Size = new System.Drawing.Size(60, 40);
            this.button_Mplus.TabIndex = 4;
            this.button_Mplus.Text = "M+";
            this.button_Mplus.UseVisualStyleBackColor = true;
            // 
            // button_Minus
            // 
            this.button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Minus.Location = new System.Drawing.Point(276, 6);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(60, 40);
            this.button_Minus.TabIndex = 3;
            this.button_Minus.Text = "M-";
            this.button_Minus.UseVisualStyleBackColor = true;
            // 
            // button_MS
            // 
            this.button_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MS.Location = new System.Drawing.Point(144, 6);
            this.button_MS.Name = "button_MS";
            this.button_MS.Size = new System.Drawing.Size(60, 40);
            this.button_MS.TabIndex = 2;
            this.button_MS.Text = "MR";
            this.button_MS.UseVisualStyleBackColor = true;
            this.button_MS.Click += new System.EventHandler(this.button_MS_Click);
            // 
            // button_MR
            // 
            this.button_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MR.Location = new System.Drawing.Point(78, 6);
            this.button_MR.Name = "button_MR";
            this.button_MR.Size = new System.Drawing.Size(60, 40);
            this.button_MR.TabIndex = 1;
            this.button_MR.Text = "MR";
            this.button_MR.UseVisualStyleBackColor = true;
            this.button_MR.Click += new System.EventHandler(this.button_MR_Click);
            // 
            // button_MC
            // 
            this.button_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_MC.Location = new System.Drawing.Point(12, 6);
            this.button_MC.Name = "button_MC";
            this.button_MC.Size = new System.Drawing.Size(60, 40);
            this.button_MC.TabIndex = 0;
            this.button_MC.Text = "MC";
            this.button_MC.UseVisualStyleBackColor = true;
            this.button_MC.Click += new System.EventHandler(this.button_MC_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Калькулятор v1.0.0";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инженерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_Mplus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_MS;
        private System.Windows.Forms.Button button_MR;
        private System.Windows.Forms.Button button_MC;
    }
}

