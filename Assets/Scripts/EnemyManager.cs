using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //instance variable name indicates a singleton inside the class.
    public static EnemyManager instance;

    public Enemy goombaPrefab;
    public Enemy koopaPrefab;
    public Enemy bobombPrefab;

    //public string enemyName;

    protected List<Enemy> enemiesList = new List<Enemy>();
    protected int enemyCount = 1;

    void PopulateEnemyList()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            enemiesList.Add(Instantiate(goombaPrefab));
            enemiesList.Add(Instantiate(koopaPrefab));
            enemiesList.Add(Instantiate(bobombPrefab));
        }
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
    //Also handles if enemies are still alive or if all have been defeated.
    public void EnemyTakeDamage(int damage)
    {
        int enemyDeathCounter = 0;

        foreach (Enemy enemy in enemiesList)
        {
            enemy.EnemeyTakeDamage(damage);
            if (enemy.enemyHealth <= 0)
            {
                enemyDeathCounter++;
            }

            if (enemyDeathCounter >= enemiesList.Count)
            {
                Enemy.enemyAlive = false;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            goombaPrefab.EnemyAttack(3);

        }

        if (Input.GetKeyDown(KeyCode.K)) 
        {
            koopaPrefab.EnemyAttack(7);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            bobombPrefab.EnemyAttack(12);
        }
    }
}
