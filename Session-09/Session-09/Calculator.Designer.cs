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
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddition
            // 
            this.BtnAddition.Location = new System.Drawing.Point(356, 338);
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
            this.Monitor.ReadOnly = true;
            this.Monitor.Size = new System.Drawing.Size(324, 119);
            this.Monitor.TabIndex = 1;
            // 
            // BtnOne
            // 
            this.BtnOne.Location = new System.Drawing.Point(28, 338);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(75, 23);
            this.BtnOne.TabIndex = 2;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.BtnOneClick);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Location = new System.Drawing.Point(109, 338);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(75, 23);
            this.BtnTwo.TabIndex = 3;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwoClick);
            // 
            // BtnThree
            // 
            this.BtnThree.Location = new System.Drawing.Point(190, 338);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(75, 23);
            this.BtnThree.TabIndex = 4;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            // 
            // BtnFour
            // 
            this.BtnFour.Location = new System.Drawing.Point(28, 309);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(75, 23);
            this.BtnFour.TabIndex = 5;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            // 
            // BtnEquals
            // 
            this.BtnEquals.Location = new System.Drawing.Point(437, 338);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(75, 23);
            this.BtnEquals.TabIndex = 6;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEqualsClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnOne);
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
        private Button BtnOne;
        private Button BtnTwo;
        private Button BtnThree;
        private Button BtnFour;
        private Button BtnEquals;
    }
}