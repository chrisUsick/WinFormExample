namespace labChrisUsick
{
    partial class frmCommission
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
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCommissionOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(38, 30);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(39, 13);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sales: ";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(83, 27);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 1;
            this.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(12, 58);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(65, 13);
            this.lblCommission.TabIndex = 2;
            this.lblCommission.Text = "Commission:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(245, 103);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCommissionOutput
            // 
            this.lblCommissionOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCommissionOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommissionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommissionOutput.Location = new System.Drawing.Point(83, 58);
            this.lblCommissionOutput.Name = "lblCommissionOutput";
            this.lblCommissionOutput.Size = new System.Drawing.Size(100, 23);
            this.lblCommissionOutput.TabIndex = 5;
            this.lblCommissionOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 138);
            this.Controls.Add(this.lblCommissionOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblSales);
            this.MaximizeBox = false;
            this.Name = "frmCommission";
            this.Text = "frmCommission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCommissionOutput;
    }
}