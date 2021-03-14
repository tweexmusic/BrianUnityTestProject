using UnityEngine;

public class Koopa : Enemy
{
    public Koopa()
    {
        enemyName = "Koopa";
    }

    public override void EnemyAttack()
    {
        Player.instance.PlayerTakeDamage(7);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound("event:/sfx/abilities/hamster_grapple_shoot");
    }
}