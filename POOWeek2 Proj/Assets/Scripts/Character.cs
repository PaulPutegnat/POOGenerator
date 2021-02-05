using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string cryText = "A l'attaque";
    protected StatCharacter CharacterStructInfo;
    public Character() {}

    public virtual void BattleCry()
    {
        Debug.Log(cryText);
    }

    public StatCharacter GetCharacterInfo
    {
        get { return CharacterStructInfo; }
    }
}

    
