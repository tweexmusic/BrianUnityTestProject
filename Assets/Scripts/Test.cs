using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Enemy goombaPrefab;
    public Enemy koopaPrefab;
    public Enemy bobombPrefab;

    private List<Enemy> enemies = new List<Enemy>();
    private int enemyCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        PopulateEnemyList();
        DamageAllEnemies();
    }

    //Homework for Brian! Do this in an awake function so it happens before the player tries to attack
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

    //Homework for Brian! Make a player class, and move this function into their start function!
    void DamageAllEnemies()
    {
        foreach (Enemy enemy in enemies)
        {
            if (enemy.enemyName == "Goomba")
            {
                enemy.TakeDamage(99);
            }
            else
            {
                enemy.TakeDamage(5);
            }
        }
    }
}
