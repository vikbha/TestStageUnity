using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class Damage : ItemDecorator.ItemDecorator
    {
        int minDmg;
        int maxDmg;

        /// <summary>
        /// Add a damage range to the given item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="minDmg">minimun damage dealt</param>
        /// <param name="maxDmg">maximum damage dealt</param>
        public Damage(IItem item, int minDmg, int maxDmg) : base(item)
        {
            this.minDmg = minDmg;
            this.maxDmg = maxDmg;
            item.AddDescription(minDmg + " à " + maxDmg + " de dégats\n");
        }
    }
}
