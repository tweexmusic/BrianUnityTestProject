using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;

    public Enemy()
    {
        enemyName = "Generic Enemy";
    }

    public virtual void EnemeyTakeDamage(int damage)
    {
        Debug.Log(enemyName + " takes " + damage + " damage!");
    }

    public virtual void EnemyAttack(int damage)
    {
        
    }
}