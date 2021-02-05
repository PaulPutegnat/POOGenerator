using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Archer : Hero
{
    public Archer() : base()
    {
        CharacterStructInfo = new StatCharacter("Hero : Legolas", 150, 75, 125);
    }
}
