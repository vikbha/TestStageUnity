using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class MaxHealthBuff : ItemDecorator.ItemDecorator
    {
        int hpBuff;

        /// <summary>
        /// increase the item's max health
        /// </summary>
        /// <param name="item"></param>
        /// <param name="hpBuff">amount of max health increased by the item</param>
        public MaxHealthBuff(IItem item, int hpBuff) : base(item)
        {
            this.hpBuff = hpBuff;
            item.AddDescription("+" + hpBuff + " points de vie max\n");
        }
    }
}
