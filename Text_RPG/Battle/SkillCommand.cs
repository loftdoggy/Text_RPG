﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_RPG.Entity.Character;
using Text_RPG.Entity.Monster;
using Text_RPG.Skill;

namespace Text_RPG.Battle
{
    public class SkillCommand : Command
    {
        public Character character;
        public Skill.Skill skill;
        public Monster monster;

        public SkillCommand(Character character, Skill.Skill skill)
        {
            this.character = character;
            this.skill = skill;
            this.priority = skill.priority;
        }

        public SkillCommand(Monster monster, Skill.Skill skill)
        {
            this.monster = monster;
            this.skill = skill;
            this.priority = skill.priority;
        }

        public override void Execute()
        {
            skill.Execute();
        }
    }
}
