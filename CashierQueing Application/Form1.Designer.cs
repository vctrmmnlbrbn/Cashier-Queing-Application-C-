namespace CashierQueing_Application
{
    partial class Form1
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
            Cashier_Click = new Button();
            label1 = new Label();
            lblQueue = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Cashier_Click
            // 
            Cashier_Click.FlatStyle = FlatStyle.Flat;
            Cashier_Click.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cashier_Click.Location = new Point(12, 54);
            Cashier_Click.Name = "Cashier_Click";
            Cashier_Click.Size = new Size(146, 89);
            Cashier_Click.TabIndex = 0;
            Cashier_Click.Text = "Cashier";
            Cashier_Click.UseVisualStyleBackColor = true;
            Cashier_Click.Click += Cashier_Click_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 29);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(178, 75);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(0, 45);
            lblQueue.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 3;
            label3.Text = "* Click to get a number";
            // 
            // button1
            // 
            button1.Location = new Point(326, 180);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "View Cashier";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 215);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(Cashier_Click);
            Name = "Form1";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cashier_Click;
        private Label label1;
        private Label lblQueue;
        private Label label3;
        private Button button1;
    }
}
