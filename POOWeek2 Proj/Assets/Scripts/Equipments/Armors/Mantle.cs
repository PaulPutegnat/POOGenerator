using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Mantle : Armor
{
    public Mantle() : base()
    {
        EquipmentStructInfo = new StatEquipment("Phoenix Robe", 0, 25, 200);
    }
}
