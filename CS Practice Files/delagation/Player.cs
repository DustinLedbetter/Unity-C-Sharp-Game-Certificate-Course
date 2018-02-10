using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//blueprint class for player object
public class Player
{

    //static items can be called in other clases without creating variables to hold them.
    //just access in main by using "class.whatusing"


    //character properties
    public static int health;
    public static int power;
    public static string name;


    //player constructor (has nothing passed to it)
    public Player()
    {
        //set properties
        health = 150;
        power = 100;
        name = "warrior";

    }

    //static function
    public static void printSomething()
    {

    }

}
