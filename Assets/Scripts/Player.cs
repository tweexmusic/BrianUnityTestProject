using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that handles player actions and behaviors.
/// SINGLETON
/// </summary>

public class Player : MonoBehaviour
{
    public static Player instance;

    public bool inBattle;
    public int playerHealth;

    //Manages player health value calculations when taking damage.
    public void PlayerTakeDamage(int enemyAttackDamage)
    {
        playerHealth = playerHealth - enemyAttackDamage;

        if(playerHealth > 0)
        {
            Debug.Log("Player takes " + enemyAttackDamage + " damage and has " + playerHealth + " health remaining!");
        }

        if (playerHealth <= 0)
        {
            FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.PLAYER_DEATH);
            Debug.LogError("Player takes " + enemyAttackDamage + " damage and dies!");
            inBattle = false;
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

        playerHealth = 300;
    }

    //Handles player's shoot attack. Attack value is set when calling this function and that value is passed as parameter to EnemyTakeDamage()
    public void PlayerAttackShoot(int damage)
    {
        FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.PLAYER_SHOOT);
        EnemyManager.instance.EnemyTakeDamage(damage);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && playerHealth > 0)
        {
            PlayerAttackShoot(6);
        }
    }
}
