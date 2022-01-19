
namespace Projekt.View
{
    partial class MenuLibrarianForm
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
            // MenuLibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(587, 463);
            this.Name = "MenuLibrarianForm";
            this.Load += new System.EventHandler(this.MenuLibrarianForm_Load);
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
