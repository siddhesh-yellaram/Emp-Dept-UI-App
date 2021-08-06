
namespace EmpDeptUIApp
{
    partial class EmpDataDisp
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
            this.btnDept = new System.Windows.Forms.Button();
            this.empDataGrid = new System.Windows.Forms.DataGridView();
            this.deptDataGrid = new System.Windows.Forms.DataGridView();
            this.btnEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(464, 90);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(119, 41);
            this.btnDept.TabIndex = 1;
            this.btnDept.Text = "Display Dept";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // empDataGrid
            // 
            this.empDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGrid.Location = new System.Drawing.Point(12, 179);
            this.empDataGrid.Name = "empDataGrid";
            this.empDataGrid.RowHeadersWidth = 51;
            this.empDataGrid.RowTemplate.Height = 24;
            this.empDataGrid.Size = new System.Drawing.Size(363, 246);
            this.empDataGrid.TabIndex = 2;
            // 
            // deptDataGrid
            // 
            this.deptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptDataGrid.Location = new System.Drawing.Point(396, 179);
            this.deptDataGrid.Name = "deptDataGrid";
            this.deptDataGrid.RowHeadersWidth = 51;
            this.deptDataGrid.RowTemplate.Height = 24;
            this.deptDataGrid.Size = new System.Drawing.Size(383, 246);
            this.deptDataGrid.TabIndex = 3;
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(67, 90);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(123, 41);
            this.btnEmp.TabIndex = 4;
            this.btnEmp.Text = "Display Emp";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmp);
            this.Controls.Add(this.deptDataGrid);
            this.Controls.Add(this.empDataGrid);
            this.Controls.Add(this.btnDept);
            this.Name = "Form1";
            this.Text = "EmpDeptDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.empDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.DataGridView empDataGrid;
        private System.Windows.Forms.DataGridView deptDataGrid;
        private System.Windows.Forms.Button btnEmp;
    }
}

