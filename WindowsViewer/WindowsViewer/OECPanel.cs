using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsViewer
{
    public class OECPanel : UserControl
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OECPanel";
            this.Size = new System.Drawing.Size(150, 162);
            this.ResumeLayout(false);

        }
        public OECPanel()
        {
            this.InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.backgroundInvaliated)
            {
                base.OnPaintBackground(e);
                this.backgroundInvaliated = false;
            }
        }
#pragma warning disable CS0649
        private IContainer components;
#pragma warning restore CS0649
        private bool backgroundInvaliated = true;
    }
}
