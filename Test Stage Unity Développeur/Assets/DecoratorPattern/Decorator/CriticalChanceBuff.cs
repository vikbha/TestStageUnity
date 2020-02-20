using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class CriticalChanceBuff : ItemDecorator.ItemDecorator
    {
        int critBuff;

        /// <summary>
        /// Increase the % critical chance of the item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="critBuff">amount of critical chance</param>
        public CriticalChanceBuff(IItem item, int critBuff) : base(item)
        {
            this.critBuff = critBuff;
            item.AddDescription("+" + critBuff + "% de critique\n");
        }
    }
}
