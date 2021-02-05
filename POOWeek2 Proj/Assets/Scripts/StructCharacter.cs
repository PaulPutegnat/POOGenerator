using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct StatCharacter
{
    public string nom;
    public int vie;
    public int defense;
    public int attack;

    public StatCharacter(string nom, int vie, int defense, int attack)
    {
        this.nom = nom;
        this.vie = vie;
        this.defense = defense;
        this.attack = attack;
    }
}
