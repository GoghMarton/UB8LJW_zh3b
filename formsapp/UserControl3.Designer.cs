namespace formsapp
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salutationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employementFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employementFkNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFkNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(94, 170);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 117);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Oktató törlése";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructorSkDataGridViewTextBoxColumn,
            this.salutationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusFkDataGridViewTextBoxColumn,
            this.employementFkDataGridViewTextBoxColumn,
            this.employementFkNavigationDataGridViewTextBoxColumn,
            this.lessonDataGridViewTextBoxColumn,
            this.statusFkNavigationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(327, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(539, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(formsapp.Models.Instructor);
            // 
            // instructorSkDataGridViewTextBoxColumn
            // 
            this.instructorSkDataGridViewTextBoxColumn.DataPropertyName = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.HeaderText = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.Name = "instructorSkDataGridViewTextBoxColumn";
            this.instructorSkDataGridViewTextBoxColumn.Visible = false;
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            this.salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            this.salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            this.salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // statusFkDataGridViewTextBoxColumn
            // 
            this.statusFkDataGridViewTextBoxColumn.DataPropertyName = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.HeaderText = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.Name = "statusFkDataGridViewTextBoxColumn";
            this.statusFkDataGridViewTextBoxColumn.Visible = false;
            // 
            // employementFkDataGridViewTextBoxColumn
            // 
            this.employementFkDataGridViewTextBoxColumn.DataPropertyName = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.HeaderText = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.Name = "employementFkDataGridViewTextBoxColumn";
            this.employementFkDataGridViewTextBoxColumn.Visible = false;
            // 
            // employementFkNavigationDataGridViewTextBoxColumn
            // 
            this.employementFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "EmployementFkNavigation";
            this.employementFkNavigationDataGridViewTextBoxColumn.HeaderText = "EmployementFkNavigation";
            this.employementFkNavigationDataGridViewTextBoxColumn.Name = "employementFkNavigationDataGridViewTextBoxColumn";
            this.employementFkNavigationDataGridViewTextBoxColumn.Visible = false;
            // 
            // lessonDataGridViewTextBoxColumn
            // 
            this.lessonDataGridViewTextBoxColumn.DataPropertyName = "Lesson";
            this.lessonDataGridViewTextBoxColumn.HeaderText = "Lesson";
            this.lessonDataGridViewTextBoxColumn.Name = "lessonDataGridViewTextBoxColumn";
            this.lessonDataGridViewTextBoxColumn.ReadOnly = true;
            this.lessonDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusFkNavigationDataGridViewTextBoxColumn
            // 
            this.statusFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "StatusFkNavigation";
            this.statusFkNavigationDataGridViewTextBoxColumn.HeaderText = "StatusFkNavigation";
            this.statusFkNavigationDataGridViewTextBoxColumn.Name = "statusFkNavigationDataGridViewTextBoxColumn";
            this.statusFkNavigationDataGridViewTextBoxColumn.Visible = false;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDelete);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(933, 611);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonDelete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn instructorSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkNavigationDataGridViewTextBoxColumn;
        private BindingSource instructorBindingSource;
    }
}
