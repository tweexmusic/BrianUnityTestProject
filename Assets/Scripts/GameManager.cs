using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //popluating the scene; hooking up objects
    //certain objects need to be in every scene
    //the gamemanager Prefab will be pulled into the scene
    //it will pull in the game objects that are set up in the game manager
    //player and enemymanager objects will be spawned in based on their prefabs
    //don't forget to consider order; awake vs start vs update

    public EnemyManager enemyManagerPrefab;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        if (EnemyManager.instance == null)
        {
            EnemyManager.instance = Instantiate(enemyManagerPrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
