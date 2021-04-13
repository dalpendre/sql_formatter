
namespace sql_formatter
{
    partial class Form1
    {
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
            this.textBoxFields = new System.Windows.Forms.TextBox();
            this.buttonCreateSQLCommand = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonDeleteTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFields
            // 
            this.textBoxFields.Location = new System.Drawing.Point(13, 13);
            this.textBoxFields.Multiline = true;
            this.textBoxFields.Name = "textBoxFields";
            this.textBoxFields.Size = new System.Drawing.Size(369, 426);
            this.textBoxFields.TabIndex = 0;
            // 
            // buttonCreateSQLCommand
            // 
            this.buttonCreateSQLCommand.Location = new System.Drawing.Point(12, 451);
            this.buttonCreateSQLCommand.Name = "buttonCreateSQLCommand";
            this.buttonCreateSQLCommand.Size = new System.Drawing.Size(168, 23);
            this.buttonCreateSQLCommand.TabIndex = 1;
            this.buttonCreateSQLCommand.Text = "Create SQL Command String";
            this.buttonCreateSQLCommand.UseVisualStyleBackColor = true;
            this.buttonCreateSQLCommand.Click += new System.EventHandler(this.buttonCreateSQLCommand_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(186, 451);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(196, 23);
            this.buttonReadFile.TabIndex = 2;
            this.buttonReadFile.Text = "Read from file";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonDeleteTextBox
            // 
            this.buttonDeleteTextBox.Location = new System.Drawing.Point(12, 480);
            this.buttonDeleteTextBox.Name = "buttonDeleteTextBox";
            this.buttonDeleteTextBox.Size = new System.Drawing.Size(369, 23);
            this.buttonDeleteTextBox.TabIndex = 3;
            this.buttonDeleteTextBox.Text = "Delete Text Box";
            this.buttonDeleteTextBox.UseVisualStyleBackColor = false;
            this.buttonDeleteTextBox.Click += new System.EventHandler(this.buttonDeleteTextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 515);
            this.Controls.Add(this.buttonDeleteTextBox);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonCreateSQLCommand);
            this.Controls.Add(this.textBoxFields);
            this.Name = "Form1";
            this.Text = "SQL Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFields;
        private System.Windows.Forms.Button buttonCreateSQLCommand;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonDeleteTextBox;
    }
}

