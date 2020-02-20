using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class MagicalDamage : ItemDecorator.ItemDecorator
    {
        /// <summary>
        /// Add magical damage property to the item
        /// </summary>
        /// <param name="item"></param>
        public MagicalDamage(IItem item) : base(item)
        {
            item.AddDescription("Inflige des dégats magiques\n");
        }
    }
}
