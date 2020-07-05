namespace proj_reader.Views
{
    partial class frmSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.panelListKind = new System.Windows.Forms.Panel();
            this.dataKinds = new System.Windows.Forms.DataGridView();
            this.panelListKind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKinds)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKind
            // 
            this.txtKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txtKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKind.ForeColor = System.Drawing.Color.White;
            this.txtKind.Location = new System.Drawing.Point(41, 53);
            this.txtKind.Multiline = true;
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(387, 31);
            this.txtKind.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCreate.IconColor = System.Drawing.Color.Black;
            this.btnCreate.IconSize = 16;
            this.btnCreate.Location = new System.Drawing.Point(41, 104);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Rotation = 0D;
            this.btnCreate.Size = new System.Drawing.Size(107, 37);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDel.IconColor = System.Drawing.Color.Black;
            this.btnDel.IconSize = 16;
            this.btnDel.Location = new System.Drawing.Point(192, 104);
            this.btnDel.Name = "btnDel";
            this.btnDel.Rotation = 0D;
            this.btnDel.Size = new System.Drawing.Size(107, 37);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panelListKind
            // 
            this.panelListKind.Controls.Add(this.dataKinds);
            this.panelListKind.Location = new System.Drawing.Point(41, 165);
            this.panelListKind.Name = "panelListKind";
            this.panelListKind.Size = new System.Drawing.Size(704, 262);
            this.panelListKind.TabIndex = 10;
            // 
            // dataKinds
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataKinds.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataKinds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKinds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataKinds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKinds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataKinds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKinds.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKinds.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataKinds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKinds.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataKinds.Location = new System.Drawing.Point(0, 0);
            this.dataKinds.Margin = new System.Windows.Forms.Padding(2);
            this.dataKinds.Name = "dataKinds";
            this.dataKinds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataKinds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKinds.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataKinds.RowHeadersVisible = false;
            this.dataKinds.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataKinds.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataKinds.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataKinds.RowTemplate.Height = 24;
            this.dataKinds.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataKinds.Size = new System.Drawing.Size(704, 262);
            this.dataKinds.TabIndex = 2;
            this.dataKinds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKinds_CellClick);
            this.dataKinds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKinds_CellContentClick);
            this.dataKinds.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKinds_CellEndEdit);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelListKind);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtKind);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panelListKind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKinds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKind;
        private FontAwesome.Sharp.IconButton btnCreate;
        private FontAwesome.Sharp.IconButton btnDel;
        private System.Windows.Forms.Panel panelListKind;
        private System.Windows.Forms.DataGridView dataKinds;
    }
}