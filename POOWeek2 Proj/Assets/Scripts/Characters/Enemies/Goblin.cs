﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Goblin : Enemy
{
    public Goblin() : base()
    {
        CharacterStructInfo = new StatCharacter("Enemy : Farrath", 150, 50, 75);
    }
}