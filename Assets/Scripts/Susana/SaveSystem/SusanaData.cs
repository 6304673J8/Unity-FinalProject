using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SusanaData {
    //PLAYER STATUS
    //int level;
    public int health;
    public float[] position;
    
    //PLAYER INVENTORY
    public int potions;
    public int keys;
    public int bombs;

    public SusanaData (SusanaControlled susana)
    {
        //level = susana.level;
        health = susana.health;
        position = new float[3];
        position[0] = susana.transform.position.x;
        position[1] = susana.transform.position.y;
        position[2] = susana.transform.position.z;
        
        potions = susana.nPotions;
        keys = susana.nKeys;
        bombs = susana.nBombs;
    }
}
