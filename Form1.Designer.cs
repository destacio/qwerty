﻿namespace qwerty
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
            this.pictureMap = new System.Windows.Forms.PictureBox();
            this.boxDescription = new System.Windows.Forms.Label();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureMap
            // 
            this.pictureMap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureMap.Location = new System.Drawing.Point(153, 0);
            this.pictureMap.Name = "pictureMap";
            this.pictureMap.Size = new System.Drawing.Size(1225, 792);
            this.pictureMap.TabIndex = 0;
            this.pictureMap.TabStop = false;
            this.pictureMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureMap_MouseClick);
            // 
            // boxDescription
            // 
            this.boxDescription.AutoSize = true;
            this.boxDescription.Enabled = false;
            this.boxDescription.Location = new System.Drawing.Point(12, 39);
            this.boxDescription.Name = "boxDescription";
            this.boxDescription.Size = new System.Drawing.Size(0, 13);
            this.boxDescription.TabIndex = 1;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(35, 237);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(75, 23);
            this.btnEndTurn.TabIndex = 2;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(32, 210);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(87, 13);
            this.lblTurn.TabIndex = 3;
            this.lblTurn.Text = "Ходит 1-й игрок";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.boxDescription);
            this.Controls.Add(this.pictureMap);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMap;
        private System.Windows.Forms.Label boxDescription;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label lblTurn;
    }
}

