namespace Lab5_2
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
            this.components = new System.ComponentModel.Container();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.tmrSecundomer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.Sbros = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(24, 25);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(134, 24);
            this.txtSeconds.TabIndex = 0;
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(352, 23);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(128, 24);
            this.txtMinutes.TabIndex = 1;
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrSecundomer
            // 
            this.tmrSecundomer.Interval = 1000;
            this.tmrSecundomer.Tick += new System.EventHandler(this.tmrSecundomer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Nelda Free", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(352, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Sbros
            // 
            this.Sbros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sbros.Location = new System.Drawing.Point(180, 99);
            this.Sbros.Name = "Sbros";
            this.Sbros.Size = new System.Drawing.Size(147, 31);
            this.Sbros.TabIndex = 3;
            this.Sbros.Text = "Сброс";
            this.Sbros.UseVisualStyleBackColor = true;
            this.Sbros.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(11, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Текущее время";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "сек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(485, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "мин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sbros);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtSeconds);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Секундомер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSeconds;
        private TextBox txtMinutes;
        private System.Windows.Forms.Timer tmrSecundomer;
        private Button btnStart;
        private Button Sbros;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}