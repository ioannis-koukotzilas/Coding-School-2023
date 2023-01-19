namespace Session_09 {
    partial class Calculator {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtnAddition = new System.Windows.Forms.Button();
            this.Monitor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddition
            // 
            this.BtnAddition.Location = new System.Drawing.Point(594, 338);
            this.BtnAddition.Name = "BtnAddition";
            this.BtnAddition.Size = new System.Drawing.Size(75, 23);
            this.BtnAddition.TabIndex = 0;
            this.BtnAddition.Text = "+";
            this.BtnAddition.UseVisualStyleBackColor = true;
            this.BtnAddition.Click += new System.EventHandler(this.BtnAdditionClick);
            // 
            // Monitor
            // 
            this.Monitor.Location = new System.Drawing.Point(28, 12);
            this.Monitor.Multiline = true;
            this.Monitor.Name = "Monitor";
            this.Monitor.Size = new System.Drawing.Size(324, 119);
            this.Monitor.TabIndex = 1;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Monitor);
            this.Controls.Add(this.BtnAddition);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddition;
        private TextBox Monitor;
    }
}