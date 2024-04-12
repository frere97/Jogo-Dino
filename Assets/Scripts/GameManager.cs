using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float TempoDeJogo { get; private set; }

    public float moedas = 0;

    public float Score { get; private set; }

    public bool PlayerTaVivo = true;

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
        Score = (int)TempoDeJogo + (moedas * 10);
        Debug.Log(TempoDeJogo);

        if (PlayerTaVivo)
        {
            Time.timeScale += 0.001f * Time.deltaTime;
        }
    }
}
