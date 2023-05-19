using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hourses.domain
{
    class Контроллер
    {
        public int count;
        public List<Кінь> horces;
        public Малювальник renderer;
        public ТаблицяРезультатів table;
        public Timer timer;

        public Контроллер(int count, List<Кінь> horces, Малювальник renderer, ТаблицяРезультатів table, Timer timer)
        {
            this.count = count;
            this.horces = horces;
            this.renderer = renderer;
            this.table = table;
            this.timer = timer;
        }

        public void draw()
        {
            
            List<Task> tasks = new List<Task>();           
            foreach (var horce in horces)
            {
                Task task = new Task(() => horce.changePosition(600, 1000));
                tasks.Add(task);
            }
            Task.WaitAll(tasks.ToArray());
            renderer.draw(horces);
        }
    }
}
