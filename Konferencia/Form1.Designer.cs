namespace Konferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_jobbra = new System.Windows.Forms.Button();
            this.button_Balra = new System.Windows.Forms.Button();
            this.pictureBox_iro = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_Ertekelesek = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iro)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Mentes
            // 
            this.button_Mentes.BackColor = System.Drawing.Color.Transparent;
            this.button_Mentes.BackgroundImage = global::Konferencia.Properties.Resources.ment;
            this.button_Mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Mentes.FlatAppearance.BorderSize = 0;
            this.button_Mentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Mentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Mentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mentes.Location = new System.Drawing.Point(163, 345);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(73, 64);
            this.button_Mentes.TabIndex = 1;
            this.button_Mentes.UseVisualStyleBackColor = false;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // button_jobbra
            // 
            this.button_jobbra.BackColor = System.Drawing.Color.Transparent;
            this.button_jobbra.BackgroundImage = global::Konferencia.Properties.Resources.jobb;
            this.button_jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_jobbra.FlatAppearance.BorderSize = 0;
            this.button_jobbra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_jobbra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_jobbra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_jobbra.Location = new System.Drawing.Point(344, 172);
            this.button_jobbra.Name = "button_jobbra";
            this.button_jobbra.Size = new System.Drawing.Size(73, 64);
            this.button_jobbra.TabIndex = 1;
            this.button_jobbra.UseVisualStyleBackColor = false;
            this.button_jobbra.Click += new System.EventHandler(this.button_jobbra_Click);
            // 
            // button_Balra
            // 
            this.button_Balra.BackColor = System.Drawing.Color.Transparent;
            this.button_Balra.BackgroundImage = global::Konferencia.Properties.Resources.bal;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Balra.FlatAppearance.BorderSize = 0;
            this.button_Balra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Balra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Balra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Balra.Location = new System.Drawing.Point(13, 172);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(73, 64);
            this.button_Balra.TabIndex = 1;
            this.button_Balra.UseVisualStyleBackColor = false;
            this.button_Balra.Click += new System.EventHandler(this.button_Balra_Click);
            // 
            // pictureBox_iro
            // 
            this.pictureBox_iro.Location = new System.Drawing.Point(108, 33);
            this.pictureBox_iro.Name = "pictureBox_iro";
            this.pictureBox_iro.Size = new System.Drawing.Size(205, 306);
            this.pictureBox_iro.TabIndex = 0;
            this.pictureBox_iro.TabStop = false;
            // 
            // tableLayoutPanel_Ertekelesek
            // 
            this.tableLayoutPanel_Ertekelesek.AutoSize = true;
            this.tableLayoutPanel_Ertekelesek.ColumnCount = 2;
            this.tableLayoutPanel_Ertekelesek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ertekelesek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ertekelesek.Location = new System.Drawing.Point(532, 90);
            this.tableLayoutPanel_Ertekelesek.Name = "tableLayoutPanel_Ertekelesek";
            this.tableLayoutPanel_Ertekelesek.RowCount = 2;
            this.tableLayoutPanel_Ertekelesek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ertekelesek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Ertekelesek.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel_Ertekelesek.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 444);
            this.Controls.Add(this.tableLayoutPanel_Ertekelesek);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_jobbra);
            this.Controls.Add(this.button_Balra);
            this.Controls.Add(this.pictureBox_iro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_iro;
        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.Button button_jobbra;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Ertekelesek;
    }
}

