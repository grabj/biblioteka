
namespace Projekt
{
    partial class MenuGuestView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1.SuspendLayout();
            this.tabLibrarians.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabLoans.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            // 
            // button3
            // 
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Visible = false;
            // 
            // button14
            // 
            this.button14.Visible = false;
            // 
            // MenuGuestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(587, 463);
            this.Name = "MenuGuestView";
            this.Load += new System.EventHandler(this.MenuGuestView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLibrarians.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabLoans.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion
    }
}
