﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorpion_skill1 : BaseAttack {

    public Scorpion_skill1()
    {
        attackName = "Scorpion Slash";
        attackDescription = "Use the water power to wash enemy's soul";

        attackDamage = 30f;
        attackCost = 10f;

    }
}