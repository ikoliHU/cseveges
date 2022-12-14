namespace CsevegesGUI {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.callerBox = new System.Windows.Forms.ComboBox();
            this.calledBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kezdeményező";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fogadó (partner)";
            // 
            // callerBox
            // 
            this.callerBox.FormattingEnabled = true;
            this.callerBox.Location = new System.Drawing.Point(139, 41);
            this.callerBox.Name = "callerBox";
            this.callerBox.Size = new System.Drawing.Size(166, 23);
            this.callerBox.TabIndex = 2;
            this.callerBox.SelectedIndexChanged += new System.EventHandler(this.callerBox_SelectedIndexChanged);
            // 
            // calledBox
            // 
            this.calledBox.FormattingEnabled = true;
            this.calledBox.Location = new System.Drawing.Point(139, 86);
            this.calledBox.Name = "calledBox";
            this.calledBox.Size = new System.Drawing.Size(166, 23);
            this.calledBox.TabIndex = 3;
            this.calledBox.SelectedIndexChanged += new System.EventHandler(this.calledBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Csevegések";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(37, 173);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(268, 184);
            this.list.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 372);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calledBox);
            this.Controls.Add(this.callerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Csevegés GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox callerBox;
        private ComboBox calledBox;
        private Label label3;
        private ListBox list;
    }
}