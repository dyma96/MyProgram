using System;

namespace _1calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupButton = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 238);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
           // this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 173);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(0, 0);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(200, 100);
            this.groupButton.TabIndex = 0;
            this.groupButton.TabStop = false;
            this.InitializeMyGroupBox();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(290, 280);
            this.MinimumSize = new System.Drawing.Size(290, 280);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private void InitializeMyGroupBox()
        {
            int numberButton = 15;
            System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[numberButton];
            for (int i = 0; i < numberButton; i++)
            {
                buttons[i] = new System.Windows.Forms.Button();
                buttons[i].Name = i.ToString();
                buttons[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
                buttons[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel2.Controls.Add(buttons[i], i % 5, i / 5);
                //buttons[i].Click += new System.EventHandler(this.OnButtonClick);
            }
            buttons[2].Text = "9";
            buttons[1].Text = "8";
            buttons[0].Text = "7";
            buttons[7].Text = "6";
            buttons[6].Text = "5";
            buttons[5].Text = "4";
            buttons[12].Text = "3";
            buttons[11].Text = "2";
            buttons[10].Text = "1";
            buttons[13].Text = "0";
            buttons[3].Text = "/";
            buttons[4].Text = "*";
            buttons[8].Text = "-";
            buttons[9].Text = "+";
            buttons[14].Text = "=";

            for (int i = 0; i < numberButton; i++)
                buttons[i].Click += ((object sender, EventArgs e)
                    => this.OnButtonClick((buttons[i].Text)[0]));
/*
            buttons[0].Click += ((object sender, EventArgs e)
                => this.OnButtonClick(buttons[0].Text[0]));
            buttons[1].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[1].Text)[0]));
            buttons[2].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[2].Text)[0]));
            buttons[3].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[3].Text)[0]));
            buttons[4].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[4].Text)[0]));
            buttons[5].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[5].Text)[0]));
            buttons[6].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[6].Text)[0]));
            buttons[7].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[7].Text)[0]));
            buttons[8].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[8].Text)[0]));
            buttons[9].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[9].Text)[0]));
            buttons[10].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[10].Text)[0]));
            buttons[11].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[11].Text)[0]));
            buttons[12].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[12].Text)[0]));
            buttons[13].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[13].Text)[0]));
            buttons[14].Click += ((object sender, EventArgs e)
                => this.OnButtonClick((buttons[14].Text)[0]));
  */          
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupButton;
    }
}

