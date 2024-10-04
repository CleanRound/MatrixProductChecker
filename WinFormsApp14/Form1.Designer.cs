namespace PositiveElementsSquared
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnGenerateNew = new System.Windows.Forms.Button(); // New button added

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 200);
            this.dataGridView1.TabIndex = 0;

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(180, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 24);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // btnGenerateNew
            // 
            this.btnGenerateNew.Location = new System.Drawing.Point(320, 230);
            this.btnGenerateNew.Name = "btnGenerateNew";
            this.btnGenerateNew.Size = new System.Drawing.Size(120, 24);
            this.btnGenerateNew.TabIndex = 3;
            this.btnGenerateNew.Text = "Generate New";
            this.btnGenerateNew.UseVisualStyleBackColor = true;
            this.btnGenerateNew.Click += new System.EventHandler(this.btnGenerateNew_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(180, 270);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Rows with prod < 40:";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 320);
            this.Controls.Add(this.btnGenerateNew);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Row Product Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnGenerateNew; // New button declared
    }
}
