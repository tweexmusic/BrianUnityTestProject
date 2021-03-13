using UnityEngine;

public class Bobomb : Enemy
{
    public Bobomb()
    {
        enemyName = "Bobomb";
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log(enemyName + " explodes dealing " + damage + " damage to the player!");
        base.TakeDamage(damage);
    }
}