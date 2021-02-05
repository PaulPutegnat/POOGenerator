using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Warlock : Hero
{
    public Warlock() : base()
    {
        CharacterStructInfo = new StatCharacter("Hero : Eriana", 100, 100, 200);
    }
}