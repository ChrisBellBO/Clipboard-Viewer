using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer
{
  class RichTextRenderer : Renderer
  {
    private RichTextBox richTextBox;

    public RichTextRenderer()
    {
      InitializeComponent();
    }

    public override void LoadData(object data, string dataFormat)
    {
      MemoryStream stream = new MemoryStream();
      StreamWriter writer = new StreamWriter(stream, Encoding.Default);
      writer.Write(data.ToString());
      writer.Flush();
      stream.Position = 0;
      richTextBox.LoadFile(stream, RichTextBoxStreamType.RichText);
    }

    private void InitializeComponent()
    {
      this.richTextBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // richTextBox
      // 
      this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox.Location = new System.Drawing.Point(0, 0);
      this.richTextBox.Name = "richTextBox";
      this.richTextBox.ReadOnly = true;
      this.richTextBox.Size = new System.Drawing.Size(150, 150);
      this.richTextBox.TabIndex = 0;
      this.richTextBox.Text = "";
      // 
      // RichTextRenderer
      // 
      this.Controls.Add(this.richTextBox);
      this.Name = "RichTextRenderer";
      this.ResumeLayout(false);

    }
  }
}
