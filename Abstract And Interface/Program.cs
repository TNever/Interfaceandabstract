using Abstract_And_Interface.role;
using System;
using static Abstract_And_Interface.Abstract;

namespace Abstract_And_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化一个名叫小明的奶妈并进行加Buff和回血，顺便还打了一声招呼
            Nanny cat = new Nanny();
            Console.WriteLine("我是奶妈小明");
            cat.AddBuff();
            cat.AddMilk();
            cat.Select(new Call());
            cat.Go();

            Console.WriteLine("------------");

            // 实例化一个名叫小强的格斗家，先加个团体Buff，再攻击小怪
            Console.WriteLine("我是副C小强");
            Fighter SmallC = new Fighter();
            SmallC.AddBuff();
            SmallC.Select(new Attack());
            SmallC.Go();

            Console.WriteLine("------------");

            // 实例化一个主C小帅，先给自己加个Buff，然后打怪。
            Console.WriteLine("我是主C");
            Swordsman xuxubaobao = new Swordsman();
            xuxubaobao.AddBuff();
            xuxubaobao.Select(new Attack());
            xuxubaobao.Go();

        }
    }
}
