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
        FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.KOOPA_ATTACK);
        Debug.Log("Koopa deals " + damage + " damage to the player!");
    }

    public override void EnemyHealth()
    {
        enemyHealth = 30;
    }
}