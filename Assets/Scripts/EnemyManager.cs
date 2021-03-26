using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //instance variable name indicates a singleton inside the class.
    public static EnemyManager instance;

    public Enemy goombaPrefab;
    public Enemy koopaPrefab;
    public Enemy bobombPrefab;

    private Enemy spawnedGoomba;
    private Enemy spawnedKoopa;

    public bool enemiesAlive;

    protected List<Enemy> enemiesList = new List<Enemy>();
    protected int enemyCount = 1;


    protected void PopulateEnemyList()
    {
        spawnedGoomba = Instantiate(goombaPrefab);

        for (int i = 0; i < enemyCount; i++)
        {
            enemiesList.Add(spawnedGoomba);
            enemiesList.Add(Instantiate(koopaPrefab));
            enemiesList.Add(Instantiate(bobombPrefab));
        }

        enemiesAlive = true;
    }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        PopulateEnemyList();
    }

    //Handles all enemies in the enemiesList taking damage.
    //Determines if enemies are still alive or if all have been defeated.
    //Modifies the enemiesList and removes indices and game objects if enemy health falls to 0
    public void EnemyTakeDamage(int damage)
    {
        foreach (Enemy enemy in enemiesList.ToArray())
        {
            enemy.EnemeyTakeDamage(damage);
            if (enemy.enemyHealth <= 0)
            {
                enemy.enemyAlive = false;
                Destroy(enemy.gameObject);
                enemiesList.Remove(enemy);
            }

            if (enemiesList.Count == 0)
            {
                Player.instance.inBattle = false;
                enemiesAlive = false;
                Debug.LogError("All enemies have been defeated!");
            }
        }
    }
}
