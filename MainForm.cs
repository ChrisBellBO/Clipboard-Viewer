using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace ClipboardViewer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox formatsList;
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.MenuItem menuItem1;
    private System.Windows.Forms.MenuItem menuItem2;
    private System.Windows.Forms.MenuItem menuItem3;
    private System.Windows.Forms.MenuItem menuItem4;
    private System.Windows.Forms.MenuItem menuItem5;
    private System.Windows.Forms.Label dataLabel;
    private Panel rendererPanel;
    private ClipboardMonitor clipboardMonitor;
    private MenuItem saveMenuItem;
    private IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.panel1 = new System.Windows.Forms.Panel();
      this.dataLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.formatsList = new System.Windows.Forms.ListBox();
      this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
      this.menuItem1 = new System.Windows.Forms.MenuItem();
      this.saveMenuItem = new System.Windows.Forms.MenuItem();
      this.menuItem2 = new System.Windows.Forms.MenuItem();
      this.menuItem3 = new System.Windows.Forms.MenuItem();
      this.menuItem4 = new System.Windows.Forms.MenuItem();
      this.menuItem5 = new System.Windows.Forms.MenuItem();
      this.rendererPanel = new System.Windows.Forms.Panel();
      this.clipboardMonitor = new ClipboardViewer.ClipboardMonitor();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.clipboardMonitor);
      this.panel1.Controls.Add(this.dataLabel);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(561, 32);
      this.panel1.TabIndex = 0;
      // 
      // dataLabel
      // 
      this.dataLabel.Location = new System.Drawing.Point(152, 8);
      this.dataLabel.Name = "dataLabel";
      this.dataLabel.Size = new System.Drawing.Size(360, 16);
      this.dataLabel.TabIndex = 1;
      this.dataLabel.Text = "Data";
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(4, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Formats";
      // 
      // formatsList
      // 
      this.formatsList.Dock = System.Windows.Forms.DockStyle.Left;
      this.formatsList.Location = new System.Drawing.Point(0, 32);
      this.formatsList.Name = "formatsList";
      this.formatsList.Size = new System.Drawing.Size(152, 251);
      this.formatsList.TabIndex = 1;
      this.formatsList.SelectedIndexChanged += new System.EventHandler(this.formatsList_SelectedIndexChanged);
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3});
      // 
      // menuItem1
      // 
      this.menuItem1.Index = 0;
      this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.saveMenuItem,
            this.menuItem2});
      this.menuItem1.Text = "File";
      // 
      // saveMenuItem
      // 
      this.saveMenuItem.Index = 0;
      this.saveMenuItem.Text = "Save...";
      this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
      // 
      // menuItem2
      // 
      this.menuItem2.Index = 1;
      this.menuItem2.Text = "Exit";
      this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
      // 
      // menuItem3
      // 
      this.menuItem3.Index = 1;
      this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5});
      this.menuItem3.Text = "Clipboard";
      // 
      // menuItem4
      // 
      this.menuItem4.Index = 0;
      this.menuItem4.Text = "Refresh";
      this.menuItem4.Click += new System.EventHandler(this.button1_Click);
      // 
      // menuItem5
      // 
      this.menuItem5.Index = 1;
      this.menuItem5.Text = "Clear";
      this.menuItem5.Click += new System.EventHandler(this.button2_Click);
      // 
      // rendererPanel
      // 
      this.rendererPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rendererPanel.Location = new System.Drawing.Point(152, 32);
      this.rendererPanel.Name = "rendererPanel";
      this.rendererPanel.Size = new System.Drawing.Size(409, 251);
      this.rendererPanel.TabIndex = 2;
      // 
      // clipboardMonitor
      // 
      this.clipboardMonitor.BackColor = System.Drawing.Color.Red;
      this.clipboardMonitor.Location = new System.Drawing.Point(450, 3);
      this.clipboardMonitor.Name = "clipboardMonitor";
      this.clipboardMonitor.Size = new System.Drawing.Size(75, 23);
      this.clipboardMonitor.TabIndex = 0;
      this.clipboardMonitor.Text = "clipboardMonitor1";
      this.clipboardMonitor.Visible = false;
      this.clipboardMonitor.ClipboardChanged += new System.EventHandler<ClipboardViewer.ClipboardChangedEventArgs>(this.clipboardMonitor_ClipboardChanged);
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(561, 283);
      this.Controls.Add(this.rendererPanel);
      this.Controls.Add(this.formatsList);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Menu = this.mainMenu1;
      this.Name = "MainForm";
      this.Text = "Clipboard viewer";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
      Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

    private void button1_Click(object sender, System.EventArgs e)
    {
      RefreshClipboardView();
    }

    private void RefreshClipboardView()
    {
      formatsList.Items.Clear();
      IDataObject data = Clipboard.GetDataObject();
      formatsList.Items.AddRange(data.GetFormats());
      rendererPanel.Controls.Clear();
    }

    private Renderer GetRenderer(string dataFormat, object data)
    {
      switch (dataFormat)
      {
        case "Rich Text Format": 
          return new RichTextRenderer();

        case "OEMText" : 
        case "Text":
        case "UnicodeText":
        case "System.String":
        case "FileDrop":
        case "FileName":
        case "FileNameW":
        case "Csv":
          return new TextRenderer();
        
        case "HTML Format": 
          return new HtmlRenderer();
        
        case "Locale": 
          return new MemoryStreamRenderer();
        
        case "System.Drawing.Bitmap":
        case "Bitmap": 
        case "DeviceIndependentBitmap":
        case "Format17":
          return new BitmapRenderer();
      }

      if (data is MemoryStream)
        return new MemoryStreamRenderer();

      return null;
    }

    Renderer currentRenderer;
    private void formatsList_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      IDataObject dataObject = Clipboard.GetDataObject();
      if (dataObject != null)
      {
        string dataFormat = formatsList.Items[formatsList.SelectedIndex].ToString();
        object data = dataObject.GetData(dataFormat);
        
        if (data != null)
        {
          Type dataType = data.GetType();
          dataLabel.Text = "Data: " + dataType.ToString();
        }
        else
          dataLabel.Text = "Data: null";

        Cursor.Current = Cursors.WaitCursor;
        try
        {
          rendererPanel.Controls.Clear();
          currentRenderer = GetRenderer(dataFormat, data);
          if (currentRenderer == null)
          {
            Label noRenderPanel = new Label();
            rendererPanel.Controls.Add(noRenderPanel);
            noRenderPanel.Dock = DockStyle.Fill;
            noRenderPanel.TextAlign = ContentAlignment.MiddleCenter;
            noRenderPanel.Text = "No renderer available";
          }
          else
          {
            rendererPanel.Controls.Add(currentRenderer);
            currentRenderer.Dock = DockStyle.Fill;
            if (data != null)
              currentRenderer.LoadData(data, dataFormat);
          }
        }
        finally
        {
          Cursor.Current = Cursors.Default;
        }
      }
    }

    private void button2_Click(object sender, System.EventArgs e)
    {
      Clipboard.SetDataObject(new DataObject());
      RefreshClipboardView();
    }

    private void Form1_Load(object sender, System.EventArgs e)
    {
      RefreshClipboardView();
    }

    private void menuItem2_Click(object sender, System.EventArgs e)
    {
      Application.Exit();
    }

    private void clipboardMonitor_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
    {
      RefreshClipboardView();
    }

    private void saveMenuItem_Click(object sender, EventArgs e)
    {
      using (SaveFileDialog saveDialog = new SaveFileDialog())
      {
        if (saveDialog.ShowDialog() == DialogResult.OK)
        {
          currentRenderer.Save(saveDialog.FileName);
        }
      }
    }
	}
}
