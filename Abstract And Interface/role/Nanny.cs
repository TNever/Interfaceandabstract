using Abstract_And_Interface.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Abstract_And_Interface.Abstract;

namespace Abstract_And_Interface.role
{
    public class Nanny : IAddBuff,IAddMilk
    {
        private AbstractAction action;

        public Nanny() { }

        public void Select(AbstractAction action)
        {
            this.action = action;
        }

        public void Go()
        {
            action.Action();
        }

        public void AddBuff()
        {
            Console.WriteLine("我给团体加Buff");
        }

        public void AddMilk()
        {
            Console.WriteLine("我给团体回血");
        }
    }
}
