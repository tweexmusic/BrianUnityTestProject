using UnityEngine;

public class Goomba : Enemy
{
    public Goomba()
    {
        enemyName = "Goomba";
    }

    public override void EnemyAttack(int damage)
    {
        Player.instance.PlayerTakeDamage(damage);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.GOOMBA_ATTACK);
        Debug.Log("Goomba deals " + damage + " damage to the player!");
    }

    public override void EnemyHealth()
    {
        enemyHealth = 13;
    }
}