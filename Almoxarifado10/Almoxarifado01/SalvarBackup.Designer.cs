namespace Almoxarifado01
{
    partial class frmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button btnSalvarBackup;
        private System.Windows.Forms.Button btnRestaurarBackup;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.Label lblCodigoBackup;
        private System.Windows.Forms.Label lblDataBackup;
    }
}