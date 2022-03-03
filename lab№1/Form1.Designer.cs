
namespace lab_1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMatrix = new System.Windows.Forms.Button();
            this.buttonReplaceStr = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonMatrix);
            this.panelMenu.Controls.Add(this.buttonReplaceStr);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(334, 59);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonMatrix
            // 
            this.buttonMatrix.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatrix.Location = new System.Drawing.Point(167, 0);
            this.buttonMatrix.Name = "buttonMatrix";
            this.buttonMatrix.Size = new System.Drawing.Size(167, 59);
            this.buttonMatrix.TabIndex = 1;
            this.buttonMatrix.Text = "Сортировка матрицы";
            this.buttonMatrix.UseVisualStyleBackColor = false;
            this.buttonMatrix.Click += new System.EventHandler(this.buttonMatrix_Click);
            // 
            // buttonReplaceStr
            // 
            this.buttonReplaceStr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonReplaceStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplaceStr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReplaceStr.Location = new System.Drawing.Point(0, 0);
            this.buttonReplaceStr.Name = "buttonReplaceStr";
            this.buttonReplaceStr.Size = new System.Drawing.Size(167, 59);
            this.buttonReplaceStr.TabIndex = 0;
            this.buttonReplaceStr.Text = "Удаление подстроки";
            this.buttonReplaceStr.UseVisualStyleBackColor = false;
            this.buttonReplaceStr.Click += new System.EventHandler(this.buttonReplaceStr_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(0, 59);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(334, 213);
            this.panelDesktopPane.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 272);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(350, 310);
            this.MinimumSize = new System.Drawing.Size(350, 310);
            this.Name = "Form1";
            this.Text = "Б9119-09.03.04прогин-лр1-Новикова Анна";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMatrix;
        private System.Windows.Forms.Button buttonReplaceStr;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

