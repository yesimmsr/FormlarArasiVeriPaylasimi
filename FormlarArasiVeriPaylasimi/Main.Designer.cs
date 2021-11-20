
namespace FormlarArasiVeriPaylasimi
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnYeniMusteri);
            this.panel1.Controls.Add(this.btnUrun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMusteri.Location = new System.Drawing.Point(0, 30);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(142, 30);
            this.btnYeniMusteri.TabIndex = 1;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            // 
            // btnUrun
            // 
            this.btnUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrun.Location = new System.Drawing.Point(0, 0);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(142, 30);
            this.btnUrun.TabIndex = 1;
            this.btnUrun.Text = "Yeni Ürün";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(146, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstUrunler);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteriler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstUrunler
            // 
            this.lstUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 20;
            this.lstUrunler.Location = new System.Drawing.Point(3, 3);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(331, 387);
            this.lstUrunler.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 426);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstUrunler;
    }
}

