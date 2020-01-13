namespace Assignment
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tblMidPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableCover = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMultilineCode = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRun = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlSingleLine = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSingleLineCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnlDrawField = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tblMidPanel.SuspendLayout();
            this.pnlTableCover.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlSingleLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.panel4);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(817, 28);
            this.topPanel.TabIndex = 999;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 21);
            this.lblTitle.TabIndex = 999;
            this.lblTitle.Text = "Graphical Code Editor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.btnMaximize);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(721, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 28);
            this.panel4.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Assignment.Properties.Resources.Minus_50px;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(12, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 24);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.AutoSize = true;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImage = global::Assignment.Properties.Resources.Minimize_Window_50px;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(37, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(21, 22);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Assignment.Properties.Resources.Close_50px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(67, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 22);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(370, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 25);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.lblCopyright);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 26);
            this.panel2.TabIndex = 2;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.ForeColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Location = new System.Drawing.Point(0, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(817, 26);
            this.lblCopyright.TabIndex = 999;
            this.lblCopyright.Text = "Copyright 2019  |  Allright reserved";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tblMidPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 546);
            this.panel3.TabIndex = 3;
            // 
            // tblMidPanel
            // 
            this.tblMidPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tblMidPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMidPanel.ColumnCount = 2;
            this.tblMidPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMidPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMidPanel.Controls.Add(this.pnlTableCover, 0, 0);
            this.tblMidPanel.Controls.Add(this.pnlDrawField, 1, 0);
            this.tblMidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMidPanel.Location = new System.Drawing.Point(0, 0);
            this.tblMidPanel.Name = "tblMidPanel";
            this.tblMidPanel.RowCount = 1;
            this.tblMidPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMidPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMidPanel.Size = new System.Drawing.Size(817, 546);
            this.tblMidPanel.TabIndex = 0;
            // 
            // pnlTableCover
            // 
            this.pnlTableCover.Controls.Add(this.bunifuCustomLabel2);
            this.pnlTableCover.Controls.Add(this.txtMultilineCode);
            this.pnlTableCover.Controls.Add(this.panel5);
            this.pnlTableCover.Controls.Add(this.pnlSingleLine);
            this.pnlTableCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableCover.Location = new System.Drawing.Point(4, 4);
            this.pnlTableCover.Name = "pnlTableCover";
            this.pnlTableCover.Size = new System.Drawing.Size(401, 538);
            this.pnlTableCover.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 100);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(156, 21);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Multiline Code Editor";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMultilineCode
            // 
            this.txtMultilineCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMultilineCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMultilineCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtMultilineCode.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMultilineCode.BorderColor = System.Drawing.Color.White;
            this.txtMultilineCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMultilineCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultilineCode.ForeColor = System.Drawing.Color.White;
            this.txtMultilineCode.Location = new System.Drawing.Point(8, 131);
            this.txtMultilineCode.Multiline = true;
            this.txtMultilineCode.Name = "txtMultilineCode";
            this.txtMultilineCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMultilineCode.Size = new System.Drawing.Size(382, 328);
            this.txtMultilineCode.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRun);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 477);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 61);
            this.panel5.TabIndex = 999;
            // 
            // btnRun
            // 
            this.btnRun.ActiveBorderThickness = 1;
            this.btnRun.ActiveCornerRadius = 1;
            this.btnRun.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRun.ActiveForecolor = System.Drawing.Color.White;
            this.btnRun.ActiveLineColor = System.Drawing.Color.White;
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRun.BackgroundImage")));
            this.btnRun.ButtonText = "Run";
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.IdleBorderThickness = 1;
            this.btnRun.IdleCornerRadius = 1;
            this.btnRun.IdleFillColor = System.Drawing.Color.White;
            this.btnRun.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRun.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRun.Location = new System.Drawing.Point(125, 5);
            this.btnRun.Margin = new System.Windows.Forms.Padding(5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(134, 52);
            this.btnRun.TabIndex = 3;
            this.btnRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pnlSingleLine
            // 
            this.pnlSingleLine.Controls.Add(this.bunifuCustomLabel1);
            this.pnlSingleLine.Controls.Add(this.txtSingleLineCode);
            this.pnlSingleLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSingleLine.Location = new System.Drawing.Point(0, 0);
            this.pnlSingleLine.Name = "pnlSingleLine";
            this.pnlSingleLine.Size = new System.Drawing.Size(401, 91);
            this.pnlSingleLine.TabIndex = 999;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(5, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(171, 21);
            this.bunifuCustomLabel1.TabIndex = 999;
            this.bunifuCustomLabel1.Text = "Single Line Code Editor";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSingleLineCode
            // 
            this.txtSingleLineCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSingleLineCode.AutoSize = true;
            this.txtSingleLineCode.BorderColorFocused = System.Drawing.Color.White;
            this.txtSingleLineCode.BorderColorIdle = System.Drawing.Color.White;
            this.txtSingleLineCode.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtSingleLineCode.BorderThickness = 1;
            this.txtSingleLineCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSingleLineCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSingleLineCode.ForeColor = System.Drawing.Color.White;
            this.txtSingleLineCode.isPassword = false;
            this.txtSingleLineCode.Location = new System.Drawing.Point(8, 46);
            this.txtSingleLineCode.Margin = new System.Windows.Forms.Padding(10);
            this.txtSingleLineCode.Name = "txtSingleLineCode";
            this.txtSingleLineCode.Size = new System.Drawing.Size(385, 26);
            this.txtSingleLineCode.TabIndex = 2;
            this.txtSingleLineCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlDrawField
            // 
            this.pnlDrawField.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDrawField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrawField.Location = new System.Drawing.Point(412, 4);
            this.pnlDrawField.Name = "pnlDrawField";
            this.pnlDrawField.Size = new System.Drawing.Size(401, 538);
            this.pnlDrawField.TabIndex = 999;
            this.pnlDrawField.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawField_Paint);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(817, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tblMidPanel.ResumeLayout(false);
            this.pnlTableCover.ResumeLayout(false);
            this.pnlTableCover.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnlSingleLine.ResumeLayout(false);
            this.pnlSingleLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tblMidPanel;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlTableCover;
        private System.Windows.Forms.Panel pnlSingleLine;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSingleLineCode;
        private System.Windows.Forms.Panel panel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMultilineCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRun;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Panel pnlDrawField;
    }
}

