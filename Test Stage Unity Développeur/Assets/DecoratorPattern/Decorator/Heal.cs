using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class Heal : ItemDecorator.ItemDecorator
    {
        int healAmount;

        /// <summary>
        /// Add a heal to the item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="healAmount">amount of healing given by the item</param>
        public Heal(IItem item, int healAmount) : base(item)
        {
            this.healAmount = healAmount;
            item.AddDescription("Soigne " + healAmount + " points de vie\n");
        }
    }
}
