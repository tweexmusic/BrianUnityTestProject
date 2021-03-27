using UnityEngine;

/// <summary>
/// Class that houses specifics of Hammer Bro enemy.
/// Inherits from Enemy class.
/// </summary>

public class HammerBro : Enemy
{
    //Constructor that defines enemy name
    public HammerBro()
    {
        enemyName = "Hammer Bro";
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
            Debug.LogWarning("A Goomba and a Koopa appear to avenge the death of their friend, " + enemyName + "!");
            EnemyManager.instance.SpawnEnemy(EnemyManager.instance.goombaPrefab);
            EnemyManager.instance.SpawnEnemy(EnemyManager.instance.koopaPrefab);
        }
    }

    public override void EnemyHealth()
    {
        enemyHealth = 35;
    }

    private void Update()
    {
        if (enemyHealth > 0 && Player.instance.playerHealth > 0 && Input.GetKeyDown(KeyCode.H))
        {
            EnemyAttack(15);
        }
    }
}