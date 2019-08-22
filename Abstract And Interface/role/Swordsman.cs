using Abstract_And_Interface.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Abstract_And_Interface.Abstract;

namespace Abstract_And_Interface.role
{
    public class Swordsman : IAddBuff
    {
        private AbstractAction action;

        public Swordsman() { }

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
            Console.WriteLine("我只给自己加Buff");
        }
    }
}
