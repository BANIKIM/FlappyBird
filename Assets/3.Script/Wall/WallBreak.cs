using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // [JaeYun] WallBreak: ���� ���������� �÷��̾�� ����� �� ���
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && player.transform.GetComponent<Player_Itme>().isGiant)//�߰� ���ּ��� ���� �÷��̾ ���̾�Ʈ �������� �Ծ��� �� isŰ��ƽ�� false�� �ٲ��ּ���
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}