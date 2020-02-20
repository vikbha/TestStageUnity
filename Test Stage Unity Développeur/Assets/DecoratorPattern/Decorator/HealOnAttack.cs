using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class HealOnAttack : ItemDecorator.ItemDecorator
    {
        int healOnHitAmount;

        /// <summary>
        /// Damaging enemy heals a certain amount
        /// </summary>
        /// <param name="item"></param>
        /// <param name="healOnHitAmount">amount healed on hit</param>
        public HealOnAttack(IItem item, int healOnHitAmount) : base(item)
        {
            this.healOnHitAmount = healOnHitAmount;
            item.AddDescription("Soigne " + healOnHitAmount + " points de vie par attaque\n");
        }
    }
}
