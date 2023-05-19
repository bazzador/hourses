using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using hourses.domain;

namespace hourses
{
    public partial class Form1 : Form
    {
        private Малювальник renderer;       
        private Контроллер controller;
        private ТаблицяРезультатів resultTable;       
        private int count;        
        public Form1()
        {
            InitializeComponent();

            renderer = new Малювальник(canvas);
            count = 5;
            resultTable = new ТаблицяРезультатів();
          

            controller = new Контроллер(count, Конюшня.ГенеруюКоней(count) , renderer, resultTable, timer);

            renderer.draw(controller.horces);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            controller.draw();
        }
    }
}
