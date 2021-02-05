using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    void Start()
    {
        Character currentCharacter = new Warlock();
        Equipment currentEquipment = new Staff();
        Debug.Log(currentCharacter.getCharacterInfo.nom);
        Debug.Log(currentCharacter.getCharacterInfo.vie);
        Debug.Log(currentEquipment.getEquipmentInfo.nom);
        Debug.Log(currentEquipment.getEquipmentInfo.physical_attack);
    }
}
