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

    [SerializeField] private GameObject[] player;

    private float time;
    private bool isGameover;

    private void Start()
    {
        
        time = 0;
        isGameover = false;
        switch (PlayerPrefs.GetInt("Character"))
        {
            case 0:
                player[0].SetActive(true);
                break;
            case 1:
                player[1].SetActive(true);
                break;
            case 2:
                player[2].SetActive(true);
                break;
        }

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
        RecordText.text = $"�ְ��� :{(int)BestScore} ";
    }
}
