using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class TimedCritBuff : ItemDecorator.ItemDecorator
    {
        int critBuff;
        float duration;

        /// <summary>
        /// the item increases the critical chance for a set amount of time
        /// </summary>
        /// <param name="item"></param>
        /// <param name="critBuff">amount of increased critical chance</param>
        /// <param name="duration">duration of the buff in minutes</param>
        public TimedCritBuff(IItem item, int critBuff, float duration) : base(item)
        {
            this.critBuff = critBuff;
            this.duration = duration;
            item.AddDescription("+" + critBuff + "% de critique pendant " + duration + " minute\n");
        }
    }
}
