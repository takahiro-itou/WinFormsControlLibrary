
using System.ComponentModel;

namespace  WinFormsControl  {

public partial class RectSelectForm : UserControl
{
    public System.Drawing.Rectangle lastRect;

    public RectSelectForm()
    {
        InitializeComponent();
    }

    private void RectSelectForm_Move(object sender, System.EventArgs e)
    {
        Control c = (Control)sender;
        this.lastRect.X      = c.Left;
        this.lastRect.Y      = c.Top;
        this.lastRect.Width  = c.Width;
        this.lastRect.Height = c.Height;
        btnOK.Text = $"{c.Width} x {c.Height} @ pos = {c.Left}, {c.Top}"
    }

    private void RectSelectForm_Resize(object sender, System.EventArgs e)
    {
        Control c = (Control)sender;
        this.lastRect.X      = c.Left;
        this.lastRect.Y      = c.Top;
        this.lastRect.Width  = c.Width;
        this.lastRect.Height = c.Height;
        btnOK.Text = $"{c.Width} x {c.Height} @ pos = {c.Left}, {c.Top}"
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.Close();
    }

    private void btnOK_Click(object sender, System.EventArgs e)
    {
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.Close();
    }

}   //  End of partial class  RectSelectForm

}   //  End of namespace  WinFormsControl
