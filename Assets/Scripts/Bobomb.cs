using UnityEngine;

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

    public override void EnemyAttack()
    {
            Player.instance.PlayerTakeDamage(12);
    }
}