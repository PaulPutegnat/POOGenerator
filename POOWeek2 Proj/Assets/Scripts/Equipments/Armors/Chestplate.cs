using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Chestplate : Armor
{
    public Chestplate() : base()
    {
        EquipmentStructInfo = new StatEquipment("Armure : Daedric Armor", 50, 25, 300);
    }
}
