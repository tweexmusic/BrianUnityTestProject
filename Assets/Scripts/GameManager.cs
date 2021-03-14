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
    public Player playerPrefab;

    private void Awake()
    {
        if (Player.instance == null)
        {
            Player.instance = Instantiate(playerPrefab);
        }

        if (EnemyManager.instance == null)
        {
            EnemyManager.instance = Instantiate(enemyManagerPrefab);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("PRESS 'A' TO ATTACK WITH PLAYER!");
        Debug.LogWarning("PRESS 'B' TO ATTACK WITH BOBOMB!");
        Debug.LogWarning("PRESS 'K' TO ATTACK WITH KOOPA!");
        Debug.LogWarning("PRESS 'G' TO ATTACK WITH GOOMBA!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
