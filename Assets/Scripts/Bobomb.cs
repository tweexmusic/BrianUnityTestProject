using UnityEngine;

/// <summary>
/// Class that houses specifics of Bobomb enemy.
/// Inherits from Enemy class.
/// </summary>

public class Bobomb : Enemy
{
    //Constructor that defines enemy stats
    public Bobomb()
    {
        enemyName = "Bobomb";
        attackValue = 12;
        keyInput = KeyCode.B;
    }

    public override void EnemyAttack(int damage)
    {
        base.EnemyAttack(damage);
        FMODOneShotPlayer.instance.PlayOneShotSound(FMODEventConstants.BOBOMB_ATTACK);
    }

    public override void EnemeyTakeDamage(int damage)
    {
        base.EnemeyTakeDamage(damage);
        Debug.Log(enemyName + " explodes dealing " + damage + " damage to the player!");
        Player.instance.PlayerTakeDamage(damage);
    }
}