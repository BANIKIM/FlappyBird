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
    {     //�÷��̾ isGiant �ų� isGodmode�� �� isKinematic false �ǰ� 
        if (collision.gameObject.CompareTag("Player") && (player.transform.GetComponent<Player_Itme>().isGiant || player.transform.GetComponent<Player_Itme>().isGodmode))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    //2023-10-25 ���ؿ� 
}