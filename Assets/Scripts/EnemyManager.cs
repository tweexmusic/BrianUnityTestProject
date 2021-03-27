using System.Collections.Generic;
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
	/// Spawns enemy game objects into the scene and adds them to the enemiesList.
	/// Parameter needs to be passed in as "EnemyManager.instance.[ENEMYNAME]Prefab"
	/// </summary>
	/// <param name="enemyPrefab"></param>
    public void SpawnEnemy(Enemy enemyPrefab)
    {
        enemiesList.Add(Instantiate(enemyPrefab));
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
            enemiesList[Random.Range(0, enemiesList.Count)].EnemeyTakeDamage(damage);
        }

        foreach (Enemy enemy in enemiesList.ToArray())
        {
            if (enemy.GetEnemyHealth() <= 0)
            {
                enemiesList.Remove(enemy);
                Destroy(enemy.gameObject);
            }

            if (enemiesList.Count == 0)
            {
                Player.instance.inBattle = false;
                enemiesAlive = false;
                Debug.LogError("You have successfully murdered all the natural inhabitants of this world...");
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
