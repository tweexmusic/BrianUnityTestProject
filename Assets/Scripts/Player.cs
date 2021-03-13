using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public EnemyManager enemyManagerPrefab;

    void DamageAllEnemies()
    {
        foreach (Enemy enemy in EnemyManager.instance.enemies)
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
        if (EnemyManager.instance == null)
        {
            EnemyManager.instance = Instantiate(enemyManagerPrefab);
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
