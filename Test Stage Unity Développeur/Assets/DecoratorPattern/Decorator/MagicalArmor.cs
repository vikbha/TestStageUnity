using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class MagicalArmor : ItemDecorator.ItemDecorator
    {
        int armor;

        /// <summary>
        /// Increase the item's magical armor
        /// </summary>
        /// <param name="item"></param>
        /// <param name="armor">amount of magical armor</param>
        public MagicalArmor(IItem item, int armor) : base(item)
        {
            this.armor = armor;
            item.AddDescription("+" + armor + " d'armure magique\n");
        }
    }
}
