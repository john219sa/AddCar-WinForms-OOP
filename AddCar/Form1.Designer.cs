namespace AddCar
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtYears = new TextBox();
            txtModel = new TextBox();
            txtColor = new TextBox();
            listBox = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 312);
            button1.Name = "button1";
            button1.Size = new Size(195, 29);
            button1.TabIndex = 0;
            button1.Text = "Add car ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 85);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "enter car id ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 125);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "enter cat name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 163);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 3;
            label3.Text = "enter car yers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 201);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 4;
            label4.Text = "enter car model ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 238);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 5;
            label5.Text = "enter car color";
            // 
            // txtId
            // 
            txtId.Location = new Point(242, 86);
            txtId.Name = "txtId";
            txtId.Size = new Size(195, 27);
            txtId.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(242, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 27);
            txtName.TabIndex = 7;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(242, 163);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(195, 27);
            txtYears.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(242, 201);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(195, 27);
            txtModel.TabIndex = 9;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(242, 238);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(195, 27);
            txtColor.TabIndex = 10;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(509, 66);
            listBox.Name = "listBox";
            listBox.Size = new Size(240, 284);
            listBox.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(262, 312);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 12;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 394);
            Controls.Add(button2);
            Controls.Add(listBox);
            Controls.Add(txtColor);
            Controls.Add(txtModel);
            Controls.Add(txtYears);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtYears;
        private TextBox txtModel;
        private TextBox txtColor;
        private ListBox listBox;
        private Button button2;
    }
}
