using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeWork1
{
    public partial class Form1 : Form
    {
        private bool btn_Baku_WasClicked = true;
        private bool btn_London_WasClicked = false;
        public Form1()
        {
            InitializeComponent();
            EventsOn();
        }
        
        private void EventsOn()
        {
            SetBg();
            Timer();
        }

        private void Timer ()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(btn_Baku_WasClicked==true)
                llbl_timer.Text = DateTime.Now.ToString();
            else
                llbl_timer.Text = DateTime.Now.AddHours(-3).ToString();
        }

        private void SetBg()
        {
            Image image;
            if (btn_Baku_WasClicked == true)
                image = new Bitmap($@"C:\Users\User\source\repos\HomeWork1\HomeWork1\Background\Baku.jpg");
            else
                image= new Bitmap($@"C:\Users\User\source\repos\HomeWork1\HomeWork1\Background\London.jpg");
            BackgroundImage = image;
        }

        private void btn_London_Click(object sender, EventArgs e)
        {
            btn_London_WasClicked = true;
            btn_Baku_WasClicked = false;
            EventsOn();
        }

        private void btn_Baku_Click(object sender, EventArgs e)
        {
            btn_Baku_WasClicked = true;
            btn_London_WasClicked = false;
            EventsOn();
        }
    }
}
