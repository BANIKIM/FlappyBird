using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    
    public void OnClickButton(int i)
    {
        PlayerPrefs.SetInt("Character", i);//ĳ���� ����
        Debug.Log(PlayerPrefs.GetInt("Character"));
        SceneManager.LoadScene("MainGame");//���ΰ������� �� ��ȯ
    }
}
