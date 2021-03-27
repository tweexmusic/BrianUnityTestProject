using UnityEngine;

/// <summary>
/// Enemy class houses virtual methods for handling enemy abilities and stats.
/// </summary>

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public int enemyHealth;

    //Constructor that defines enemy name
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

    /// <summary>
    /// Used to set health value for enemies.  Deafult is 20, but can be overridden in derived enemy class.
    /// </summary>
    public virtual void EnemyHealth()
    {
        enemyHealth = 20;
    }

    void Awake()
    {
        //Sets enemy health values when enemy list is created inside of EnemyManager.
        EnemyHealth();
    }
}