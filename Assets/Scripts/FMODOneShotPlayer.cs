using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class handles playing FMOD events in code or inside Unity itself.

public class FMODOneShotPlayer : MonoBehaviour
{
    public static FMODOneShotPlayer instance;

    public void FMODPlayOneShotSound(string fmodEventPath)
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
