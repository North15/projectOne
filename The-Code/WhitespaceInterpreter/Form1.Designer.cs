namespace WhitespaceInterpreter
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.filePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 33);
            this.filePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(444, 22);
            this.filePath.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(461, 32);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(43, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // mainText
            // 
            this.mainText.AcceptsTab = true;
            this.mainText.Location = new System.Drawing.Point(12, 71);
            this.mainText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(332, 438);
            this.mainText.TabIndex = 2;
            this.mainText.Text = "";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(363, 71);
            this.convertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(128, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(363, 150);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(128, 23);
            this.clearAllButton.TabIndex = 4;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(363, 111);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filename:";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(363, 457);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(128, 23);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(363, 486);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 528);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Whitespace Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}

