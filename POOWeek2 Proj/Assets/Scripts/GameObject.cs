using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    public Character cryText = new Character();
    public Character cryEnemy = new Enemy();
    public Character cryHero = new Hero();
    void Start()
    {
        cryHero.cryText = "Pour l'alliance!";
        cryEnemy.cryText = "Pour la Horde!";
        Character currentCharacter = new Orc();
        Equipment currentEquipment = new Staff();
        Debug.Log(currentCharacter.GetCharacterInfo.nom);
        Debug.Log(currentCharacter.GetCharacterInfo.vie);
        Debug.Log(currentEquipment.getEquipmentInfo.nom);
        cryText.BattleCry();
        cryEnemy.BattleCry();
        cryHero.BattleCry();
    }
}
