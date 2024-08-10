namespace Calculator
{
    partial class MainForm
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.buttPlus = new System.Windows.Forms.Button();
            this.buttMinus = new System.Windows.Forms.Button();
            this.buttMultiply = new System.Windows.Forms.Button();
            this.butt1 = new System.Windows.Forms.Button();
            this.butt2 = new System.Windows.Forms.Button();
            this.butt3 = new System.Windows.Forms.Button();
            this.butt4 = new System.Windows.Forms.Button();
            this.butt5 = new System.Windows.Forms.Button();
            this.butt6 = new System.Windows.Forms.Button();
            this.butt7 = new System.Windows.Forms.Button();
            this.buttDiv = new System.Windows.Forms.Button();
            this.butt0 = new System.Windows.Forms.Button();
            this.buttC = new System.Windows.Forms.Button();
            this.buttResult = new System.Windows.Forms.Button();
            this.butt8 = new System.Windows.Forms.Button();
            this.butt9 = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.buttLoad = new System.Windows.Forms.Button();
            this.buttToggleTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultLabel.Size = new System.Drawing.Size(334, 100);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "0";
            // 
            // buttPlus
            // 
            this.buttPlus.BackColor = System.Drawing.Color.White;
            this.buttPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttPlus.Location = new System.Drawing.Point(91, 115);
            this.buttPlus.Name = "buttPlus";
            this.buttPlus.Size = new System.Drawing.Size(70, 70);
            this.buttPlus.TabIndex = 1;
            this.buttPlus.Text = "+";
            this.buttPlus.UseVisualStyleBackColor = false;
            this.buttPlus.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttMinus
            // 
            this.buttMinus.BackColor = System.Drawing.Color.White;
            this.buttMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttMinus.Location = new System.Drawing.Point(167, 115);
            this.buttMinus.Name = "buttMinus";
            this.buttMinus.Size = new System.Drawing.Size(70, 70);
            this.buttMinus.TabIndex = 2;
            this.buttMinus.Text = "-";
            this.buttMinus.UseVisualStyleBackColor = false;
            this.buttMinus.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttMultiply
            // 
            this.buttMultiply.BackColor = System.Drawing.Color.White;
            this.buttMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttMultiply.Location = new System.Drawing.Point(243, 115);
            this.buttMultiply.Name = "buttMultiply";
            this.buttMultiply.Size = new System.Drawing.Size(70, 70);
            this.buttMultiply.TabIndex = 3;
            this.buttMultiply.Text = "*";
            this.buttMultiply.UseVisualStyleBackColor = false;
            this.buttMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // butt1
            // 
            this.butt1.BackColor = System.Drawing.Color.White;
            this.butt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt1.Location = new System.Drawing.Point(15, 191);
            this.butt1.Name = "butt1";
            this.butt1.Size = new System.Drawing.Size(70, 70);
            this.butt1.TabIndex = 4;
            this.butt1.Text = "1";
            this.butt1.UseVisualStyleBackColor = false;
            this.butt1.Click += new System.EventHandler(this.button_Click);
            // 
            // butt2
            // 
            this.butt2.BackColor = System.Drawing.Color.White;
            this.butt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt2.Location = new System.Drawing.Point(91, 191);
            this.butt2.Name = "butt2";
            this.butt2.Size = new System.Drawing.Size(70, 70);
            this.butt2.TabIndex = 5;
            this.butt2.Text = "2";
            this.butt2.UseVisualStyleBackColor = false;
            this.butt2.Click += new System.EventHandler(this.button_Click);
            // 
            // butt3
            // 
            this.butt3.BackColor = System.Drawing.Color.White;
            this.butt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt3.Location = new System.Drawing.Point(167, 191);
            this.butt3.Name = "butt3";
            this.butt3.Size = new System.Drawing.Size(70, 70);
            this.butt3.TabIndex = 6;
            this.butt3.Text = "3";
            this.butt3.UseVisualStyleBackColor = false;
            this.butt3.Click += new System.EventHandler(this.button_Click);
            // 
            // butt4
            // 
            this.butt4.BackColor = System.Drawing.Color.White;
            this.butt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt4.Location = new System.Drawing.Point(15, 267);
            this.butt4.Name = "butt4";
            this.butt4.Size = new System.Drawing.Size(70, 70);
            this.butt4.TabIndex = 7;
            this.butt4.Text = "4";
            this.butt4.UseVisualStyleBackColor = false;
            this.butt4.Click += new System.EventHandler(this.button_Click);
            // 
            // butt5
            // 
            this.butt5.BackColor = System.Drawing.Color.White;
            this.butt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt5.Location = new System.Drawing.Point(91, 267);
            this.butt5.Name = "butt5";
            this.butt5.Size = new System.Drawing.Size(70, 70);
            this.butt5.TabIndex = 8;
            this.butt5.Text = "5";
            this.butt5.UseVisualStyleBackColor = false;
            this.butt5.Click += new System.EventHandler(this.button_Click);
            // 
            // butt6
            // 
            this.butt6.BackColor = System.Drawing.Color.White;
            this.butt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt6.Location = new System.Drawing.Point(167, 267);
            this.butt6.Name = "butt6";
            this.butt6.Size = new System.Drawing.Size(70, 70);
            this.butt6.TabIndex = 9;
            this.butt6.Text = "6";
            this.butt6.UseVisualStyleBackColor = false;
            this.butt6.Click += new System.EventHandler(this.button_Click);
            // 
            // butt7
            // 
            this.butt7.BackColor = System.Drawing.Color.White;
            this.butt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt7.Location = new System.Drawing.Point(15, 343);
            this.butt7.Name = "butt7";
            this.butt7.Size = new System.Drawing.Size(70, 70);
            this.butt7.TabIndex = 10;
            this.butt7.Text = "7";
            this.butt7.UseVisualStyleBackColor = false;
            this.butt7.Click += new System.EventHandler(this.button_Click);
            // 
            // buttDiv
            // 
            this.buttDiv.BackColor = System.Drawing.Color.White;
            this.buttDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttDiv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDiv.Location = new System.Drawing.Point(243, 191);
            this.buttDiv.Name = "buttDiv";
            this.buttDiv.Size = new System.Drawing.Size(70, 70);
            this.buttDiv.TabIndex = 11;
            this.buttDiv.Text = "/";
            this.buttDiv.UseVisualStyleBackColor = false;
            this.buttDiv.Click += new System.EventHandler(this.operator_Click);
            // 
            // butt0
            // 
            this.butt0.BackColor = System.Drawing.Color.White;
            this.butt0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt0.Location = new System.Drawing.Point(15, 115);
            this.butt0.Name = "butt0";
            this.butt0.Size = new System.Drawing.Size(70, 70);
            this.butt0.TabIndex = 12;
            this.butt0.Text = "0";
            this.butt0.UseVisualStyleBackColor = false;
            this.butt0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttC
            // 
            this.buttC.BackColor = System.Drawing.Color.White;
            this.buttC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttC.Location = new System.Drawing.Point(243, 267);
            this.buttC.Name = "buttC";
            this.buttC.Size = new System.Drawing.Size(70, 70);
            this.buttC.TabIndex = 13;
            this.buttC.Text = "C";
            this.buttC.UseVisualStyleBackColor = false;
            this.buttC.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttResult
            // 
            this.buttResult.BackColor = System.Drawing.Color.White;
            this.buttResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttResult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttResult.Location = new System.Drawing.Point(243, 343);
            this.buttResult.Name = "buttResult";
            this.buttResult.Size = new System.Drawing.Size(70, 70);
            this.buttResult.TabIndex = 14;
            this.buttResult.Text = "=";
            this.buttResult.UseVisualStyleBackColor = false;
            this.buttResult.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // butt8
            // 
            this.butt8.BackColor = System.Drawing.Color.White;
            this.butt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt8.Location = new System.Drawing.Point(91, 343);
            this.butt8.Name = "butt8";
            this.butt8.Size = new System.Drawing.Size(70, 70);
            this.butt8.TabIndex = 15;
            this.butt8.Text = "8";
            this.butt8.UseVisualStyleBackColor = false;
            this.butt8.Click += new System.EventHandler(this.button_Click);
            // 
            // butt9
            // 
            this.butt9.BackColor = System.Drawing.Color.White;
            this.butt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butt9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butt9.Location = new System.Drawing.Point(167, 343);
            this.butt9.Name = "butt9";
            this.butt9.Size = new System.Drawing.Size(70, 70);
            this.butt9.TabIndex = 16;
            this.butt9.Text = "9";
            this.butt9.UseVisualStyleBackColor = false;
            this.butt9.Click += new System.EventHandler(this.button_Click);
            // 
            // bttSave
            // 
            this.bttSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.ForeColor = System.Drawing.Color.Black;
            this.bttSave.Location = new System.Drawing.Point(15, 431);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(118, 36);
            this.bttSave.TabIndex = 17;
            this.bttSave.Text = "Сохранить";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // buttLoad
            // 
            this.buttLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttLoad.ForeColor = System.Drawing.Color.Black;
            this.buttLoad.Location = new System.Drawing.Point(139, 431);
            this.buttLoad.Name = "buttLoad";
            this.buttLoad.Size = new System.Drawing.Size(118, 36);
            this.buttLoad.TabIndex = 18;
            this.buttLoad.Text = "Загрузить";
            this.buttLoad.UseVisualStyleBackColor = true;
            this.buttLoad.Click += new System.EventHandler(this.buttLoad_Click);
            // 
            // buttToggleTheme
            // 
            this.buttToggleTheme.BackColor = System.Drawing.Color.Black;
            this.buttToggleTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttToggleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttToggleTheme.ForeColor = System.Drawing.Color.Black;
            this.buttToggleTheme.Location = new System.Drawing.Point(263, 431);
            this.buttToggleTheme.Name = "buttToggleTheme";
            this.buttToggleTheme.Size = new System.Drawing.Size(50, 36);
            this.buttToggleTheme.TabIndex = 19;
            this.buttToggleTheme.UseVisualStyleBackColor = false;
            this.buttToggleTheme.Click += new System.EventHandler(this.buttToggleTheme_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 479);
            this.Controls.Add(this.buttToggleTheme);
            this.Controls.Add(this.buttLoad);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.butt9);
            this.Controls.Add(this.butt8);
            this.Controls.Add(this.buttResult);
            this.Controls.Add(this.buttC);
            this.Controls.Add(this.butt0);
            this.Controls.Add(this.buttDiv);
            this.Controls.Add(this.butt7);
            this.Controls.Add(this.butt6);
            this.Controls.Add(this.butt5);
            this.Controls.Add(this.butt4);
            this.Controls.Add(this.butt3);
            this.Controls.Add(this.butt2);
            this.Controls.Add(this.butt1);
            this.Controls.Add(this.buttMultiply);
            this.Controls.Add(this.buttMinus);
            this.Controls.Add(this.buttPlus);
            this.Controls.Add(this.resultLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Claculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button buttPlus;
        private System.Windows.Forms.Button buttMinus;
        private System.Windows.Forms.Button buttMultiply;
        private System.Windows.Forms.Button butt1;
        private System.Windows.Forms.Button butt2;
        private System.Windows.Forms.Button butt3;
        private System.Windows.Forms.Button butt4;
        private System.Windows.Forms.Button butt5;
        private System.Windows.Forms.Button butt6;
        private System.Windows.Forms.Button butt7;
        private System.Windows.Forms.Button buttDiv;
        private System.Windows.Forms.Button butt0;
        private System.Windows.Forms.Button buttC;
        private System.Windows.Forms.Button buttResult;
        private System.Windows.Forms.Button butt8;
        private System.Windows.Forms.Button butt9;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button buttLoad;
        private System.Windows.Forms.Button buttToggleTheme;
    }
}

