namespace BarkodluSatis
{
    partial class fHizliUrunEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblButonNo = new System.Windows.Forms.Label();
            this.chBoxTumGoster = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunAra = new System.Windows.Forms.TextBox();
            this.GridUrunler = new System.Windows.Forms.DataGridView();
            this.lblButonId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblButonId);
            this.splitContainer1.Panel1.Controls.Add(this.lblButonNo);
            this.splitContainer1.Panel1.Controls.Add(this.chBoxTumGoster);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.TxtUrunAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblButonNo
            // 
            this.lblButonNo.AutoSize = true;
            this.lblButonNo.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblButonNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblButonNo.Location = new System.Drawing.Point(2, 9);
            this.lblButonNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButonNo.Name = "lblButonNo";
            this.lblButonNo.Size = new System.Drawing.Size(145, 21);
            this.lblButonNo.TabIndex = 6;
            this.lblButonNo.Text = "Buton Numarası:";
            // 
            // chBoxTumGoster
            // 
            this.chBoxTumGoster.AutoSize = true;
            this.chBoxTumGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chBoxTumGoster.ForeColor = System.Drawing.Color.DarkCyan;
            this.chBoxTumGoster.Location = new System.Drawing.Point(347, 73);
            this.chBoxTumGoster.Name = "chBoxTumGoster";
            this.chBoxTumGoster.Size = new System.Drawing.Size(139, 24);
            this.chBoxTumGoster.TabIndex = 5;
            this.chBoxTumGoster.Text = "Tümünü Göster";
            this.chBoxTumGoster.UseVisualStyleBackColor = true;
            this.chBoxTumGoster.CheckedChanged += new System.EventHandler(this.chBoxTumGoster_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(2, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ürün Ara:";
            // 
            // TxtUrunAra
            // 
            this.TxtUrunAra.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUrunAra.Location = new System.Drawing.Point(6, 68);
            this.TxtUrunAra.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUrunAra.Name = "TxtUrunAra";
            this.TxtUrunAra.Size = new System.Drawing.Size(336, 33);
            this.TxtUrunAra.TabIndex = 3;
            this.TxtUrunAra.TextChanged += new System.EventHandler(this.TxtUrunAra_TextChanged);
            // 
            // GridUrunler
            // 
            this.GridUrunler.AllowUserToAddRows = false;
            this.GridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUrunler.EnableHeadersVisualStyles = false;
            this.GridUrunler.Location = new System.Drawing.Point(0, 0);
            this.GridUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.GridUrunler.Name = "GridUrunler";
            this.GridUrunler.RowHeadersVisible = false;
            this.GridUrunler.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            this.GridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridUrunler.RowTemplate.Height = 32;
            this.GridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUrunler.Size = new System.Drawing.Size(800, 314);
            this.GridUrunler.TabIndex = 2;
            this.GridUrunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUrunler_CellContentDoubleClick);
            // 
            // lblButonId
            // 
            this.lblButonId.AutoSize = true;
            this.lblButonId.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblButonId.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblButonId.Location = new System.Drawing.Point(140, 9);
            this.lblButonId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButonId.Name = "lblButonId";
            this.lblButonId.Size = new System.Drawing.Size(30, 21);
            this.lblButonId.TabIndex = 7;
            this.lblButonId.Text = "25";
            // 
            // fHizliUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fHizliUrunEkle";
            this.Text = "Hızlı Ürün Ekleme";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GridUrunler;
        private System.Windows.Forms.CheckBox chBoxTumGoster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunAra;
        private System.Windows.Forms.Label lblButonNo;
        public System.Windows.Forms.Label lblButonId;
    }
}