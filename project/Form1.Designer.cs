
namespace Курсовая
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fdfdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfdfdvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdvfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nbmbnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nNnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip2;
            this.button1.Location = new System.Drawing.Point(174, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 118);
            this.button1.TabIndex = 0;
            this.button1.Text = "Неориентированный граф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 118);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ориентированный граф";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdfdfToolStripMenuItem,
            this.dfdfdvToolStripMenuItem,
            this.fdvfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fdfdfToolStripMenuItem
            // 
            this.fdfdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdfdToolStripMenuItem});
            this.fdfdfToolStripMenuItem.Name = "fdfdfToolStripMenuItem";
            this.fdfdfToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.fdfdfToolStripMenuItem.Text = "fdfdf";
            // 
            // fdfdToolStripMenuItem
            // 
            this.fdfdToolStripMenuItem.Name = "fdfdToolStripMenuItem";
            this.fdfdToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fdfdToolStripMenuItem.Text = "fdfd";
            // 
            // dfdfdvToolStripMenuItem
            // 
            this.dfdfdvToolStripMenuItem.Name = "dfdfdvToolStripMenuItem";
            this.dfdfdvToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.dfdfdvToolStripMenuItem.Text = "dfdfdv";
            // 
            // fdvfToolStripMenuItem
            // 
            this.fdvfToolStripMenuItem.Name = "fdvfToolStripMenuItem";
            this.fdvfToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.fdvfToolStripMenuItem.Text = "fdvf";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nbmbnToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(126, 28);
            // 
            // nbmbnToolStripMenuItem
            // 
            this.nbmbnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nnToolStripMenuItem,
            this.nNnToolStripMenuItem});
            this.nbmbnToolStripMenuItem.Name = "nbmbnToolStripMenuItem";
            this.nbmbnToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.nbmbnToolStripMenuItem.Text = "nbmbn";
            // 
            // nnToolStripMenuItem
            // 
            this.nnToolStripMenuItem.Name = "nnToolStripMenuItem";
            this.nnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nnToolStripMenuItem.Text = "nn";
            // 
            // nNnToolStripMenuItem
            // 
            this.nNnToolStripMenuItem.Name = "nNnToolStripMenuItem";
            this.nNnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nNnToolStripMenuItem.Text = "n  nn";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fdfdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdfdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfdfdvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdvfToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem nbmbnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nNnToolStripMenuItem;
    }
}

