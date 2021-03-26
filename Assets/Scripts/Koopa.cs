﻿using UnityEngine;

/// <summary>
/// Class that houses specifics of Koopa enemy.
/// Inherits from Enemy class.
/// </summary>

public class Koopa : Enemy
{
    //Constructor that defines enemy name
    public Koopa()
    {
        enemyName = "Koopa";
    }

    public override void EnemyAttack(int damage)
    {
        base.EnemyAttack(damage);
        Player.instance.PlayerTakeDamage(damage);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.KOOPA_ATTACK);
        Debug.Log(enemyName + " deals " + damage + " damage to the player!");
    }

    public override void EnemyHealth()
    {
        enemyHealth = 35;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            EnemyAttack(7);
        }
    }
}