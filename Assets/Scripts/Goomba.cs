using UnityEngine;

public class Goomba : Enemy
{
    public Goomba()
    {
        enemyName = "Goomba";
    }

    public override void EnemyAttack()
    {
            Player.instance.PlayerTakeDamage(3);
    }
}