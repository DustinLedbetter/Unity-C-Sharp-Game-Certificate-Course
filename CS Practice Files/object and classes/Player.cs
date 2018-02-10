using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//blueprint class for player object
public class Player {

    //character details
    int health;
    int power;
    string name;

    ////player constructor (class that has all stats already set)
    //public Player()
    //{
    //    health = 100;
    //    power = 150;
    //    name = "warrior";

    //    Debug.Log("Player created, Health: " + health + " Power: " + power + " Name: " + name);
    //}


    //player constructor (class that will need all stats provided at creation)
    public Player( int health, int power, string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;


    }

//this displays charater stats to console when executed
    public void Info()
    {
        Debug.Log("Player created, Health: " + this.health + " Power: " + this.power + " Name: " + this.name);
    }
}
