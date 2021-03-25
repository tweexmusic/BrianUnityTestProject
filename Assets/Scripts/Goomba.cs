using UnityEngine;

/// <summary>
/// Class that houses specifics of Goomba enemy.
/// Inherits from Enemy class.
/// </summary>

public class Goomba : Enemy
{

    //Constructor that defines enemy name
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