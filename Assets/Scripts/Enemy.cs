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


    //Manages enemy health value calculations when taking damage.
    public virtual void EnemeyTakeDamage(int damage)
    {
        enemyHealth = enemyHealth - damage;
        Debug.Log(enemyName + " takes " + damage + " damage!");
        
        if (enemyHealth > 0)
        {
            Debug.Log(enemyName + " has " + enemyHealth + " remaining!");
        }
        else
        {
            Debug.LogWarning(enemyName + " has been defeated!");
        }
    }

    //Handles enemy attack statements.  Usually defined inside speicific derived enemy class.
    public virtual void EnemyAttack(int damage)
    {
        
    }

    //Used to set health value for enemies.  Deafult is 20, but can be overided in derived enemy class.
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