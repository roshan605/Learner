namespace Learner
{
    partial class FormParent
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
            txtFirst = new TextBox();
            txtSecond = new TextBox();
            txtThird = new TextBox();
            txtFourth = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAnswer = new Button();
            SuspendLayout();
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(247, 47);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(292, 27);
            txtFirst.TabIndex = 0;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(247, 87);
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(292, 27);
            txtSecond.TabIndex = 1;
            // 
            // txtThird
            // 
            txtThird.Location = new Point(247, 132);
            txtThird.Name = "txtThird";
            txtThird.Size = new Size(292, 27);
            txtThird.TabIndex = 2;
            // 
            // txtFourth
            // 
            txtFourth.Location = new Point(247, 191);
            txtFourth.Name = "txtFourth";
            txtFourth.Size = new Size(292, 27);
            txtFourth.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 50);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "input 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 90);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "input 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 135);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 6;
            label3.Text = "input 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 194);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Answer";
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(409, 240);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(129, 53);
            btnAnswer.TabIndex = 8;
            btnAnswer.Text = "Get Answer";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // FormParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(btnAnswer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFourth);
            Controls.Add(txtThird);
            Controls.Add(txtSecond);
            Controls.Add(txtFirst);
            Name = "FormParent";
            Text = "Input";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtThird;
        private TextBox txtFourth;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAnswer;
    }
}
