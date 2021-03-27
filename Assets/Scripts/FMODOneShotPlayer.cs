using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///Class handles playing one shot FMOD events in code or inside Unity itself.
///SINGLETON
/// </summary>

public class FMODOneShotPlayer : MonoBehaviour
{
    public static FMODOneShotPlayer instance;

    public void PlayOneShotSound(string fmodEventPath)
    {
        FMODUnity.RuntimeManager.PlayOneShot(fmodEventPath, GetComponent<Transform>().position);
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
    }
}
