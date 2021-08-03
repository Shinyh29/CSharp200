namespace A154_Menu
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폰트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색깔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memeber1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.member2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bigmenu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigmenu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.menu3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트ToolStripMenuItem,
            this.색깔ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.편집ToolStripMenuItem.Text = "폰트와 색";
            // 
            // 폰트ToolStripMenuItem
            // 
            this.폰트ToolStripMenuItem.Name = "폰트ToolStripMenuItem";
            this.폰트ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.폰트ToolStripMenuItem.Text = "폰트";
            this.폰트ToolStripMenuItem.Click += new System.EventHandler(this.폰트ToolStripMenuItem_Click);
            // 
            // 색깔ToolStripMenuItem
            // 
            this.색깔ToolStripMenuItem.Name = "색깔ToolStripMenuItem";
            this.색깔ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.색깔ToolStripMenuItem.Text = "배경색";
            this.색깔ToolStripMenuItem.Click += new System.EventHandler(this.배경색ToolStripMenuItem_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(62, 71);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 12);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "lblTime";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memeber1ToolStripMenuItem,
            this.member2ToolStripMenuItem});
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.menu3ToolStripMenuItem.Text = "Menu3";
            // 
            // memeber1ToolStripMenuItem
            // 
            this.memeber1ToolStripMenuItem.Name = "memeber1ToolStripMenuItem";
            this.memeber1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memeber1ToolStripMenuItem.Text = "memeber1";
            this.memeber1ToolStripMenuItem.Click += new System.EventHandler(this.memeber1ToolStripMenuItem_Click);
            // 
            // member2ToolStripMenuItem
            // 
            this.member2ToolStripMenuItem.Name = "member2ToolStripMenuItem";
            this.member2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.member2ToolStripMenuItem.Text = "member2";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bigmenu1ToolStripMenuItem,
            this.bigmenu2ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(714, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // bigmenu1ToolStripMenuItem
            // 
            this.bigmenu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.bigmenu1ToolStripMenuItem.Name = "bigmenu1ToolStripMenuItem";
            this.bigmenu1ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.bigmenu1ToolStripMenuItem.Text = "bigmenu1";
            // 
            // bigmenu2ToolStripMenuItem
            // 
            this.bigmenu2ToolStripMenuItem.Name = "bigmenu2ToolStripMenuItem";
            this.bigmenu2ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.bigmenu2ToolStripMenuItem.Text = "bigmenu2";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helloToolStripMenuItem.Text = "Hello";
            this.helloToolStripMenuItem.Click += new System.EventHandler(this.helloToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 226);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Menu와 DialogBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 폰트ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 색깔ToolStripMenuItem;
    private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memeber1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem member2ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bigmenu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigmenu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
    }
}

