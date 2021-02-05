using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Warlock : Hero
{
    public Warlock() : base()
    {
        CharacterStructInfo = new StatCharacter("Eriana", 100, 100, 200);
    }
}