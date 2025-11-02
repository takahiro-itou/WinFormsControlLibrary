namespace WinFormsControl
{
    partial class RectSelectForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(RectSelectForm));

            btnOK = new Button();
            btnCancel = new Button();
            this.SuspendLayout();

            //
            // btnOK
            //
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.Name = "btnOK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            //
            // btnCancel
            //
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            //
            // RectSelectForm
            //
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(btnCancel);
            this.Controls.Add(btnOK);
            this.Name = "RectSelectForm";
            this.Move += RectSelectForm_Move;
            this.Resize += RectSelectForm_Resize;

            this.ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
    }
}
