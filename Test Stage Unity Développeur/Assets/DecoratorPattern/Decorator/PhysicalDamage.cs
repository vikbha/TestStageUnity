using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class PhysicalDamage : ItemDecorator.ItemDecorator
    {
        /// <summary>
        /// Add physical damage property to the item
        /// </summary>
        /// <param name="item"></param>
        public PhysicalDamage(IItem item) : base(item)
        {
            item.AddDescription("Inflige des dégats physiques\n");
        }
    }
}
