﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG.Skill.Healer
{
    public class HealForAll : MultiSkill
    {
        public HealForAll(Entity.Entity owner) : base(owner)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
