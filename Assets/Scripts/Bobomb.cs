﻿using UnityEngine;

public class Bobomb : Enemy
{
    public Bobomb()
    {
        enemyName = "Bobomb";
    }

    public override void EnemeyTakeDamage(int damage)
    {
        base.EnemeyTakeDamage(damage);
        Debug.Log(enemyName + " explodes dealing " + damage + " damage to the player!");
    }

    public override void EnemyAttack(int damage)
    {
        Player.instance.PlayerTakeDamage(damage);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.BOBOMB_ATTACK);
        Debug.Log(enemyName + " deals " + damage + " to the player!");
    }
}