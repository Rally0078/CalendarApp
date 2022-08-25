namespace CalendarApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.monthlb = new System.Windows.Forms.Label();
            this.nextBt = new System.Windows.Forms.Button();
            this.prevBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Girls Have Many Secrets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Girls Have Many Secrets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Girls Have Many Secrets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wednesday";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Girls Have Many Secrets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tuesday";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Girls Have Many Secrets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1049, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Friday";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Girls Have Many Secrets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(842, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thursday";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Girls Have Many Secrets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1213, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 35);
            this.label7.TabIndex = 7;
            this.label7.Text = "Saturday";
            // 
            // DayContainer
            // 
            this.DayContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DayContainer.Location = new System.Drawing.Point(56, 142);
            this.DayContainer.Name = "DayContainer";
            this.DayContainer.Size = new System.Drawing.Size(1310, 765);
            this.DayContainer.TabIndex = 0;
            this.DayContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.DayContainer_Paint);
            // 
            // monthlb
            // 
            this.monthlb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthlb.AutoSize = true;
            this.monthlb.Font = new System.Drawing.Font("Girls Have Many Secrets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlb.Location = new System.Drawing.Point(607, 12);
            this.monthlb.Name = "monthlb";
            this.monthlb.Size = new System.Drawing.Size(178, 47);
            this.monthlb.TabIndex = 8;
            this.monthlb.Text = "MonthYear";
            // 
            // nextBt
            // 
            this.nextBt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nextBt.AutoSize = true;
            this.nextBt.BackColor = System.Drawing.Color.White;
            this.nextBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextBt.Location = new System.Drawing.Point(1067, 12);
            this.nextBt.Name = "nextBt";
            this.nextBt.Size = new System.Drawing.Size(125, 55);
            this.nextBt.TabIndex = 9;
            this.nextBt.Text = "Next Month";
            this.nextBt.UseVisualStyleBackColor = false;
            this.nextBt.Click += new System.EventHandler(this.nextBt_Click);
            // 
            // prevBt
            // 
            this.prevBt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prevBt.AutoSize = true;
            this.prevBt.BackColor = System.Drawing.Color.White;
            this.prevBt.Location = new System.Drawing.Point(274, 16);
            this.prevBt.Name = "prevBt";
            this.prevBt.Size = new System.Drawing.Size(125, 55);
            this.prevBt.TabIndex = 10;
            this.prevBt.Text = "Previous Month";
            this.prevBt.UseVisualStyleBackColor = false;
            this.prevBt.Click += new System.EventHandler(this.prevBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1422, 946);
            this.Controls.Add(this.nextBt);
            this.Controls.Add(this.prevBt);
            this.Controls.Add(this.monthlb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayContainer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The RallyCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel DayContainer;
        private System.Windows.Forms.Label monthlb;
        private System.Windows.Forms.Button nextBt;
        private System.Windows.Forms.Button prevBt;
    }
}

