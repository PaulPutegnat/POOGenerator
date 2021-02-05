using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Orc : Enemy
{
    public Orc() : base()
    {
        CharacterStructInfo = new StatCharacter("Kthuluh", 300, 100, 25);
    }
}
