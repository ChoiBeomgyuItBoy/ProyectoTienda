﻿
namespace ProyectoTienda.Pantallas
{
    partial class PantallaCompra
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaCompra));
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.CompraTitulo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.CompraTitulo);
            this.PanelTitulo.Controls.Add(this.Titulo);
            resources.ApplyResources(this.PanelTitulo, "PanelTitulo");
            this.PanelTitulo.Name = "PanelTitulo";
            // 
            // CompraTitulo
            // 
            resources.ApplyResources(this.CompraTitulo, "CompraTitulo");
            this.CompraTitulo.Name = "CompraTitulo";
            // 
            // Titulo
            // 
            resources.ApplyResources(this.Titulo, "Titulo");
            this.Titulo.Name = "Titulo";
            // 
            // PantallaCompra
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaCompra";
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label CompraTitulo;
        private System.Windows.Forms.Label Titulo;
    }
}