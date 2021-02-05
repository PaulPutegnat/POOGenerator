using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Troll : Enemy
{
    public Troll() : base()
    {
        CharacterStructInfo = new StatCharacter("Buraat", 500, 200, 50);
    }
}
