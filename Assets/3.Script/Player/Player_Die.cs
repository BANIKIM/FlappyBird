using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Die : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)//���� �� �����ϴ� �޼���
    {
        if(collision.gameObject.CompareTag("Wall"))//Wall Tag ���˽�
        {
            Debug.Log("����");
            gameObject.SetActive(false);//Player ��Ȱ��ȭ
        }
    }
}
