using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime = 0f;

    public float startingTime = 10f;

    [SerializeField] public TextMeshProUGUI countDownTimer;

    public GameObject gameOver;

    bool gameEnd = false;

    private void Start()
    {
        Time.timeScale = 1f;
        gameEnd = false;
        currentTime = startingTime;
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownTimer.text = currentTime.ToString("0");

        if(currentTime <= 30)
        {
            countDownTimer.color = Color.red;
            
        }
        if(gameEnd)
        {
            return;
        }
        if(currentTime <= 0)
        {
            currentTime = 0;
            End();
        }              
    }
    void End()
    {
        gameEnd = true;
        
        Time.timeScale = 0f;

        gameOver.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
    }
}
