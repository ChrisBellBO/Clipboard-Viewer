using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClipboardViewer
{
  class MemoryStreamRenderer : Renderer
  {
    private System.Windows.Forms.RichTextBox dataBox;

    public MemoryStreamRenderer()
    {
      InitializeComponent();
    }

    public override void LoadData(object data, string dataFormat)
    {
      MemoryStream dataStream = data as MemoryStream;
      StringBuilder builder = new StringBuilder();
      int read = 0;
      while (read > -1)
      {
        read = dataStream.ReadByte();
        if (read > -1)
        {
          byte byteDate = (byte)read;
          builder.Append(byteDate.ToString("X2"));
          builder.Append(" ");
        }
      }
      dataBox.Text = builder.ToString();
    }

    private void InitializeComponent()
    {
      this.dataBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // dataBox
      // 
      this.dataBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataBox.Location = new System.Drawing.Point(0, 0);
      this.dataBox.Name = "dataBox";
      this.dataBox.Size = new System.Drawing.Size(150, 150);
      this.dataBox.TabIndex = 0;
      this.dataBox.Text = "";
      // 
      // MemoryStreamRenderer
      // 
      this.Controls.Add(this.dataBox);
      this.Name = "MemoryStreamRenderer";
      this.ResumeLayout(false);

    }
  }
}
