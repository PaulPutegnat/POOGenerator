using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Sword : Weapon
{
    public Sword() : base()
    {
        EquipmentStructInfo = new StatEquipment("Arme : Master Sword", 150, 100, 50);
    }
}
