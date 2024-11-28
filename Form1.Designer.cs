namespace mdas
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
            label1 = new Label();
            label2 = new Label();
            tbFirstNumber = new TextBox();
            tbSecondNumber = new TextBox();
            btnAddition = new Button();
            tbAnswer = new TextBox();
            label3 = new Label();
            btnSubtraction = new Button();
            btnDivision = new Button();
            btnMultiplication = new Button();
            btnClearFields = new Button();
            btnModulus = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(217, 191, 177);
            label1.Font = new Font("Gabriola", 14.25F);
            label1.ForeColor = Color.FromArgb(94, 89, 70);
            label1.Location = new Point(70, 111);
            label1.Name = "label1";
            label1.Size = new Size(79, 35);
            label1.TabIndex = 0;
            label1.Text = "First Num:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(217, 191, 177);
            label2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(94, 89, 70);
            label2.Location = new Point(71, 194);
            label2.Name = "label2";
            label2.Size = new Size(93, 35);
            label2.TabIndex = 1;
            label2.Text = "Second Num:";
            // 
            // tbFirstNumber
            // 
            tbFirstNumber.BackColor = Color.FromArgb(217, 191, 177);
            tbFirstNumber.ForeColor = Color.FromArgb(94, 89, 70);
            tbFirstNumber.Location = new Point(70, 149);
            tbFirstNumber.Name = "tbFirstNumber";
            tbFirstNumber.Size = new Size(143, 23);
            tbFirstNumber.TabIndex = 2;
            // 
            // tbSecondNumber
            // 
            tbSecondNumber.BackColor = Color.FromArgb(217, 191, 177);
            tbSecondNumber.ForeColor = Color.FromArgb(94, 89, 70);
            tbSecondNumber.Location = new Point(70, 232);
            tbSecondNumber.Name = "tbSecondNumber";
            tbSecondNumber.Size = new Size(143, 23);
            tbSecondNumber.TabIndex = 3;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = Color.FromArgb(94, 89, 70);
            btnAddition.FlatAppearance.BorderSize = 0;
            btnAddition.FlatStyle = FlatStyle.Flat;
            btnAddition.Font = new Font("Gabriola", 14.25F);
            btnAddition.ForeColor = Color.White;
            btnAddition.Location = new Point(272, 179);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(50, 50);
            btnAddition.TabIndex = 4;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnAddition_Click;
            // 
            // tbAnswer
            // 
            tbAnswer.BackColor = Color.FromArgb(217, 191, 177);
            tbAnswer.ForeColor = Color.FromArgb(94, 89, 70);
            tbAnswer.Location = new Point(272, 149);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Size = new Size(162, 23);
            tbAnswer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(217, 191, 177);
            label3.Font = new Font("Gabriola", 14.25F);
            label3.ForeColor = Color.FromArgb(94, 89, 70);
            label3.Location = new Point(272, 111);
            label3.Name = "label3";
            label3.Size = new Size(62, 35);
            label3.TabIndex = 6;
            label3.Text = "Answer:";
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = Color.FromArgb(94, 89, 70);
            btnSubtraction.FlatAppearance.BorderSize = 0;
            btnSubtraction.FlatStyle = FlatStyle.Flat;
            btnSubtraction.Font = new Font("Gabriola", 14.25F);
            btnSubtraction.ForeColor = Color.White;
            btnSubtraction.Location = new Point(328, 180);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(50, 50);
            btnSubtraction.TabIndex = 7;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += btnSubtraction_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.FromArgb(94, 89, 70);
            btnDivision.FlatAppearance.BorderSize = 0;
            btnDivision.FlatStyle = FlatStyle.Flat;
            btnDivision.Font = new Font("Gabriola", 14.25F);
            btnDivision.ForeColor = Color.White;
            btnDivision.Location = new Point(384, 179);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(50, 50);
            btnDivision.TabIndex = 8;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = Color.FromArgb(94, 89, 70);
            btnMultiplication.FlatAppearance.BorderSize = 0;
            btnMultiplication.FlatStyle = FlatStyle.Flat;
            btnMultiplication.Font = new Font("Gabriola", 14.25F);
            btnMultiplication.ForeColor = Color.White;
            btnMultiplication.Location = new Point(272, 236);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(50, 50);
            btnMultiplication.TabIndex = 9;
            btnMultiplication.Text = "x";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.BackColor = Color.FromArgb(94, 89, 70);
            btnClearFields.FlatAppearance.BorderSize = 0;
            btnClearFields.FlatStyle = FlatStyle.Flat;
            btnClearFields.Font = new Font("Gabriola", 14.25F);
            btnClearFields.ForeColor = Color.White;
            btnClearFields.Location = new Point(272, 292);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(162, 50);
            btnClearFields.TabIndex = 10;
            btnClearFields.Text = "Clear fields";
            btnClearFields.UseVisualStyleBackColor = false;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // btnModulus
            // 
            btnModulus.BackColor = Color.FromArgb(94, 89, 70);
            btnModulus.FlatAppearance.BorderSize = 0;
            btnModulus.FlatStyle = FlatStyle.Flat;
            btnModulus.Font = new Font("Gabriola", 14.25F);
            btnModulus.ForeColor = Color.White;
            btnModulus.Location = new Point(328, 236);
            btnModulus.Name = "btnModulus";
            btnModulus.Size = new Size(50, 50);
            btnModulus.TabIndex = 11;
            btnModulus.Text = "%";
            btnModulus.UseVisualStyleBackColor = false;
            btnModulus.Click += btnModulus_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gabriola", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(94, 89, 70);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(90, 59);
            label4.TabIndex = 12;
            label4.Text = "MDAS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 193, 171);
            ClientSize = new Size(522, 414);
            Controls.Add(label4);
            Controls.Add(btnModulus);
            Controls.Add(btnClearFields);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDivision);
            Controls.Add(btnSubtraction);
            Controls.Add(label3);
            Controls.Add(tbAnswer);
            Controls.Add(btnAddition);
            Controls.Add(tbSecondNumber);
            Controls.Add(tbFirstNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MDAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFirstNumber;
        private TextBox tbSecondNumber;
        private Button btnAddition;
        private TextBox tbAnswer;
        private Label label3;
        private Button btnSubtraction;
        private Button btnDivision;
        private Button btnMultiplication;
        private Button btnClearFields;
        private Button btnModulus;
        private Label label4;
    }
}