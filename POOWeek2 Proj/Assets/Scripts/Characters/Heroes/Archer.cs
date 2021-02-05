using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Archer : Hero
{
    public Archer() : base()
    {
        CharacterStructInfo = new StatCharacter("Legolas", 150, 75, 125);
    }
}
