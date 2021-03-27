using UnityEngine;

/// <summary>
/// Class that houses specifics of Koopa enemy.
/// Inherits from Enemy class.
/// </summary>

public class Koopa : Enemy
{
    //Constructor that defines enemy stats
    public Koopa()
    {
        enemyName = "Koopa";
        enemyHealth = 35;
        attackValue = 7;
        keyInput = KeyCode.K;
    }

    public override void EnemyAttack(int damage)
    {
        base.EnemyAttack(damage);
        FMODOneShotPlayer.instance.PlayOneShotSound(FMODEventConstants.KOOPA_ATTACK);
    }
}