using System;
using System.Collections.Generic;
using System.Text;

namespace ClipboardViewer
{
  class HtmlRenderer : Renderer
  {
    private System.Windows.Forms.WebBrowser webBrowser;

    public HtmlRenderer()
    {
      InitializeComponent();
    }

    public override void LoadData(object data, string dataFormat)
    {
      webBrowser.DocumentText = data.ToString();
    }

    private void InitializeComponent()
    {
      this.webBrowser = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // webBrowser
      // 
      this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webBrowser.Location = new System.Drawing.Point(0, 0);
      this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser.Name = "webBrowser";
      this.webBrowser.Size = new System.Drawing.Size(150, 150);
      this.webBrowser.TabIndex = 0;
      // 
      // HtmlRenderer
      // 
      this.Controls.Add(this.webBrowser);
      this.Name = "HtmlRenderer";
      this.ResumeLayout(false);

    }
  }
}
