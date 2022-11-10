using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour
{

    public GameObject player;
    
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    private Health playerHealth;

    public enum GameStates
    {
        Playing,
        GameOver
    }

    public GameStates state = GameStates.Playing;

    // Start is called before the first frame update
    void Start()
    {

        mainCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        playerHealth = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GameStates.Playing:
                if (!playerHealth.isAlive)
                {
                    state = GameStates.GameOver;
                    gameOverCanvas.SetActive(true);
                    mainCanvas.SetActive(false);
                }   
                break;


        }
    }
}
