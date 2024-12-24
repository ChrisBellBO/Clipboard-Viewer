using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClipboardViewer
{
  class TextRenderer : Renderer
  {
    private System.Windows.Forms.TextBox dataBox;
  
    public TextRenderer()
    {
      InitializeComponent();
    }

    public override void LoadData(object data, string dataFormat)
    {
      if (data is string str)
      {
        dataBox.Text = str;
      }
      else if (data is string[] strArray)
      {
        dataBox.Lines = strArray;
      }
      else if (data is Stream stream)
      {
        StreamReader reader;
        if (dataFormat == "UniformResourceLocatorW")
          reader = new StreamReader(stream, Encoding.Unicode);
        else
          reader = new StreamReader(stream);

        dataBox.Text = reader.ReadToEnd();
      }
      else
        throw new Exception("Unexpected data type - " + data.GetType().ToString());
    }

    private void InitializeComponent()
    {
      this.dataBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // dataBox
      // 
      this.dataBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataBox.Location = new System.Drawing.Point(0, 0);
      this.dataBox.Multiline = true;
      this.dataBox.Name = "dataBox";
      this.dataBox.ReadOnly = true;
      this.dataBox.Size = new System.Drawing.Size(150, 150);
      this.dataBox.TabIndex = 0;
      // 
      // TextRenderer
      // 
      this.Controls.Add(this.dataBox);
      this.Name = "TextRenderer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }
  }
}
