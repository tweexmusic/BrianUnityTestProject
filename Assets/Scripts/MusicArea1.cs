﻿using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            music.setParameterByName(BATTLE_PARAMETER, (float)BattleMusicParameter.On);
        }

        if (Input.GetKeyDown(KeyCode.W))
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
