using System;
using System.Collections.Generic;
using System.Text;

namespace _20220808
{
   public partial class Form1: Form1
    {
        public Form1()
        {
            InitializeComponent();

            //메서드명을 지정
            this.button1.Click += new System.EventHandler(this.button1_CLick);
            //무명메서드를 지정
            this.button2.Click += delegate (object s, EventArgs e)
            {
                MessageBox.show("버튼2 클릭");
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.show("버튼1 클릭");
        }
    }
    
}
