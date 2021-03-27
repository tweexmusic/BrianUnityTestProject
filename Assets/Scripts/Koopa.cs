using UnityEngine;

/// <summary>
/// Class that houses specifics of Koopa enemy.
/// Inherits from Enemy class.
/// </summary>

public class Koopa : Enemy
{
    //Constructor that defines enemy name
    public Koopa()
    {
        enemyName = "Koopa";
    }

    public override void EnemyAttack(int damage)
    {
        base.EnemyAttack(damage);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.KOOPA_ATTACK);
    }

    public override void EnemyHealth()
    {
        enemyHealth = 35;
    }

    private void Update()
    {
        if (enemyHealth > 0 && Player.instance.playerHealth > 0 && Input.GetKeyDown(KeyCode.K))
        {
            EnemyAttack(7);
        }
    }
}