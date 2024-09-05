namespace course_2_semester_1_cs_winforms
{
    partial class MainForm
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
            SortingContainerPanel = new Panel();
            SortButton = new Button();
            MixButton = new Button();
            ManufacturerRadioButton = new RadioButton();
            SortParamLabel = new Label();
            BrandRadioButton = new RadioButton();
            CapacityRadioButton = new RadioButton();
            ShakerSortRadioButton = new RadioButton();
            BubbleSortRadioButton = new RadioButton();
            MethodLabel = new Label();
            DirectSortRadioButton = new RadioButton();
            ShellSortRadioButton = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SortingContainerPanel
            // 
            SortingContainerPanel.BackColor = Color.White;
            SortingContainerPanel.Location = new Point(12, 12);
            SortingContainerPanel.Name = "SortingContainerPanel";
            SortingContainerPanel.Size = new Size(860, 404);
            SortingContainerPanel.TabIndex = 0;
            SortingContainerPanel.Paint += SortingContainerPanel_Paint;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(12, 441);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(120, 30);
            SortButton.TabIndex = 1;
            SortButton.Text = "Отсортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // MixButton
            // 
            MixButton.Location = new Point(12, 479);
            MixButton.Name = "MixButton";
            MixButton.Size = new Size(120, 30);
            MixButton.TabIndex = 2;
            MixButton.Text = "Перемешать";
            MixButton.UseVisualStyleBackColor = true;
            MixButton.Click += MixButton_Click;
            // 
            // ManufacturerRadioButton
            // 
            ManufacturerRadioButton.AutoSize = true;
            ManufacturerRadioButton.Checked = true;
            ManufacturerRadioButton.Location = new Point(5, 26);
            ManufacturerRadioButton.Name = "ManufacturerRadioButton";
            ManufacturerRadioButton.Size = new Size(114, 19);
            ManufacturerRadioButton.TabIndex = 3;
            ManufacturerRadioButton.TabStop = true;
            ManufacturerRadioButton.Text = "Производителю";
            ManufacturerRadioButton.UseVisualStyleBackColor = true;
            ManufacturerRadioButton.CheckedChanged += ManufacturerRadioButton_CheckedChanged;
            // 
            // SortParamLabel
            // 
            SortParamLabel.AutoSize = true;
            SortParamLabel.Location = new Point(3, 8);
            SortParamLabel.Name = "SortParamLabel";
            SortParamLabel.Size = new Size(116, 15);
            SortParamLabel.TabIndex = 4;
            SortParamLabel.Text = "Отсортировать по...";
            // 
            // BrandRadioButton
            // 
            BrandRadioButton.AutoSize = true;
            BrandRadioButton.Location = new Point(5, 51);
            BrandRadioButton.Name = "BrandRadioButton";
            BrandRadioButton.Size = new Size(61, 19);
            BrandRadioButton.TabIndex = 5;
            BrandRadioButton.Text = "Марке";
            BrandRadioButton.UseVisualStyleBackColor = true;
            BrandRadioButton.CheckedChanged += BrandRadioButton_CheckedChanged;
            // 
            // CapacityRadioButton
            // 
            CapacityRadioButton.AutoSize = true;
            CapacityRadioButton.Location = new Point(5, 76);
            CapacityRadioButton.Name = "CapacityRadioButton";
            CapacityRadioButton.Size = new Size(71, 19);
            CapacityRadioButton.TabIndex = 6;
            CapacityRadioButton.Text = "Емкости";
            CapacityRadioButton.UseVisualStyleBackColor = true;
            CapacityRadioButton.CheckedChanged += CapacityRadioButton_CheckedChanged;
            // 
            // ShakerSortRadioButton
            // 
            ShakerSortRadioButton.AutoSize = true;
            ShakerSortRadioButton.Location = new Point(5, 75);
            ShakerSortRadioButton.Name = "ShakerSortRadioButton";
            ShakerSortRadioButton.Size = new Size(154, 19);
            ShakerSortRadioButton.TabIndex = 10;
            ShakerSortRadioButton.Text = "Шейкерная сортировка";
            ShakerSortRadioButton.UseVisualStyleBackColor = true;
            ShakerSortRadioButton.CheckedChanged += ShakerSortRadioButton_CheckedChanged;
            // 
            // BubbleSortRadioButton
            // 
            BubbleSortRadioButton.AutoSize = true;
            BubbleSortRadioButton.Location = new Point(5, 50);
            BubbleSortRadioButton.Name = "BubbleSortRadioButton";
            BubbleSortRadioButton.Size = new Size(165, 19);
            BubbleSortRadioButton.TabIndex = 9;
            BubbleSortRadioButton.Text = "Пузырьковая сортировка";
            BubbleSortRadioButton.UseVisualStyleBackColor = true;
            BubbleSortRadioButton.CheckedChanged += BubbleSortRadioButton_CheckedChanged;
            // 
            // MethodLabel
            // 
            MethodLabel.AutoSize = true;
            MethodLabel.Location = new Point(3, 7);
            MethodLabel.Name = "MethodLabel";
            MethodLabel.Size = new Size(110, 15);
            MethodLabel.TabIndex = 8;
            MethodLabel.Text = "Метод сортировки";
            // 
            // DirectSortRadioButton
            // 
            DirectSortRadioButton.AutoSize = true;
            DirectSortRadioButton.Checked = true;
            DirectSortRadioButton.Location = new Point(5, 25);
            DirectSortRadioButton.Name = "DirectSortRadioButton";
            DirectSortRadioButton.Size = new Size(187, 19);
            DirectSortRadioButton.TabIndex = 7;
            DirectSortRadioButton.TabStop = true;
            DirectSortRadioButton.Text = "Сортировка прямого выбора";
            DirectSortRadioButton.UseVisualStyleBackColor = true;
            DirectSortRadioButton.CheckedChanged += DirectSortRadioButton_CheckedChanged;
            // 
            // ShellSortRadioButton
            // 
            ShellSortRadioButton.AutoSize = true;
            ShellSortRadioButton.Location = new Point(5, 100);
            ShellSortRadioButton.Name = "ShellSortRadioButton";
            ShellSortRadioButton.Size = new Size(131, 19);
            ShellSortRadioButton.TabIndex = 11;
            ShellSortRadioButton.Text = "Сортировка Шелла";
            ShellSortRadioButton.UseVisualStyleBackColor = true;
            ShellSortRadioButton.CheckedChanged += ShellSortRadioButton_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(MethodLabel);
            panel1.Controls.Add(ShellSortRadioButton);
            panel1.Controls.Add(DirectSortRadioButton);
            panel1.Controls.Add(ShakerSortRadioButton);
            panel1.Controls.Add(BubbleSortRadioButton);
            panel1.Location = new Point(315, 434);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 126);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(SortParamLabel);
            panel2.Controls.Add(ManufacturerRadioButton);
            panel2.Controls.Add(CapacityRadioButton);
            panel2.Controls.Add(BrandRadioButton);
            panel2.Location = new Point(171, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(138, 100);
            panel2.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(MixButton);
            Controls.Add(SortButton);
            Controls.Add(SortingContainerPanel);
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            Text = "Сортировка блоков питания";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SortingContainerPanel;
        private Button SortButton;
        private Button MixButton;
        private RadioButton ManufacturerRadioButton;
        private Label SortParamLabel;
        private RadioButton BrandRadioButton;
        private RadioButton CapacityRadioButton;
        private RadioButton ShakerSortRadioButton;
        private RadioButton BubbleSortRadioButton;
        private Label MethodLabel;
        private RadioButton DirectSortRadioButton;
        private RadioButton ShellSortRadioButton;
        private Panel panel1;
        private Panel panel2;
    }
}
