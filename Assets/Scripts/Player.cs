using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    public void PlayerTakeDamage(int enemyAttackDamage)
    {
        Debug.Log("Player takes " + enemyAttackDamage + " damage from " + EnemyManager.instance.enemyName);
    }

    void AttackAllEnemies()
    {
        FMODOneShotPlayer.instance.FMODPlayOneShotSound("event:/sfx/abilities/hamster_shoot");

        foreach (Enemy enemy in EnemyManager.instance.enemiesList)
        {

            if (enemy.enemyName == "Goomba")
            {
                enemy.EnemeyTakeDamage(99);
            }
            else
            {
                enemy.EnemeyTakeDamage(5);
            }
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
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AttackAllEnemies();
        }
    }
}
