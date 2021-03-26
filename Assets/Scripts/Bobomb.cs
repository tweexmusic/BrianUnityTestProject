using UnityEngine;

/// <summary>
/// Class that houses specifics of Bobomb enemy.
/// Inherits from Enemy class.
/// </summary>

public class Bobomb : Enemy
{
    //Constructor that defines enemy name
    public Bobomb()
    {
        enemyName = "Bobomb";
    }

    public override void EnemyAttack(int damage)
    {
        base.EnemyAttack(damage);
        Player.instance.PlayerTakeDamage(damage);
        FMODOneShotPlayer.instance.FMODPlayOneShotSound(FMODEventConstants.BOBOMB_ATTACK);
        Debug.Log(enemyName + " deals " + damage + " to the player!");
    }

    public override void EnemeyTakeDamage(int damage)
    {
        base.EnemeyTakeDamage(damage);
        Debug.Log(enemyName + " explodes dealing " + damage + " damage to the player!");
        Player.instance.PlayerTakeDamage(damage);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            EnemyAttack(12);
        }
    }
}