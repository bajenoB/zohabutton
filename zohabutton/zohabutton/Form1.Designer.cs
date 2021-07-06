using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zohabutton
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Pen blackPen = new Pen(Color.Red, 0);
        Brush brush = new SolidBrush(Color.Red);
        Brush brush1 = new SolidBrush(Color.Green);

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";


            this.Paint += Form1_Paint;
            zoha = new Zoha(new Point(this.Width/2-100,this.Height/2));
            
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = CreateGraphics();
            
            
            g.FillRectangle(brush, zoha.rect);
            g.FillEllipse(brush1, zoha.circle);
            
            

            
        }
       
        public Zoha zoha;


        #endregion
    }
}

