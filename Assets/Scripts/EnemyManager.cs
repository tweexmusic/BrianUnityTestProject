using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //instance variable name indicates a singleton inside the class.
    public static EnemyManager instance;

    public Enemy goombaPrefab;
    public Enemy koopaPrefab;
    public Enemy bobombPrefab;

    //public string enemyName;

    private List<Enemy> enemiesList = new List<Enemy>();
    private int enemyCount = 1;

    void PopulateEnemyList()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            enemiesList.Add(Instantiate(goombaPrefab));
            enemiesList.Add(Instantiate(koopaPrefab));
            enemiesList.Add(Instantiate(bobombPrefab));
        }
        //Commented the next statement out because it was calling the EnemyTakeDamage() function twice per instance.
        //enemiesList.AddRange(FindObjectsOfType<Enemy>());
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        
        PopulateEnemyList();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Handles all enemies in the enemiesList taking damage
    public void EnemyTakeDamage(int damage)
    {
        foreach (Enemy enemy in enemiesList)
        {
            enemy.EnemeyTakeDamage(damage);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            goombaPrefab.EnemyAttack(3);

        }

        if (Input.GetKeyDown(KeyCode.K)) 
        {
            koopaPrefab.EnemyAttack(7);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            bobombPrefab.EnemyAttack(12);
        }
    }
}
