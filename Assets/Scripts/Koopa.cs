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
    }
}