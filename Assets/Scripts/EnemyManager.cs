using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    //instance variable name indicates a singleton inside the class.
    public static EnemyManager instance;

    public Enemy goombaPrefab;
    public Enemy koopaPrefab;
    public Enemy bobombPrefab;

    public string enemyName;

    public List<Enemy> enemiesList = new List<Enemy>();
    private int enemyCount = 1;

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

        PopulateEnemyList();
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (Enemy enemy in enemiesList)
        {
            Debug.Log(enemy);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            enemyName = "Goomba";
            goombaPrefab.EnemyAttack();
        }

        if (Input.GetKeyDown(KeyCode.K)) 
        {
            enemyName = "Koopa";
            koopaPrefab.EnemyAttack();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            enemyName = "Bobomb";
            bobombPrefab.EnemyAttack();
        }
    }
}
