using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameoverText;
    [SerializeField]
    private Text TimeText;
    [SerializeField]
    private Text RecordText;

    private float time;
    private bool isGameover;

    private void Start()
    {
        time = 0;
        isGameover = false;

    }
    private void Update()
    {
        if (!isGameover)
        {
            //�ð� 
            time += Time.deltaTime;
            TimeText.text = $"Score :{(int)time}";
        }
        else
        {
            //�����
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void EndGame()
    {
        isGameover = true;
        GameoverText.SetActive(true);

        float BestScore = PlayerPrefs.GetFloat("bestScore");

        if (time > BestScore)
        {
            BestScore = time;
            PlayerPrefs.SetFloat("bestScore", BestScore);
        }
        RecordText.text = $"�ְ���� :{(int)BestScore} ";
    }
}