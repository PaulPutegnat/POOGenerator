﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Shield : Armor
{
    public Shield() : base()
    {
        EquipmentStructInfo = new StatEquipment("Armure : Spike Shield", 150, 25, 200);
    }
}
