using UnityEngine;

/// <summary>
/// Class that houses specifics of Goomba enemy.
/// Inherits from Enemy class.
/// </summary>

public class Goomba : Enemy
{
    //Constructor that defines enemy stats
    public Goomba()
    {
        enemyName = "Goomba";
        enemyHealth = 13;
        attackValue = 3;
        keyInput = KeyCode.G;
    }

    public override void EnemyAttack(int damage)
    {
        base.EnemyAttack(damage);
        FMODOneShotPlayer.instance.PlayOneShotSound(FMODEventConstants.GOOMBA_ATTACK);
    }
}