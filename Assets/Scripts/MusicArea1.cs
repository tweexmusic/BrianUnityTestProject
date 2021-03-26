using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicArea1 : MonoBehaviour
{
    private static FMOD.Studio.EventInstance music;

    //Parameter constants that controls the event
    public const string BATTLE_PARAMETER = "battle";


    // Start is called before the first frame update
    void Start()
    {
        music = FMODUnity.RuntimeManager.CreateInstance(FMODEventConstants.LEVEL1);
        music.start();
        music.release();
    }

    //By using enum types, statements that change the paramter value are easier to read and less prone to typos.
    protected enum BattleMusicParameter
    {
        Off,
        On
    }

    public static void StopMusic()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            music.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }

    public static void BattleParameter()
    {
        if (Player.instance.inBattle == true && EnemyManager.instance.enemiesAlive == true)
        {
            music.setParameterByName(BATTLE_PARAMETER, (float)BattleMusicParameter.On);
        }

        if(Player.instance.inBattle == false || EnemyManager.instance.enemiesAlive == false)
        {
            music.setParameterByName(BATTLE_PARAMETER, (float)BattleMusicParameter.Off);
        }
    }

    // Update is called once per frame
    void Update()
    {
        BattleParameter();
        StopMusic();
    }
}
