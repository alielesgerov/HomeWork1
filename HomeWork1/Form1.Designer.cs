
namespace HomeWork1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_London = new System.Windows.Forms.Button();
            this.btn_Baku = new System.Windows.Forms.Button();
            this.llbl_timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_London
            // 
            this.btn_London.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_London.Location = new System.Drawing.Point(70, 400);
            this.btn_London.Name = "btn_London";
            this.btn_London.Size = new System.Drawing.Size(130, 40);
            this.btn_London.TabIndex = 0;
            this.btn_London.Text = "London";
            this.btn_London.UseVisualStyleBackColor = true;
            this.btn_London.Click += new System.EventHandler(this.btn_London_Click);
            // 
            // btn_Baku
            // 
            this.btn_Baku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baku.Location = new System.Drawing.Point(600, 400);
            this.btn_Baku.Name = "btn_Baku";
            this.btn_Baku.Size = new System.Drawing.Size(130, 40);
            this.btn_Baku.TabIndex = 1;
            this.btn_Baku.Text = "Baku";
            this.btn_Baku.UseVisualStyleBackColor = true;
            this.btn_Baku.Click += new System.EventHandler(this.btn_Baku_Click);
            // 
            // llbl_timer
            // 
            this.llbl_timer.AutoSize = true;
            this.llbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_timer.Location = new System.Drawing.Point(288, 400);
            this.llbl_timer.Name = "llbl_timer";
            this.llbl_timer.Size = new System.Drawing.Size(199, 25);
            this.llbl_timer.TabIndex = 2;
            this.llbl_timer.Text = "27-sep-20 19:60:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llbl_timer);
            this.Controls.Add(this.btn_Baku);
            this.Controls.Add(this.btn_London);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_London;
        private System.Windows.Forms.Button btn_Baku;
        private System.Windows.Forms.Label llbl_timer;
    }
}

