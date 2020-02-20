using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemInterface;

namespace ItemClass
{
    public class Item : IItem
    {
        string name;
        string description;

        /// <summary>
        /// base item class
        /// </summary>
        /// <param name="name"></param>
        public Item(string name)
        {
            this.name = name;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetName()
        {
            return name;
        }

        public void AddDescription(string description)
        {
            this.description += description;
        }
    }
}
