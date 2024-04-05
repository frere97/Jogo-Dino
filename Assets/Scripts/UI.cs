using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText;

    public static UI instance;

    public GameObject replayMenu;

    private void Awake()
    {
        if (instance != this && instance != null)
        {
            Destroy(instance);
        }

        instance = this;

    }


    // Start is called before the first frame update
    void Start()
    {
        replayMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + (int)GameManager.instance.TempoDeJogo;
    }

    public void TurnOnReplayMenu()
    {
        replayMenu.SetActive(true);
    }
}
