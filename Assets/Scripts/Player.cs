using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public EnemyManager enemyManagerPrefab;
    private EnemyManager enemyManagerInstance;

    void DamageAllEnemies()
    {
        foreach (Enemy enemy in enemyManagerInstance.enemies)
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

    // Start is called before the first frame update
    void Start()
    {
        enemyManagerInstance = FindObjectOfType<EnemyManager>();

        if (enemyManagerInstance == null)
        {
            enemyManagerInstance = Instantiate(enemyManagerPrefab);
            Debug.LogWarning("No EnemeyManager instance found in scene. Adding one automatically.  FIX IT STUPID!!!");
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            DamageAllEnemies();
        }
    }
}
