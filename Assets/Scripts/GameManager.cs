using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GameManager class is resposible for automatically instantiating certain objects in the scene that are always required.
/// </summary>

public class GameManager : MonoBehaviour
{
    public EnemyManager enemyManagerPrefab;
    public Player playerPrefab;
    public FMODOneShotPlayer fmodOneShotPlayerPrefab;


    private void Awake()
    {

        if (Player.instance == null)
        {
            Instantiate(playerPrefab);
        }

        if (EnemyManager.instance == null)
        {
            Instantiate(enemyManagerPrefab);
        }

        if (FMODOneShotPlayer.instance == null)
        {
            Instantiate(fmodOneShotPlayerPrefab);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("PRESS 'A' TO ATTACK WITH PLAYER!");
        Debug.LogWarning("PRESS 'B' TO ATTACK WITH BOBOMB!");
        Debug.LogWarning("PRESS 'K' TO ATTACK WITH KOOPA!");
        Debug.LogWarning("PRESS 'G' TO ATTACK WITH GOOMBA!");
        Debug.LogWarning("PRESS 'S' TO STOP MUSIC!");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
