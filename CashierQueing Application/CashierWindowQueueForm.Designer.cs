namespace CashierQueing_Application
{
    partial class CashierWindowQueueForm
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
            refreshBtn = new Button();
            nextBtn = new Button();
            listCashierQueue = new ListBox();
            SuspendLayout();
            // 
            // refreshBtn
            // 
            refreshBtn.FlatStyle = FlatStyle.Flat;
            refreshBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.Location = new Point(12, 12);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(106, 35);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextBtn.Location = new Point(12, 63);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(106, 35);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 25;
            listCashierQueue.Location = new Point(141, 12);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(494, 404);
            listCashierQueue.TabIndex = 3;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 450);
            Controls.Add(listCashierQueue);
            Controls.Add(nextBtn);
            Controls.Add(refreshBtn);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button refreshBtn;
        private Button nextBtn;
        private ListBox listCashierQueue;
    }
}