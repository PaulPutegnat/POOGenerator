using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Staff : Weapon
{
    public Staff() : base()
    {
        EquipmentStructInfo = new StatEquipment("Necromancer Staff", 25, 200, 75);
    }
}
