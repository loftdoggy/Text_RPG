﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG.Items.Consumptions
{
    internal abstract class Consumption : Item
    {
        protected ConsumptionTypes consumptionType;
        protected int itemCount;
       
        public Consumption()
        {
            itemType = ItemTypes.Consumption;
            itemCount = 1;
        }
        public enum ConsumptionTypes { None, HelthItem, BuffItem }
        public int ItemCount { get { return itemCount; } set {itemCount = value; } }
        public ConsumptionTypes ConsumptionType { get { return consumptionType; } }
    

        public abstract void UseItem();




    }
}