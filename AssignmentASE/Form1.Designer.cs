namespace AssignmentASE
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.textBoxMultiLine = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxSingleLine = new System.Windows.Forms.TextBox();
            this.buttonMultiLine = new System.Windows.Forms.Button();
            this.buttonSingleLine = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMultiLine
            // 
            this.textBoxMultiLine.Location = new System.Drawing.Point(-3, 0);
            this.textBoxMultiLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMultiLine.Multiline = true;
            this.textBoxMultiLine.Name = "textBoxMultiLine";
            this.textBoxMultiLine.Size = new System.Drawing.Size(300, 392);
            this.textBoxMultiLine.TabIndex = 0;
            this.textBoxMultiLine.TextChanged += new System.EventHandler(this.textBoxMultiLine_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxSingleLine
            // 
            this.textBoxSingleLine.Location = new System.Drawing.Point(325, 401);
            this.textBoxSingleLine.Name = "textBoxSingleLine";
            this.textBoxSingleLine.Size = new System.Drawing.Size(358, 30);
            this.textBoxSingleLine.TabIndex = 2;
            this.textBoxSingleLine.TextChanged += new System.EventHandler(this.textBoxSingleLine_TextChanged);
            // 
            // buttonMultiLine
            // 
            this.buttonMultiLine.Location = new System.Drawing.Point(-3, 374);
            this.buttonMultiLine.Name = "buttonMultiLine";
            this.buttonMultiLine.Size = new System.Drawing.Size(300, 129);
            this.buttonMultiLine.TabIndex = 3;
            this.buttonMultiLine.Text = "Draw!";
            this.buttonMultiLine.UseVisualStyleBackColor = true;
            this.buttonMultiLine.Click += new System.EventHandler(this.buttonMultiLine_Click);
            // 
            // buttonSingleLine
            // 
            this.buttonSingleLine.Location = new System.Drawing.Point(689, 401);
            this.buttonSingleLine.Name = "buttonSingleLine";
            this.buttonSingleLine.Size = new System.Drawing.Size(124, 30);
            this.buttonSingleLine.TabIndex = 4;
            this.buttonSingleLine.Text = "Draw!";
            this.buttonSingleLine.UseVisualStyleBackColor = true;
            this.buttonSingleLine.Click += new System.EventHandler(this.buttonSingleLine_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxMain.Location = new System.Drawing.Point(323, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(505, 377);
            this.pictureBoxMain.TabIndex = 5;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonSingleLine);
            this.Controls.Add(this.buttonMultiLine);
            this.Controls.Add(this.textBoxSingleLine);
            this.Controls.Add(this.textBoxMultiLine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMultiLine;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxSingleLine;
        private System.Windows.Forms.Button buttonMultiLine;
        private System.Windows.Forms.Button buttonSingleLine;
        private System.Windows.Forms.PictureBox pictureBoxMain;
    }
}

