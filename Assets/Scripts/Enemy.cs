using UnityEngine;

/// <summary>
/// Enemy class houses virtual methods for handling enemy abilities and stats.
/// </summary>

public class Enemy : MonoBehaviour
{
    protected string enemyName;
    protected int enemyHealth = 20;
    protected KeyCode keyInput;
    protected int attackValue;

    //Constructor that defines enemy stats
    public Enemy()
    {
        enemyName = "Generic Enemy";
    }

    /// <summary>
    /// Manages enemy health value calculations when taking damage.
    /// "damage" paramater is passed in from EnemyManger's EnemeyTakeDamageGlobal method.
    /// </summary>
    /// <param name="damage"></param>
    public virtual void EnemeyTakeDamage(int damage)
    {
        enemyHealth = enemyHealth - damage;

        if (enemyHealth > 0)
        {
            Debug.Log(enemyName + " takes " + damage + " damage and has " + enemyHealth + " health remaining!");
            Player.instance.inBattle = true;
        }

        else
        {
            Debug.LogWarning(enemyName + " has been defeated!");
            FMODOneShotPlayer.instance.PlayOneShotSound(FMODEventConstants.ENEMY_DEATH);
        }
    }

    /// <summary>
    /// Handles enemy attack statements.  Derived classes may have additional/alternate behehaviors.
    /// </summary>
    /// <param name="damage"></param>
    public virtual void EnemyAttack(int damage)
    {
        Player.instance.inBattle = true;
        Player.instance.PlayerTakeDamage(damage);
        Debug.Log(enemyName + " deals " + damage + " damage to the player!");
    }

    public int GetEnemyHealth()
    {
        return enemyHealth;
    }

    void Update()
    {
        if (enemyHealth > 0 && Player.instance.playerHealth > 0 && Input.GetKeyDown(keyInput))
        {
            EnemyAttack(attackValue);
        }
    }
}