namespace inlämningsuppgift1_forms
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
            this.txtBox_price = new System.Windows.Forms.TextBox();
            this.txtBox_paid = new System.Windows.Forms.TextBox();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.lbl_price_name = new System.Windows.Forms.Label();
            this.lbl_payment_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_price
            // 
            this.txtBox_price.Location = new System.Drawing.Point(109, 51);
            this.txtBox_price.Name = "txtBox_price";
            this.txtBox_price.Size = new System.Drawing.Size(100, 20);
            this.txtBox_price.TabIndex = 0;
            this.txtBox_price.Text = "0";
            this.txtBox_price.TextChanged += new System.EventHandler(this.txtBox_price_TextChanged);
            // 
            // txtBox_paid
            // 
            this.txtBox_paid.Location = new System.Drawing.Point(109, 126);
            this.txtBox_paid.Name = "txtBox_paid";
            this.txtBox_paid.Size = new System.Drawing.Size(100, 20);
            this.txtBox_paid.TabIndex = 1;
            this.txtBox_paid.Text = "0";
            this.txtBox_paid.TextChanged += new System.EventHandler(this.txtBox_paid_TextChanged);
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(337, 51);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(17, 13);
            this.lbl_answer.TabIndex = 2;
            this.lbl_answer.Text = "lbl";
            this.lbl_answer.Click += new System.EventHandler(this.lbl_answer_Click);
            // 
            // lbl_price_name
            // 
            this.lbl_price_name.AutoSize = true;
            this.lbl_price_name.Location = new System.Drawing.Point(79, 54);
            this.lbl_price_name.Name = "lbl_price_name";
            this.lbl_price_name.Size = new System.Drawing.Size(24, 13);
            this.lbl_price_name.TabIndex = 3;
            this.lbl_price_name.Text = "Pris";
            // 
            // lbl_payment_name
            // 
            this.lbl_payment_name.AutoSize = true;
            this.lbl_payment_name.Location = new System.Drawing.Point(15, 129);
            this.lbl_payment_name.Name = "lbl_payment_name";
            this.lbl_payment_name.Size = new System.Drawing.Size(88, 13);
            this.lbl_payment_name.TabIndex = 4;
            this.lbl_payment_name.Text = "Betalningsmängd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 411);
            this.Controls.Add(this.lbl_payment_name);
            this.Controls.Add(this.lbl_price_name);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.txtBox_paid);
            this.Controls.Add(this.txtBox_price);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_price;
        private System.Windows.Forms.TextBox txtBox_paid;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_price_name;
        private System.Windows.Forms.Label lbl_payment_name;
    }
}

