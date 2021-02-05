using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    protected StatEquipment EquipmentStructInfo;
    public Equipment()
    {

    }

    public StatEquipment getEquipmentInfo
    {
        get { return EquipmentStructInfo; }
    }
}