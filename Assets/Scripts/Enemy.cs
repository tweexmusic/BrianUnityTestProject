using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;

    public Enemy()
    {
        enemyName = "Generic Enemy";
    }

    public virtual void TakeDamage(int damage)
    {
        Debug.Log(enemyName + " takes " + damage + " damage!");
    }
}