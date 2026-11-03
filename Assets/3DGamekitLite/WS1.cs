using System.Timers;
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

public class WS1 : MonoBehaviour
{
    public bool goggaga = true;
    private float speed = 3.5f;
    private int health = 5000;
    private string namn = "blingblong";
    Rigidbody rb;

    public UnityEvent onstart;
    public float timer = 0;

    


// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onstart.Invoke();
        speed = 3.3f;
        rb = GetComponent<Rigidbody>();

        for (int counter = 0; counter < 10; counter++)
        {
            Debug.Log(counter);
            if (counter == 7)
            {
                Destroy(gameObject);
            }
        }

    }

    
    

    // Update is called once per frame
    void Update()
    {
        timer =+ Time.deltaTime;
        //Debug.Log(timer);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            YSpeed();
        }
        
        if (goggaga == true)
        {
            health += 10;
        }
        
        //Debug.Log(health);
    }

    void YSpeed()
    {
        rb.linearVelocity = new Vector3(0, 3f, 0);
    }
}       