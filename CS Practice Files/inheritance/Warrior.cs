using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Warrior : Player {

    //constructor for Warrior using inheritance from Player
    public Warrior()
    {

        //stats
        health = 100;
        power = 150;
        name = "Warrior";
    }

    public override void Attack()
    {
        Debug.Log("The warrior is attacking");
    }
}
