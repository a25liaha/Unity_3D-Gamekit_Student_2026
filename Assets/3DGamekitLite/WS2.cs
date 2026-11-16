using UnityEngine;
using Gamekit3D;
using FMODUnity;
using FMOD.Studio;

public class WS2 : MonoBehaviour
{
    public float timer = 5f;
    
    public EventInstance eventInstance;
    public EventReference eventReference;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            //eventInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
            eventInstance.setParameterByName("Parameter 1", 0);
        }
        if (timer <= -10f && timer >= -19f)
        {
            eventInstance.setParameterByName("Parameter 1", 1);
            
        }
        
    }
}

internal class eventInstance
{
}

internal class eventReference
{
}

internal class Public
{
}
