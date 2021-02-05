using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Dagger : Weapon
{
    public Dagger() : base()
    {
        EquipmentStructInfo = new StatEquipment("Arme : Poisonous Dagger", 150, 100, 0);
    }
}
