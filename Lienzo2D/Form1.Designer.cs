﻿namespace Lienzo2D
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verArbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcprincipal = new System.Windows.Forms.TabControl();
            this.tpentrada = new System.Windows.Forms.TabPage();
            this.CuadroEntrada = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tpsalida = new System.Windows.Forms.TabPage();
            this.txtsalida = new System.Windows.Forms.RichTextBox();
            this.tperrores = new System.Windows.Forms.TabPage();
            this.txterrores = new System.Windows.Forms.RichTextBox();
            this.tablaDeSimbolosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tcprincipal.SuspendLayout();
            this.tpentrada.SuspendLayout();
            this.tpsalida.SuspendLayout();
            this.tperrores.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como...";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem,
            this.verArbolToolStripMenuItem,
            this.trToolStripMenuItem,
            this.tablaDeSimbolosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutarToolStripMenuItem_Click);
            // 
            // verArbolToolStripMenuItem
            // 
            this.verArbolToolStripMenuItem.Name = "verArbolToolStripMenuItem";
            this.verArbolToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verArbolToolStripMenuItem.Text = "Ver Arbol";
            this.verArbolToolStripMenuItem.Click += new System.EventHandler(this.verArbolToolStripMenuItem_Click);
            // 
            // trToolStripMenuItem
            // 
            this.trToolStripMenuItem.Name = "trToolStripMenuItem";
            this.trToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.trToolStripMenuItem.Text = "tr";
            this.trToolStripMenuItem.Click += new System.EventHandler(this.trToolStripMenuItem_Click);
            // 
            // tcprincipal
            // 
            this.tcprincipal.Controls.Add(this.tpentrada);
            this.tcprincipal.Controls.Add(this.tpsalida);
            this.tcprincipal.Controls.Add(this.tperrores);
            this.tcprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcprincipal.Location = new System.Drawing.Point(0, 24);
            this.tcprincipal.Name = "tcprincipal";
            this.tcprincipal.SelectedIndex = 0;
            this.tcprincipal.Size = new System.Drawing.Size(672, 612);
            this.tcprincipal.TabIndex = 4;
            // 
            // tpentrada
            // 
            this.tpentrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpentrada.Controls.Add(this.CuadroEntrada);
            this.tpentrada.Location = new System.Drawing.Point(4, 22);
            this.tpentrada.Name = "tpentrada";
            this.tpentrada.Padding = new System.Windows.Forms.Padding(3);
            this.tpentrada.Size = new System.Drawing.Size(664, 586);
            this.tpentrada.TabIndex = 2;
            this.tpentrada.Text = "Entrada";
            // 
            // CuadroEntrada
            // 
            this.CuadroEntrada.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.CuadroEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CuadroEntrada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CuadroEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuadroEntrada.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CuadroEntrada.LineNumberStartValue = ((uint)(0u));
            this.CuadroEntrada.Location = new System.Drawing.Point(3, 3);
            this.CuadroEntrada.Name = "CuadroEntrada";
            this.CuadroEntrada.Size = new System.Drawing.Size(658, 580);
            this.CuadroEntrada.TabIndex = 0;
            // 
            // tpsalida
            // 
            this.tpsalida.Controls.Add(this.txtsalida);
            this.tpsalida.Location = new System.Drawing.Point(4, 22);
            this.tpsalida.Name = "tpsalida";
            this.tpsalida.Padding = new System.Windows.Forms.Padding(3);
            this.tpsalida.Size = new System.Drawing.Size(664, 586);
            this.tpsalida.TabIndex = 0;
            this.tpsalida.Text = "Salida";
            this.tpsalida.UseVisualStyleBackColor = true;
            // 
            // txtsalida
            // 
            this.txtsalida.BackColor = System.Drawing.Color.Black;
            this.txtsalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsalida.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalida.ForeColor = System.Drawing.Color.Lime;
            this.txtsalida.Location = new System.Drawing.Point(3, 3);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(658, 580);
            this.txtsalida.TabIndex = 1;
            this.txtsalida.Text = "";
            // 
            // tperrores
            // 
            this.tperrores.Controls.Add(this.txterrores);
            this.tperrores.Location = new System.Drawing.Point(4, 22);
            this.tperrores.Name = "tperrores";
            this.tperrores.Padding = new System.Windows.Forms.Padding(3);
            this.tperrores.Size = new System.Drawing.Size(664, 586);
            this.tperrores.TabIndex = 1;
            this.tperrores.Text = "Errores";
            this.tperrores.UseVisualStyleBackColor = true;
            // 
            // txterrores
            // 
            this.txterrores.BackColor = System.Drawing.Color.Black;
            this.txterrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txterrores.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterrores.ForeColor = System.Drawing.Color.Red;
            this.txterrores.Location = new System.Drawing.Point(3, 3);
            this.txterrores.Name = "txterrores";
            this.txterrores.Size = new System.Drawing.Size(658, 580);
            this.txterrores.TabIndex = 2;
            this.txterrores.Text = "";
            // 
            // tablaDeSimbolosToolStripMenuItem
            // 
            this.tablaDeSimbolosToolStripMenuItem.Name = "tablaDeSimbolosToolStripMenuItem";
            this.tablaDeSimbolosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tablaDeSimbolosToolStripMenuItem.Text = "Tabla de símbolos ";
            this.tablaDeSimbolosToolStripMenuItem.Click += new System.EventHandler(this.tablaDeSimbolosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(672, 636);
            this.Controls.Add(this.tcprincipal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lienzo2D";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcprincipal.ResumeLayout(false);
            this.tpentrada.ResumeLayout(false);
            this.tpsalida.ResumeLayout(false);
            this.tperrores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verArbolToolStripMenuItem;
        private System.Windows.Forms.TabControl tcprincipal;
        private System.Windows.Forms.TabPage tpentrada;
        private FastColoredTextBoxNS.FastColoredTextBox CuadroEntrada;
        private System.Windows.Forms.TabPage tpsalida;
        private System.Windows.Forms.RichTextBox txtsalida;
        private System.Windows.Forms.TabPage tperrores;
        private System.Windows.Forms.RichTextBox txterrores;
        private System.Windows.Forms.ToolStripMenuItem trToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeSimbolosToolStripMenuItem;
    }
}

