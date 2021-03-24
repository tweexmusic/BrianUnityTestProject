using UnityEngine;

public class Koopa : Enemy
{
    public Koopa()
    {
        enemyName = "Koopa";
    }

    public override void EnemyAttack(int damage)
    {
        Player.instance.PlayerTakeDamage(damage);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound("event:/sfx/abilities/hamster_grapple_shoot");
        Debug.Log("Koopa deals " + damage + " damage to the player!");
    }
}