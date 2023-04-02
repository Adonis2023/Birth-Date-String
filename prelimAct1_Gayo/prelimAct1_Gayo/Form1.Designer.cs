namespace prelimAct1_Gayo
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
            dayofWeekTextBox = new TextBox();
            monthtextBox = new TextBox();
            dayofMonthtextBox = new TextBox();
            yeartextBox = new TextBox();
            dayofweekpromptlabel1 = new Label();
            monthPromptlabel = new Label();
            dayofthemonthlabellabel1 = new Label();
            yearpromptlabel1 = new Label();
            showDatebutton = new Button();
            clearbutton = new Button();
            exitbutton1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // dayofWeekTextBox
            // 
            dayofWeekTextBox.Location = new Point(349, 71);
            dayofWeekTextBox.Name = "dayofWeekTextBox";
            dayofWeekTextBox.Size = new Size(325, 27);
            dayofWeekTextBox.TabIndex = 0;
            // 
            // monthtextBox
            // 
            monthtextBox.Location = new Point(349, 125);
            monthtextBox.Name = "monthtextBox";
            monthtextBox.Size = new Size(325, 27);
            monthtextBox.TabIndex = 1;
            // 
            // dayofMonthtextBox
            // 
            dayofMonthtextBox.Location = new Point(349, 180);
            dayofMonthtextBox.Name = "dayofMonthtextBox";
            dayofMonthtextBox.Size = new Size(325, 27);
            dayofMonthtextBox.TabIndex = 2;
            // 
            // yeartextBox
            // 
            yeartextBox.Location = new Point(349, 254);
            yeartextBox.Name = "yeartextBox";
            yeartextBox.Size = new Size(325, 27);
            yeartextBox.TabIndex = 3;
            // 
            // dayofweekpromptlabel1
            // 
            dayofweekpromptlabel1.AutoSize = true;
            dayofweekpromptlabel1.Location = new Point(150, 78);
            dayofweekpromptlabel1.Name = "dayofweekpromptlabel1";
            dayofweekpromptlabel1.Size = new Size(180, 20);
            dayofweekpromptlabel1.TabIndex = 4;
            dayofweekpromptlabel1.Text = "Enter the day of the week:";
            // 
            // monthPromptlabel
            // 
            monthPromptlabel.AutoSize = true;
            monthPromptlabel.Location = new Point(124, 128);
            monthPromptlabel.Name = "monthPromptlabel";
            monthPromptlabel.Size = new Size(202, 20);
            monthPromptlabel.TabIndex = 5;
            monthPromptlabel.Text = "Enter the name of the month:";
            // 
            // dayofthemonthlabellabel1
            // 
            dayofthemonthlabellabel1.AutoSize = true;
            dayofthemonthlabellabel1.Location = new Point(80, 183);
            dayofthemonthlabellabel1.Name = "dayofthemonthlabellabel1";
            dayofthemonthlabellabel1.Size = new Size(246, 20);
            dayofthemonthlabellabel1.TabIndex = 6;
            dayofthemonthlabellabel1.Text = "Enter the numeric day of the month:";
            // 
            // yearpromptlabel1
            // 
            yearpromptlabel1.AutoSize = true;
            yearpromptlabel1.Location = new Point(223, 257);
            yearpromptlabel1.Name = "yearpromptlabel1";
            yearpromptlabel1.Size = new Size(103, 20);
            yearpromptlabel1.TabIndex = 7;
            yearpromptlabel1.Text = "Enter the year:";
            yearpromptlabel1.Click += label1_Click_1;
            // 
            // showDatebutton
            // 
            showDatebutton.Location = new Point(160, 392);
            showDatebutton.Name = "showDatebutton";
            showDatebutton.Size = new Size(125, 52);
            showDatebutton.TabIndex = 11;
            showDatebutton.Text = "Show Date";
            showDatebutton.UseVisualStyleBackColor = true;
            showDatebutton.Click += showDatebutton_Click;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(322, 392);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(125, 52);
            clearbutton.TabIndex = 12;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += button1_Click;
            // 
            // exitbutton1
            // 
            exitbutton1.Location = new Point(500, 392);
            exitbutton1.Name = "exitbutton1";
            exitbutton1.Size = new Size(125, 52);
            exitbutton1.TabIndex = 13;
            exitbutton1.Text = "Exit";
            exitbutton1.UseVisualStyleBackColor = true;
            exitbutton1.Click += exitbutton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 330);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(562, 27);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(exitbutton1);
            Controls.Add(clearbutton);
            Controls.Add(showDatebutton);
            Controls.Add(textBox1);
            Controls.Add(yearpromptlabel1);
            Controls.Add(dayofthemonthlabellabel1);
            Controls.Add(monthPromptlabel);
            Controls.Add(dayofweekpromptlabel1);
            Controls.Add(yeartextBox);
            Controls.Add(dayofMonthtextBox);
            Controls.Add(monthtextBox);
            Controls.Add(dayofWeekTextBox);
            Name = "Form1";
            Text = " Birth Date String";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dayofWeekTextBox;
        private TextBox monthtextBox;
        private TextBox dayofMonthtextBox;
        private TextBox yeartextBox;
        private Label dayofweekpromptlabel1;
        private Label monthPromptlabel;
        private Label dayofthemonthlabellabel1;
        private Label yearpromptlabel1;
        private Button showDatebutton;
        private Button clearbutton;
        private Button exitbutton1;
        private TextBox textBox1;
    }
}