using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace Decorator
{
    public class PhysicalArmor : ItemDecorator.ItemDecorator
    {
        int armor;
        
        /// <summary>
        /// Increase the item's physical armor
        /// </summary>
        /// <param name="item"></param>
        /// <param name="armor">amount of physical armor</param>
        public PhysicalArmor(IItem item, int armor) : base(item)
        {
            this.armor = armor;
            item.AddDescription("+" + armor + " d'armure physique\n");
        }
    }
}
