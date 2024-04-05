using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float TempoDeJogo { get; private set; }

    void Awake()
    {
        if(instance != this && instance != null)
        {
            Destroy(instance);
        }

        instance = this;
        
        
    }

    void Update()
    {
        TempoDeJogo += Time.deltaTime;
        Debug.Log(TempoDeJogo);
    }
}
