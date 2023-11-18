﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG.Entity.Character;
using Text_RPG.Items.Consumptions;
using Text_RPG.Items.Equipments;
using Text_RPG.Items;

namespace Text_RPG
{
    public class Player
    {
        // 캐릭터 3개
        public Character[] characters;
        // 인벤토리
        public Inventory inventory;
        // 진행정도
        public int progress;
        public int Progress { get { return progress; } set { progress = value; } }
        public Player()
        {
            characters = new Character[3];
            inventory = new Inventory();
            progress = 0;
        }
        public List<Item> GetInventoryItems(Item.ItemTypes type)
        {
            return inventory.GetInventoryItems(type);
        }

        public void AddItem(Item item)
        {
            inventory.AddItem(item);
        }
        public void SellItem(Item.ItemTypes type, int index)
        {
            inventory.SellItem(type, index);
        }
    }
}
