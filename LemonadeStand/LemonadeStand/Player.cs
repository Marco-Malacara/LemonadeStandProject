﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public Inventory inventory;
        public Cash cash;
        public Recipe recipe;

    public Player()
        {
            inventory = new Inventory();
            cash = new Cash();
            recipe = new Recipe();
        }
    }
}
