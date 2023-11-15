namespace QuickBeam
{
    partial class StatsPage
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
            panel1 = new Panel();
            BigOText = new TextBox();
            MovesText = new TextBox();
            StepsText = new TextBox();
            ElapsedTimeText = new TextBox();
            InputQuantityText = new TextBox();
            BeginSimBtn = new Button();
            SortingCaseText = new TextBox();
            textBox3 = new TextBox();
            SortingTitle = new TextBox();
            panel2 = new Panel();
            StatsTitle = new TextBox();
            panel3 = new Panel();
            FontSizeSlider = new TrackBar();
            NumberQuantitySlider = new TrackBar();
            WorstCaseBtn = new Button();
            AverageCaseBtn = new Button();
            BestCaseBtn = new Button();
            textBox7 = new TextBox();
            FontSliderText = new TextBox();
            SliderInputText = new TextBox();
            BackArrow_btn = new Button();
            textBox2 = new TextBox();
            panel4 = new Panel();
            OutputText = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FontSizeSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberQuantitySlider).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 60, 70);
            panel1.Controls.Add(BigOText);
            panel1.Controls.Add(MovesText);
            panel1.Controls.Add(StepsText);
            panel1.Controls.Add(ElapsedTimeText);
            panel1.Controls.Add(InputQuantityText);
            panel1.Controls.Add(BeginSimBtn);
            panel1.Controls.Add(SortingCaseText);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(SortingTitle);
            panel1.Location = new Point(359, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 402);
            panel1.TabIndex = 6;
            // 
            // BigOText
            // 
            BigOText.BackColor = Color.FromArgb(34, 60, 70);
            BigOText.BorderStyle = BorderStyle.None;
            BigOText.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            BigOText.ForeColor = Color.FromArgb(190, 214, 217);
            BigOText.Location = new Point(264, 289);
            BigOText.Multiline = true;
            BigOText.Name = "BigOText";
            BigOText.Size = new Size(134, 25);
            BigOText.TabIndex = 16;
            BigOText.Text = "log(n)";
            BigOText.TextAlign = HorizontalAlignment.Right;
            // 
            // MovesText
            // 
            MovesText.BackColor = Color.FromArgb(34, 60, 70);
            MovesText.BorderStyle = BorderStyle.None;
            MovesText.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            MovesText.ForeColor = Color.FromArgb(190, 214, 217);
            MovesText.Location = new Point(264, 247);
            MovesText.Multiline = true;
            MovesText.Name = "MovesText";
            MovesText.Size = new Size(134, 20);
            MovesText.TabIndex = 15;
            MovesText.Text = "50";
            MovesText.TextAlign = HorizontalAlignment.Right;
            // 
            // StepsText
            // 
            StepsText.BackColor = Color.FromArgb(34, 60, 70);
            StepsText.BorderStyle = BorderStyle.None;
            StepsText.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            StepsText.ForeColor = Color.FromArgb(190, 214, 217);
            StepsText.Location = new Point(264, 206);
            StepsText.Multiline = true;
            StepsText.Name = "StepsText";
            StepsText.Size = new Size(134, 20);
            StepsText.TabIndex = 14;
            StepsText.Text = "130";
            StepsText.TextAlign = HorizontalAlignment.Right;
            // 
            // ElapsedTimeText
            // 
            ElapsedTimeText.BackColor = Color.FromArgb(34, 60, 70);
            ElapsedTimeText.BorderStyle = BorderStyle.None;
            ElapsedTimeText.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            ElapsedTimeText.ForeColor = Color.FromArgb(190, 214, 217);
            ElapsedTimeText.Location = new Point(264, 162);
            ElapsedTimeText.Multiline = true;
            ElapsedTimeText.Name = "ElapsedTimeText";
            ElapsedTimeText.Size = new Size(134, 20);
            ElapsedTimeText.TabIndex = 13;
            ElapsedTimeText.Text = "1.7ms";
            ElapsedTimeText.TextAlign = HorizontalAlignment.Right;
            // 
            // InputQuantityText
            // 
            InputQuantityText.BackColor = Color.FromArgb(34, 60, 70);
            InputQuantityText.BorderStyle = BorderStyle.None;
            InputQuantityText.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            InputQuantityText.ForeColor = Color.FromArgb(190, 214, 217);
            InputQuantityText.Location = new Point(264, 121);
            InputQuantityText.Multiline = true;
            InputQuantityText.Name = "InputQuantityText";
            InputQuantityText.Size = new Size(134, 20);
            InputQuantityText.TabIndex = 12;
            InputQuantityText.Text = "1000";
            InputQuantityText.TextAlign = HorizontalAlignment.Right;
            // 
            // BeginSimBtn
            // 
            BeginSimBtn.BackColor = Color.FromArgb(139, 151, 145);
            BeginSimBtn.FlatAppearance.BorderSize = 0;
            BeginSimBtn.FlatStyle = FlatStyle.Flat;
            BeginSimBtn.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BeginSimBtn.ForeColor = Color.FromArgb(190, 214, 217);
            BeginSimBtn.Location = new Point(27, 336);
            BeginSimBtn.Name = "BeginSimBtn";
            BeginSimBtn.Size = new Size(371, 49);
            BeginSimBtn.TabIndex = 0;
            BeginSimBtn.Text = "Begin Simulation";
            BeginSimBtn.UseVisualStyleBackColor = false;
            BeginSimBtn.Click += BeginSimBtn_Click;
            // 
            // SortingCaseText
            // 
            SortingCaseText.BackColor = Color.FromArgb(34, 60, 70);
            SortingCaseText.BorderStyle = BorderStyle.None;
            SortingCaseText.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            SortingCaseText.ForeColor = Color.FromArgb(190, 214, 217);
            SortingCaseText.Location = new Point(264, 80);
            SortingCaseText.Multiline = true;
            SortingCaseText.Name = "SortingCaseText";
            SortingCaseText.Size = new Size(134, 23);
            SortingCaseText.TabIndex = 10;
            SortingCaseText.Text = "Melhor";
            SortingCaseText.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(34, 60, 70);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(190, 214, 217);
            textBox3.Location = new Point(27, 80);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(262, 248);
            textBox3.TabIndex = 9;
            textBox3.Text = "- Dificuldade de Ordenação\r\n\r\n- Quantidade de Numeros\r\n\r\n- Tempo de execução\r\n\r\n- Passos\r\n\r\n- Trocas\r\n\r\n- Big O Notation";
            // 
            // SortingTitle
            // 
            SortingTitle.BackColor = Color.FromArgb(34, 60, 70);
            SortingTitle.BorderStyle = BorderStyle.None;
            SortingTitle.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            SortingTitle.ForeColor = Color.FromArgb(190, 214, 217);
            SortingTitle.Location = new Point(3, 13);
            SortingTitle.Name = "SortingTitle";
            SortingTitle.ReadOnly = true;
            SortingTitle.Size = new Size(411, 48);
            SortingTitle.TabIndex = 2;
            SortingTitle.Text = "Quick Sort";
            SortingTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 60, 70);
            panel2.Controls.Add(StatsTitle);
            panel2.Location = new Point(15, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 81);
            panel2.TabIndex = 12;
            // 
            // StatsTitle
            // 
            StatsTitle.BackColor = Color.FromArgb(34, 60, 70);
            StatsTitle.BorderStyle = BorderStyle.None;
            StatsTitle.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            StatsTitle.ForeColor = Color.FromArgb(190, 214, 217);
            StatsTitle.Location = new Point(5, 13);
            StatsTitle.Name = "StatsTitle";
            StatsTitle.ReadOnly = true;
            StatsTitle.Size = new Size(335, 48);
            StatsTitle.TabIndex = 2;
            StatsTitle.Text = "Quick Beam";
            StatsTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(34, 60, 70);
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(FontSizeSlider);
            panel3.Controls.Add(NumberQuantitySlider);
            panel3.Controls.Add(WorstCaseBtn);
            panel3.Controls.Add(AverageCaseBtn);
            panel3.Controls.Add(BestCaseBtn);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(FontSliderText);
            panel3.Controls.Add(SliderInputText);
            panel3.Controls.Add(BackArrow_btn);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(15, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 315);
            panel3.TabIndex = 13;
            // 
            // FontSizeSlider
            // 
            FontSizeSlider.Location = new Point(15, 158);
            FontSizeSlider.Maximum = 30;
            FontSizeSlider.Minimum = 4;
            FontSizeSlider.Name = "FontSizeSlider";
            FontSizeSlider.Size = new Size(314, 45);
            FontSizeSlider.TabIndex = 15;
            FontSizeSlider.TickFrequency = 0;
            FontSizeSlider.TickStyle = TickStyle.Both;
            FontSizeSlider.Value = 4;
            FontSizeSlider.Scroll += FontSizeSlider_Scroll;
            // 
            // NumberQuantitySlider
            // 
            NumberQuantitySlider.LargeChange = 10;
            NumberQuantitySlider.Location = new Point(15, 95);
            NumberQuantitySlider.Maximum = 1000;
            NumberQuantitySlider.Minimum = 1;
            NumberQuantitySlider.Name = "NumberQuantitySlider";
            NumberQuantitySlider.Size = new Size(314, 45);
            NumberQuantitySlider.TabIndex = 0;
            NumberQuantitySlider.TickFrequency = 0;
            NumberQuantitySlider.TickStyle = TickStyle.Both;
            NumberQuantitySlider.Value = 5;
            NumberQuantitySlider.Scroll += NumberQuantitySlider_Scroll;
            // 
            // WorstCaseBtn
            // 
            WorstCaseBtn.BackColor = Color.FromArgb(139, 151, 145);
            WorstCaseBtn.FlatAppearance.BorderSize = 0;
            WorstCaseBtn.FlatStyle = FlatStyle.Flat;
            WorstCaseBtn.Font = new Font("Segoe UI Black", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            WorstCaseBtn.ForeColor = Color.FromArgb(190, 214, 217);
            WorstCaseBtn.Location = new Point(224, 257);
            WorstCaseBtn.Name = "WorstCaseBtn";
            WorstCaseBtn.Size = new Size(100, 47);
            WorstCaseBtn.TabIndex = 14;
            WorstCaseBtn.Text = "Pior";
            WorstCaseBtn.UseVisualStyleBackColor = false;
            WorstCaseBtn.Click += CaseBtn_Click;
            // 
            // AverageCaseBtn
            // 
            AverageCaseBtn.BackColor = Color.FromArgb(139, 151, 145);
            AverageCaseBtn.FlatAppearance.BorderSize = 0;
            AverageCaseBtn.FlatStyle = FlatStyle.Flat;
            AverageCaseBtn.Font = new Font("Segoe UI Black", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            AverageCaseBtn.ForeColor = Color.FromArgb(190, 214, 217);
            AverageCaseBtn.Location = new Point(118, 257);
            AverageCaseBtn.Name = "AverageCaseBtn";
            AverageCaseBtn.Size = new Size(100, 47);
            AverageCaseBtn.TabIndex = 13;
            AverageCaseBtn.Text = "Medio";
            AverageCaseBtn.UseVisualStyleBackColor = false;
            AverageCaseBtn.Click += CaseBtn_Click;
            // 
            // BestCaseBtn
            // 
            BestCaseBtn.BackColor = Color.FromArgb(139, 151, 145);
            BestCaseBtn.FlatAppearance.BorderSize = 0;
            BestCaseBtn.FlatStyle = FlatStyle.Flat;
            BestCaseBtn.Font = new Font("Segoe UI Black", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            BestCaseBtn.ForeColor = Color.FromArgb(190, 214, 217);
            BestCaseBtn.Location = new Point(12, 257);
            BestCaseBtn.Name = "BestCaseBtn";
            BestCaseBtn.Size = new Size(100, 47);
            BestCaseBtn.TabIndex = 12;
            BestCaseBtn.Text = "Melhor";
            BestCaseBtn.UseVisualStyleBackColor = false;
            BestCaseBtn.Click += CaseBtn_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(34, 60, 70);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = Color.Khaki;
            textBox7.Location = new Point(5, 198);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(332, 53);
            textBox7.TabIndex = 8;
            textBox7.Text = "Aviso: Números muito grandes podem não ser exibidos na saida.";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // FontSliderText
            // 
            FontSliderText.BackColor = Color.FromArgb(34, 60, 70);
            FontSliderText.BorderStyle = BorderStyle.None;
            FontSliderText.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FontSliderText.ForeColor = Color.FromArgb(190, 214, 217);
            FontSliderText.Location = new Point(3, 135);
            FontSliderText.Name = "FontSliderText";
            FontSliderText.Size = new Size(332, 26);
            FontSliderText.TabIndex = 6;
            FontSliderText.Text = "Tamanho da Fonte: 14";
            FontSliderText.TextAlign = HorizontalAlignment.Center;
            // 
            // SliderInputText
            // 
            SliderInputText.BackColor = Color.FromArgb(34, 60, 70);
            SliderInputText.BorderStyle = BorderStyle.None;
            SliderInputText.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SliderInputText.ForeColor = Color.FromArgb(190, 214, 217);
            SliderInputText.Location = new Point(3, 72);
            SliderInputText.Name = "SliderInputText";
            SliderInputText.Size = new Size(332, 26);
            SliderInputText.TabIndex = 3;
            SliderInputText.Text = "Qtd Números: 1000";
            SliderInputText.TextAlign = HorizontalAlignment.Center;
            // 
            // BackArrow_btn
            // 
            BackArrow_btn.BackColor = Color.Transparent;
            BackArrow_btn.BackgroundImage = Properties.Resources.BackArrow;
            BackArrow_btn.BackgroundImageLayout = ImageLayout.Stretch;
            BackArrow_btn.FlatAppearance.BorderSize = 0;
            BackArrow_btn.FlatStyle = FlatStyle.Flat;
            BackArrow_btn.Location = new Point(15, 11);
            BackArrow_btn.Name = "BackArrow_btn";
            BackArrow_btn.Size = new Size(45, 45);
            BackArrow_btn.TabIndex = 4;
            BackArrow_btn.UseVisualStyleBackColor = false;
            BackArrow_btn.Click += BackArrowBtn_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(34, 60, 70);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Black", 25.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(190, 214, 217);
            textBox2.Location = new Point(6, 9);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(335, 46);
            textBox2.TabIndex = 2;
            textBox2.Text = "Modifiers";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(34, 60, 70);
            panel4.Controls.Add(OutputText);
            panel4.Location = new Point(15, 424);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 164);
            panel4.TabIndex = 13;
            // 
            // OutputText
            // 
            OutputText.BackColor = Color.FromArgb(34, 60, 70);
            OutputText.BorderStyle = BorderStyle.None;
            OutputText.Font = new Font("Segoe UI Black", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            OutputText.ForeColor = Color.FromArgb(190, 214, 217);
            OutputText.Location = new Point(5, 3);
            OutputText.Multiline = true;
            OutputText.Name = "OutputText";
            OutputText.Size = new Size(755, 161);
            OutputText.TabIndex = 9;
            OutputText.Text = "Inicie uma Simulação...";
            OutputText.TextAlign = HorizontalAlignment.Center;
            // 
            // StatsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 600);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "StatsPage";
            Text = "StatsPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FontSizeSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberQuantitySlider).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox SortingCaseText;
        private TextBox textBox3;
        private TextBox SortingTitle;
        private Button BeginSimBtn;
        private Panel panel2;
        private TextBox StatsTitle;
        private Panel panel3;
        private TextBox SliderInputText;
        private Button BackArrow_btn;
        private TextBox textBox2;
        private Button WorstCaseBtn;
        private Button AverageCaseBtn;
        private Button BestCaseBtn;
        private TextBox textBox7;
        private TextBox FontSliderText;
        private Panel panel4;
        private TrackBar NumberQuantitySlider;
        private TrackBar FontSizeSlider;
        private TextBox OutputText;
        private TextBox BigOText;
        private TextBox MovesText;
        private TextBox StepsText;
        private TextBox ElapsedTimeText;
        private TextBox InputQuantityText;
    }
}