using UnityEngine;
using Gamekit3D;
using FMODUnity;
using FMOD.Studio;
using STOP_MODE = FMOD.Studio.STOP_MODE;


public class AudioTrigger : MonoBehaviour
{
    public EventInstance eventInstance;
    public EventReference eventReference;

    public int number = 0; 


// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("AudioTrigger OnTriggerEnter");
        //eventInstance.start();
        
        
        if (number == 0)
        {
            eventInstance.stop(STOP_MODE.ALLOWFADEOUT);
            Debug.Log("Stop OnTriggerEnter");
        }
        if (number == 1)
        {
            eventInstance.start();
            Debug.Log("start OnTriggerEnter");
        }
        
    }
}
