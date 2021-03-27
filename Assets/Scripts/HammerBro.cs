using UnityEngine;

/// <summary>
/// Class that houses specifics of Hammer Bro enemy.
/// Inherits from Enemy class.
/// </summary>

public class HammerBro : Enemy
{
    //Constructor that defines enemy stats
    public HammerBro()
    {
        enemyName = "Hammer Bro";
        enemyHealth = 25;
        attackValue = 15;
        keyInput = KeyCode.H;
    }

    public override void EnemyAttack(int damage)
    {
        base.EnemyAttack(damage);
        FMODOneShotPlayer.instance.PlayOneShotSound(FMODEventConstants.HAMMERBRO_ATTACK);
    }

    public override void EnemeyTakeDamage(int damage)
    {
        base.EnemeyTakeDamage(damage);

        if (enemyHealth <= 0)
        {
            Debug.LogError("A Goomba and a Koopa appear to avenge the death of their friend, " + enemyName + "!");
            EnemyManager.instance.SpawnEnemy(EnemyManager.instance.goombaPrefab);
            EnemyManager.instance.SpawnEnemy(EnemyManager.instance.koopaPrefab);
        }
    }
}