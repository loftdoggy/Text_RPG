﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG.Items.Equipments.Protectives
{
    internal class Hat : Protective
    {
        public Hat()
        {
            m_protectiveType = ProtectiveType.Hat;

        }
        protected int m_defensivePower;

    }
}