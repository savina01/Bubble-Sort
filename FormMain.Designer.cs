
namespace BubbleSort
{
    partial class FormMain
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelArrayValues = new System.Windows.Forms.Label();
            this.textBoxValues = new System.Windows.Forms.TextBox();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(493, 145);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(94, 29);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelArrayValues
            // 
            this.labelArrayValues.AutoSize = true;
            this.labelArrayValues.Location = new System.Drawing.Point(9, 7);
            this.labelArrayValues.Name = "labelArrayValues";
            this.labelArrayValues.Size = new System.Drawing.Size(83, 20);
            this.labelArrayValues.TabIndex = 5;
            this.labelArrayValues.Text = "Enter array:";
            // 
            // textBoxValues
            // 
            this.textBoxValues.Location = new System.Drawing.Point(12, 32);
            this.textBoxValues.Name = "textBoxValues";
            this.textBoxValues.Size = new System.Drawing.Size(575, 27);
            this.textBoxValues.TabIndex = 6;
            this.textBoxValues.Text = "20,6,4,8,75,5,6";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.Location = new System.Drawing.Point(12, 94);
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.Size = new System.Drawing.Size(575, 27);
            this.textBoxSorted.TabIndex = 8;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 70);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(52, 20);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Result:";
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 186);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxSorted);
            this.Controls.Add(this.textBoxValues);
            this.Controls.Add(this.labelArrayValues);
            this.Controls.Add(this.buttonNext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bubble Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelArrayValues;
        private System.Windows.Forms.TextBox textBoxValues;
        private System.Windows.Forms.TextBox textBoxSorted;
        private System.Windows.Forms.Label labelResult;
    }
}

