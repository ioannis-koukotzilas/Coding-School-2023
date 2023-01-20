namespace Session_10 {
    partial class UniversityForm {
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
            this.StudentsGrid = new System.Windows.Forms.DataGridView();
            this.StudentsLabel = new System.Windows.Forms.Label();
            this.GradesLabel = new System.Windows.Forms.Label();
            this.GradesGrid = new System.Windows.Forms.DataGridView();
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.CoursesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ScheduledCoursesGrid = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduledCoursesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsGrid
            // 
            this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGrid.Location = new System.Drawing.Point(12, 27);
            this.StudentsGrid.Name = "StudentsGrid";
            this.StudentsGrid.RowTemplate.Height = 25;
            this.StudentsGrid.Size = new System.Drawing.Size(776, 82);
            this.StudentsGrid.TabIndex = 0;
            // 
            // StudentsLabel
            // 
            this.StudentsLabel.AutoSize = true;
            this.StudentsLabel.Location = new System.Drawing.Point(12, 9);
            this.StudentsLabel.Name = "StudentsLabel";
            this.StudentsLabel.Size = new System.Drawing.Size(53, 15);
            this.StudentsLabel.TabIndex = 1;
            this.StudentsLabel.Text = "Students";
            // 
            // GradesLabel
            // 
            this.GradesLabel.AutoSize = true;
            this.GradesLabel.Location = new System.Drawing.Point(12, 112);
            this.GradesLabel.Name = "GradesLabel";
            this.GradesLabel.Size = new System.Drawing.Size(43, 15);
            this.GradesLabel.TabIndex = 2;
            this.GradesLabel.Text = "Grades";
            this.GradesLabel.UseMnemonic = false;
            // 
            // GradesGrid
            // 
            this.GradesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradesGrid.Location = new System.Drawing.Point(12, 130);
            this.GradesGrid.Name = "GradesGrid";
            this.GradesGrid.RowTemplate.Height = 25;
            this.GradesGrid.Size = new System.Drawing.Size(776, 78);
            this.GradesGrid.TabIndex = 3;
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Location = new System.Drawing.Point(12, 211);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(49, 15);
            this.CoursesLabel.TabIndex = 4;
            this.CoursesLabel.Text = "Courses";
            // 
            // CoursesGrid
            // 
            this.CoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesGrid.Location = new System.Drawing.Point(12, 229);
            this.CoursesGrid.Name = "CoursesGrid";
            this.CoursesGrid.RowTemplate.Height = 25;
            this.CoursesGrid.Size = new System.Drawing.Size(776, 77);
            this.CoursesGrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scheduled Courses";
            // 
            // ScheduledCoursesGrid
            // 
            this.ScheduledCoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduledCoursesGrid.Location = new System.Drawing.Point(12, 327);
            this.ScheduledCoursesGrid.Name = "ScheduledCoursesGrid";
            this.ScheduledCoursesGrid.RowTemplate.Height = 25;
            this.ScheduledCoursesGrid.Size = new System.Drawing.Size(776, 94);
            this.ScheduledCoursesGrid.TabIndex = 7;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(713, 427);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(632, 427);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 9;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ScheduledCoursesGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoursesGrid);
            this.Controls.Add(this.CoursesLabel);
            this.Controls.Add(this.GradesGrid);
            this.Controls.Add(this.GradesLabel);
            this.Controls.Add(this.StudentsLabel);
            this.Controls.Add(this.StudentsGrid);
            this.Name = "UniversityForm";
            this.Text = "UniversityForm";
            this.Load += new System.EventHandler(this.UniversityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduledCoursesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView StudentsGrid;
        private Label StudentsLabel;
        private Label GradesLabel;
        private DataGridView GradesGrid;
        private Label CoursesLabel;
        private DataGridView CoursesGrid;
        private Label label1;
        private DataGridView ScheduledCoursesGrid;
        private Button BtnSave;
        private Button BtnLoad;
    }
}