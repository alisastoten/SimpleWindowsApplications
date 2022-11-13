
namespace HW_11_Ex_1
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
            this.label_textboxText = new System.Windows.Forms.Label();
            this.textBox_userInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_textboxText
            // 
            this.label_textboxText.AutoSize = true;
            this.label_textboxText.Location = new System.Drawing.Point(44, 80);
            this.label_textboxText.Name = "label_textboxText";
            this.label_textboxText.Size = new System.Drawing.Size(203, 17);
            this.label_textboxText.TabIndex = 0;
            this.label_textboxText.Text = "Your text will be dipslayed here";
            // 
            // textBox_userInput
            // 
            this.textBox_userInput.Location = new System.Drawing.Point(47, 121);
            this.textBox_userInput.Name = "textBox_userInput";
            this.textBox_userInput.Size = new System.Drawing.Size(202, 22);
            this.textBox_userInput.TabIndex = 1;
            this.textBox_userInput.Text = "Enter something here";
            this.textBox_userInput.TextChanged += new System.EventHandler(this.textBox_userInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 201);
            this.Controls.Add(this.textBox_userInput);
            this.Controls.Add(this.label_textboxText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_textboxText;
        private System.Windows.Forms.TextBox textBox_userInput;
    }
}

