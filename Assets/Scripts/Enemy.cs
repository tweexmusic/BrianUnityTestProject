using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public int enemyHealth;
    public static bool enemyAlive = true;

    public Enemy()
    {
        enemyName = "Generic Enemy";
    }

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
        //Sets enemy health values when scene awakes.
        EnemyHealth();
    }
}