using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLevel1 : MonoBehaviour
{
    private static FMOD.Studio.EventInstance Music;

    // Start is called before the first frame update
    void Start()
    {
        Music = FMODUnity.RuntimeManager.CreateInstance("event:/music/level1");
        Music.start();
        Music.release();
    }

    protected enum BattleMusicParameter
    {
        Off,
        On
    }

    public static void BattleParameter()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Music.setParameterByName("battle", (float)BattleMusicParameter.On);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Music.setParameterByName("battle", (float)BattleMusicParameter.Off);
        }
    }

    // Update is called once per frame
    void Update()
    {
        BattleParameter();
    }
}
