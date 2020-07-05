namespace proj_reader.Views
{
    partial class frmHome
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
            this.panelReadDocument = new System.Windows.Forms.Panel();
            this.lbChooseKind = new System.Windows.Forms.ListBox();
            this.lbKind = new System.Windows.Forms.ListBox();
            this.listBoxKind = new System.Windows.Forms.ListBox();
            this.listBoxNearOpen = new System.Windows.Forms.ListBox();
            this.btnOpen = new FontAwesome.Sharp.IconButton();
            this.btnNote = new FontAwesome.Sharp.IconButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.panelReadDocument.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReadDocument
            // 
            this.panelReadDocument.Controls.Add(this.lbChooseKind);
            this.panelReadDocument.Controls.Add(this.lbKind);
            this.panelReadDocument.Controls.Add(this.listBoxKind);
            this.panelReadDocument.Controls.Add(this.listBoxNearOpen);
            this.panelReadDocument.Controls.Add(this.btnOpen);
            this.panelReadDocument.Controls.Add(this.btnNote);
            this.panelReadDocument.Controls.Add(this.txtNote);
            this.panelReadDocument.Controls.Add(this.btnSave);
            this.panelReadDocument.Controls.Add(this.txtText);
            this.panelReadDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReadDocument.Location = new System.Drawing.Point(0, 0);
            this.panelReadDocument.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.panelReadDocument.Name = "panelReadDocument";
            this.panelReadDocument.Size = new System.Drawing.Size(800, 450);
            this.panelReadDocument.TabIndex = 0;
            // 
            // lbChooseKind
            // 
            this.lbChooseKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChooseKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lbChooseKind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbChooseKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseKind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbChooseKind.FormattingEnabled = true;
            this.lbChooseKind.ItemHeight = 15;
            this.lbChooseKind.Location = new System.Drawing.Point(625, 295);
            this.lbChooseKind.Name = "lbChooseKind";
            this.lbChooseKind.Size = new System.Drawing.Size(153, 90);
            this.lbChooseKind.TabIndex = 13;
            this.lbChooseKind.DoubleClick += new System.EventHandler(this.lbChooseKind_DoubleClick);
            // 
            // lbKind
            // 
            this.lbKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.lbKind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKind.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbKind.FormattingEnabled = true;
            this.lbKind.ItemHeight = 15;
            this.lbKind.Location = new System.Drawing.Point(625, 194);
            this.lbKind.Name = "lbKind";
            this.lbKind.Size = new System.Drawing.Size(153, 90);
            this.lbKind.TabIndex = 12;
            this.lbKind.DoubleClick += new System.EventHandler(this.lbKind_DoubleClick);
            // 
            // listBoxKind
            // 
            this.listBoxKind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listBoxKind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxKind.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.listBoxKind.FormattingEnabled = true;
            this.listBoxKind.ItemHeight = 16;
            this.listBoxKind.Location = new System.Drawing.Point(12, 265);
            this.listBoxKind.Name = "listBoxKind";
            this.listBoxKind.Size = new System.Drawing.Size(249, 112);
            this.listBoxKind.TabIndex = 10;
            this.listBoxKind.DoubleClick += new System.EventHandler(this.listBoxKind_DoubleClick);
            // 
            // listBoxNearOpen
            // 
            this.listBoxNearOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxNearOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listBoxNearOpen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNearOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNearOpen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxNearOpen.FormattingEnabled = true;
            this.listBoxNearOpen.ItemHeight = 16;
            this.listBoxNearOpen.Location = new System.Drawing.Point(12, 48);
            this.listBoxNearOpen.Name = "listBoxNearOpen";
            this.listBoxNearOpen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxNearOpen.Size = new System.Drawing.Size(249, 176);
            this.listBoxNearOpen.TabIndex = 9;
            this.listBoxNearOpen.Click += new System.EventHandler(this.listBoxNearOpen_Click);
            this.listBoxNearOpen.Leave += new System.EventHandler(this.listBoxNearOpen_Leave);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnOpen.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnOpen.IconColor = System.Drawing.Color.LavenderBlush;
            this.btnOpen.IconSize = 24;
            this.btnOpen.Location = new System.Drawing.Point(12, 398);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnOpen.Rotation = 0D;
            this.btnOpen.Size = new System.Drawing.Size(157, 40);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open File";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // btnNote
            // 
            this.btnNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnNote.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnNote.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.btnNote.IconSize = 36;
            this.btnNote.Location = new System.Drawing.Point(615, 48);
            this.btnNote.Name = "btnNote";
            this.btnNote.Rotation = 0D;
            this.btnNote.Size = new System.Drawing.Size(153, 54);
            this.btnNote.TabIndex = 7;
            this.btnNote.Text = "Note Everything";
            this.btnNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNote.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNote.Location = new System.Drawing.Point(625, 100);
            this.txtNote.Margin = new System.Windows.Forms.Padding(10);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(153, 91);
            this.txtNote.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(625, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.txtText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtText.Location = new System.Drawing.Point(267, 48);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(342, 390);
            this.txtText.TabIndex = 2;
            this.txtText.Visible = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReadDocument);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.panelReadDocument.ResumeLayout(false);
            this.panelReadDocument.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReadDocument;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNote;
        private FontAwesome.Sharp.IconButton btnNote;
        private FontAwesome.Sharp.IconButton btnOpen;
        private System.Windows.Forms.ListBox listBoxNearOpen;
        private System.Windows.Forms.ListBox listBoxKind;
        private System.Windows.Forms.ListBox lbChooseKind;
        private System.Windows.Forms.ListBox lbKind;
    }
}