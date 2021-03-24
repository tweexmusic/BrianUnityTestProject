using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    public void PlayerTakeDamage(int enemyAttackDamage)
    {
        //Debug.Log("Player takes " + enemyAttackDamage + " damage from " + EnemyManager.instance);
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

    //Handles player's shoot attack. Attack value is set in this function and that value is passed as parameter to EnemyTakeDamage()
    public void PlayerAttackShoot(int damage)
    {
        FMODOneShotPlayer.instance.FMODPlayOneShotSound("event:/sfx/abilities/hamster_shoot");
        EnemyManager.instance.EnemyTakeDamage(damage);
        //Debug.Log("Player deals " + damage + " damage to " + );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerAttackShoot(6);
        }
    }
}
