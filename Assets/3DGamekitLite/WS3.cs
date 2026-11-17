using System;
using UnityEngine;
using Random = System.Random;


[System.Serializable]

public struct CharacterInformation
{
    public string name;
    public WS3.ElementalPower elementalPower;
    public float speed;
    public int health;
    public bool isDead;
    public int damagePower;
}

public class WS3 : MonoBehaviour
{
    public CharacterInformation characterInformation;
    public int[] highScores;
    public enum ElementalPower
    {
        None,
        Fire,
        Water,
        Wind,
        Earth,
    }

    public ElementalPower elementkraft;

    void Start()
    {
        Debug.Log(elementkraft);
        
        Debug.Log(characterInformation.name);

        Debug.Log(highScores[4]);
        
        //Debug.Log("WS3 Start");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("WS3 OnTriggerEnter");
    }
}









