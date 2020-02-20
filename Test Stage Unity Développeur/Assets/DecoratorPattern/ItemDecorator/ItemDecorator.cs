using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace ItemDecorator
{
    public abstract class ItemDecorator : IItem
    {
        protected IItem item;

        public ItemDecorator(IItem item)
        {
            this.item = item;
        }

        /// <summary>
        /// returns the item's name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return item.GetName();
        }

        /// <summary>
        /// return the item's description
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return item.GetDescription();
        }

        /// <summary>
        /// add a property to the item
        /// </summary>
        /// <param name="description"></param>
        public void AddDescription(string description)
        {
            item.AddDescription(description);
        }
    }
}