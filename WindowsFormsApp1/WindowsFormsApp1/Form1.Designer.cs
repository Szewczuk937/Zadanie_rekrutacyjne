
namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnReadIt = new System.Windows.Forms.Button();
            this.btnClearDB = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Welcome = new System.Windows.Forms.Label();
            this.Loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(713, 50);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(147, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Wczytaj tabele";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnReadIt
            // 
            this.btnReadIt.Location = new System.Drawing.Point(713, 79);
            this.btnReadIt.Name = "btnReadIt";
            this.btnReadIt.Size = new System.Drawing.Size(147, 23);
            this.btnReadIt.TabIndex = 2;
            this.btnReadIt.Text = "Wczytaj tebele Item";
            this.btnReadIt.UseVisualStyleBackColor = true;
            this.btnReadIt.Click += new System.EventHandler(this.btnReadIt_Click);
            // 
            // btnClearDB
            // 
            this.btnClearDB.Location = new System.Drawing.Point(714, 109);
            this.btnClearDB.Name = "btnClearDB";
            this.btnClearDB.Size = new System.Drawing.Size(146, 23);
            this.btnClearDB.TabIndex = 4;
            this.btnClearDB.Text = "Wyczyść DB";
            this.btnClearDB.UseVisualStyleBackColor = true;
            this.btnClearDB.Click += new System.EventHandler(this.btnClearDB_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 215);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(319, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(261, 174);
            this.Welcome.MaximumSize = new System.Drawing.Size(320, 130);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(254, 64);
            this.Welcome.TabIndex = 6;
            this.Welcome.Text = "Welcome";
            this.Welcome.Visible = false;
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loading.Location = new System.Drawing.Point(310, 241);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(85, 24);
            this.Loading.TabIndex = 7;
            this.Loading.Text = "Loading";
            this.Loading.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnClearDB);
            this.Controls.Add(this.btnReadIt);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReadIt;
        private System.Windows.Forms.Button btnClearDB;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label Loading;
    }
}

