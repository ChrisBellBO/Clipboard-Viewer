using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClipboardViewer
{
  public class Renderer : UserControl
  {
    public virtual void LoadData(object data, string dataFormat)
    {
      throw new Exception("Implement LoadData");
    }

    public virtual void Save(string fileName)
    {
      throw new Exception("Save not implemented for this renderer");
    }
  }
}
