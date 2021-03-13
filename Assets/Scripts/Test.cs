using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Enemy goombaPrefab;
    public Enemy koopaPrefab;
    public Enemy bobombPrefab;

    public static List<Enemy> enemies = new List<Enemy>();
    private int enemyCount = 1;

    private void Awake()
    {
        Debug.Log("PRESS 'A' TO ATTACK!");

        void PopulateEnemyList()
        {
            for (int i = 0; i < enemyCount; i++)
            {
                enemies.Add(Instantiate(goombaPrefab));
                enemies.Add(Instantiate(koopaPrefab));
                enemies.Add(Instantiate(bobombPrefab));
            }
            enemies.AddRange(FindObjectsOfType<Enemy>());
        }

        PopulateEnemyList();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //Homework for Brian! Do this in an awake function so it happens before the player tries to attack
    //BRIAN: DONE!


    //Homework for Brian! Make a player class, and move this function into their start function!
    //BRIAN: I actually put the DamageAllEnemies() function outside the start function.
    //BRIAN: I called DamageAllEnemies() in the update function using an if statement to determine if the player is pressing "A"

    //BRIAN: I also created a new Player prefab in the Unity editor and attached the PlayerController script to it.
}
