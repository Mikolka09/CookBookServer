
namespace CookBookClient
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSendProducts = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountRecipes = new System.Windows.Forms.Label();
            this.buttonCloseConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(12, 326);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(136, 39);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключение";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxProducts
            // 
            this.textBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProducts.Location = new System.Drawing.Point(46, 30);
            this.textBoxProducts.Multiline = true;
            this.textBoxProducts.Name = "textBoxProducts";
            this.textBoxProducts.Size = new System.Drawing.Size(285, 31);
            this.textBoxProducts.TabIndex = 1;
            this.textBoxProducts.TextChanged += new System.EventHandler(this.textBoxProducts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перечень продуктов";
            // 
            // buttonSendProducts
            // 
            this.buttonSendProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSendProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendProducts.Location = new System.Drawing.Point(354, 24);
            this.buttonSendProducts.Name = "buttonSendProducts";
            this.buttonSendProducts.Size = new System.Drawing.Size(111, 39);
            this.buttonSendProducts.TabIndex = 3;
            this.buttonSendProducts.Text = "Отправить";
            this.buttonSendProducts.UseVisualStyleBackColor = false;
            this.buttonSendProducts.Click += new System.EventHandler(this.buttonSendProducts_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(419, 326);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(79, 39);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.HorizontalScrollbar = true;
            this.listBoxRecipes.ItemHeight = 16;
            this.listBoxRecipes.Location = new System.Drawing.Point(12, 101);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(486, 196);
            this.listBoxRecipes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(117, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Перечень полученных рецептов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(279, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во рецептов  - ";
            // 
            // labelCountRecipes
            // 
            this.labelCountRecipes.AutoSize = true;
            this.labelCountRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountRecipes.Location = new System.Drawing.Point(447, 300);
            this.labelCountRecipes.Name = "labelCountRecipes";
            this.labelCountRecipes.Size = new System.Drawing.Size(17, 18);
            this.labelCountRecipes.TabIndex = 8;
            this.labelCountRecipes.Text = "0";
            // 
            // buttonCloseConnect
            // 
            this.buttonCloseConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonCloseConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseConnect.Location = new System.Drawing.Point(173, 328);
            this.buttonCloseConnect.Name = "buttonCloseConnect";
            this.buttonCloseConnect.Size = new System.Drawing.Size(127, 39);
            this.buttonCloseConnect.TabIndex = 9;
            this.buttonCloseConnect.Text = "Отключение";
            this.buttonCloseConnect.UseVisualStyleBackColor = false;
            this.buttonCloseConnect.Click += new System.EventHandler(this.buttonCloseConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 379);
            this.Controls.Add(this.buttonCloseConnect);
            this.Controls.Add(this.labelCountRecipes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSendProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProducts);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendProducts;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountRecipes;
        private System.Windows.Forms.Button buttonCloseConnect;
    }
}

