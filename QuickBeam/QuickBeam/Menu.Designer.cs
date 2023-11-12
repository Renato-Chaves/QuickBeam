namespace QuickBeam
{
    partial class Menu
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
            Title = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button5 = new Button();
            panel2 = new Panel();
            SortingDescLbl = new TextBox();
            SortingNameLbl = new TextBox();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(43, 65);
            Title.Name = "Title";
            Title.Size = new Size(245, 54);
            Title.TabIndex = 0;
            Title.Text = "QuickBeam";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 60, 70);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(190, 214, 217);
            button1.Location = new Point(43, 159);
            button1.Name = "button1";
            button1.Size = new Size(245, 60);
            button1.TabIndex = 1;
            button1.Text = "Bubble Sort";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 60, 70);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(190, 214, 217);
            button2.Location = new Point(43, 248);
            button2.Name = "button2";
            button2.Size = new Size(245, 60);
            button2.TabIndex = 2;
            button2.Text = "Merge Sort";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 60, 70);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(190, 214, 217);
            button3.Location = new Point(43, 419);
            button3.Name = "button3";
            button3.Size = new Size(245, 60);
            button3.TabIndex = 3;
            button3.Text = "Sorting Sort";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 60, 70);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(190, 214, 217);
            button4.Location = new Point(43, 504);
            button4.Name = "button4";
            button4.Size = new Size(245, 60);
            button4.TabIndex = 4;
            button4.Text = "Quick Sort";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 60, 70);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(SortingDescLbl);
            panel1.Controls.Add(SortingNameLbl);
            panel1.Location = new Point(349, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 523);
            panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(34, 60, 70);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(190, 214, 217);
            textBox3.Location = new Point(291, 336);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 118);
            textBox3.TabIndex = 9;
            textBox3.Text = "- Lorem\r\n- Ipsum\r\n- Sit\r\n- Dolor\r\n- Amet";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(34, 60, 70);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(190, 214, 217);
            textBox2.Location = new Point(161, 336);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 118);
            textBox2.TabIndex = 8;
            textBox2.Text = "- Lorem\r\n- Ipsum\r\n- Sit\r\n- Dolor\r\n- Amet";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(34, 60, 70);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(190, 214, 217);
            textBox1.Location = new Point(30, 336);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 118);
            textBox1.TabIndex = 7;
            textBox1.Text = "- Lorem\r\n- Ipsum\r\n- Sit\r\n- Dolor\r\n- Amet";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(139, 151, 145);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(190, 214, 217);
            button5.Location = new Point(13, 460);
            button5.Name = "button5";
            button5.Size = new Size(391, 49);
            button5.TabIndex = 6;
            button5.Text = "Open Simulation";
            button5.UseVisualStyleBackColor = false;
            button5.Click += OpenSimBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Location = new Point(13, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 146);
            panel2.TabIndex = 4;
            // 
            // SortingDescLbl
            // 
            SortingDescLbl.BackColor = Color.FromArgb(34, 60, 70);
            SortingDescLbl.BorderStyle = BorderStyle.None;
            SortingDescLbl.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            SortingDescLbl.ForeColor = Color.FromArgb(190, 214, 217);
            SortingDescLbl.Location = new Point(13, 69);
            SortingDescLbl.Multiline = true;
            SortingDescLbl.Name = "SortingDescLbl";
            SortingDescLbl.Size = new Size(391, 109);
            SortingDescLbl.TabIndex = 3;
            SortingDescLbl.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,";
            SortingDescLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // SortingNameLbl
            // 
            SortingNameLbl.BackColor = Color.FromArgb(34, 60, 70);
            SortingNameLbl.BorderStyle = BorderStyle.None;
            SortingNameLbl.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            SortingNameLbl.ForeColor = Color.FromArgb(190, 214, 217);
            SortingNameLbl.Location = new Point(3, 15);
            SortingNameLbl.Name = "SortingNameLbl";
            SortingNameLbl.Size = new Size(414, 48);
            SortingNameLbl.TabIndex = 2;
            SortingNameLbl.Text = "Quick Sort";
            SortingNameLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(34, 60, 70);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(190, 214, 217);
            button6.Location = new Point(43, 339);
            button6.Name = "button6";
            button6.Size = new Size(245, 60);
            button6.TabIndex = 6;
            button6.Text = "Heap Sort";
            button6.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 600);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Title);
            DoubleBuffered = true;
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private TextBox SortingDescLbl;
        private TextBox SortingNameLbl;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button5;
        private Panel panel2;
        private Button button6;
        private TextBox textBox3;
    }
}