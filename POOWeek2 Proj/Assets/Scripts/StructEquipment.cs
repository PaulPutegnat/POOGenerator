using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct StatEquipment
{
    public string nom;
    public int physical_attack;
    public int magic_attack;
    public int defense;

    public StatEquipment(string nom, int physical_attack, int magic_attack, int defense)
    {
        this.nom = nom;
        this.physical_attack = physical_attack;
        this.magic_attack = magic_attack;
        this.defense = defense;
    }
}
