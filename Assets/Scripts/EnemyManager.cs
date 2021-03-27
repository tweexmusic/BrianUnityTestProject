﻿using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //instance variable name indicates a singleton inside the class.
    public static EnemyManager instance;

    public Enemy goombaPrefab;
    public Enemy koopaPrefab;
    public Enemy bobombPrefab;
    public Enemy hammerBroPrefab;

    public bool enemiesAlive;

    /// <summary>
    /// List that holds enemy game objects and keeps track of their individual stats.
    /// </summary>
    protected List<Enemy> enemiesList = new List<Enemy>();

    /// <summary>
    /// Populates enemiesList with all enemy game objects manually placed into scene.
    /// </summary>
    protected void PopulateEnemyList()
    {
        enemiesList.AddRange(FindObjectsOfType<Enemy>());
        enemiesAlive = true;
    }

    /// <summary>
    /// Spawns Goomba enemy game objects into the scene and adds them to the enemiesList.
    /// </summary>
    public void SpawnGoomba()
    {
        enemiesList.Add(Instantiate(goombaPrefab));
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

    /// <summary>
    /// Handles all enemies in the enemiesList taking damage.
    /// Determines if enemies are still alive or if all have been defeated.
    /// Modifies the enemiesList by removing indices and game objects if enemy health falls to 0.
    /// </summary>
    /// <param name="damage"></param>
    public void EnemyTakeDamageGlobal(int damage)
    {
        if (enemiesList.Count > 0)
        {
            enemiesList[0].EnemeyTakeDamage(damage);
        }

        foreach (Enemy enemy in enemiesList.ToArray())
        {
            if (enemy.enemyHealth <= 0)
            {
                enemiesList.Remove(enemy);
                Destroy(enemy.gameObject);
            }

            if (enemiesList.Count == 0)
            {
                Player.instance.inBattle = false;
                enemiesAlive = false;
                Debug.LogError("All enemies have been defeated!");
            }
        }
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(enemiesList.Count);
        }
    }
}
