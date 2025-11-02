namespace WinFormsControl
{
    partial class TextBoxWithButton
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(TextBoxWithButton));

            lblCaption = new Label();
            txtEdit = new TextBox();
            btnRefer = new Button();
            this.SuspendLayout();

            //
            // lblCaption
            //
            resources.ApplyResources(lblCaption, "lblCaption");
            lblCaption.Name = "lblCaption";
            //
            // txtEdit
            //
            resources.ApplyResources(txtEdit, "txtEdit");
            txtEdit.Name = "txtEdit";
            //
            // btnRefer
            //
            resources.ApplyResources(btnRefer, "btnRefer");
            btnRefer.Name = "btnRefer";
            btnRefer.UseVisualStyleBackColor = true;
            btnRefer.Click += btnRefer_Click;

            //
            // TextBoxWithButton
            //
            AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(btnRefer);
            this.Controls.Add(txtEdit);
            this.Controls.Add(lblCaption);
            resources.ApplyResources(this, "$this");
            this.Name = "TextBoxWithButton";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblCaption;
        private TextBox txtEdit;
        private Button btnRefer;
    }
}
