using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemInterface
{
    public interface IItem
    {
        string GetName();
        string GetDescription();
        void AddDescription(string description);
    } 
}