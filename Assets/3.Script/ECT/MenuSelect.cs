using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    [SerializeField] private GameObject[] menu;
    public void OnClickButton(int i)
    {
        PlayerPrefs.SetInt("Character", i);//ĳ���� ����
        Debug.Log(PlayerPrefs.GetInt("Character"));
        SceneManager.LoadScene("MainGame");//���ΰ������� �� ��ȯ
    }

    public void AnyKeyDown()
    {
        
        menu[1].SetActive(false);
        Invoke("aaa",2f);
        menu[2].SetActive(true);
    }
    private void aaa()
    {
        menu[0].SetActive(true);
    }
}
