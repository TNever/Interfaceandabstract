using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_And_Interface
{
    public class Abstract
    {
        public abstract class AbstractAction
        {
            public abstract void Action();
        }

        public class Move : AbstractAction
        {
            public override void Action()
            {
                // 英雄移动
                Console.WriteLine("正在移动");
            }
        }

        public class Attack : AbstractAction
        {
            public override void Action()
            {
                // 英雄攻击
                Console.WriteLine("开始打怪");
            }
        }

        public class Call : AbstractAction
        {
            public override void Action()
            {
                // 聊天
                Console.WriteLine("Hi、妹子...");
            }
        }
    }
}
