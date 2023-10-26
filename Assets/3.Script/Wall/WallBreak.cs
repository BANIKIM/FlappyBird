using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    private GameObject player;
    private float boundForce = 100f;

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
            ExcecuteBounding(collision); // player collision
        }
    }

    private void ExcecuteBounding(Collision collision)
    { // Player�� ���� ������ �� wall �ٿ��
        Vector3 wallPosition = new Vector3(transform.position.x, transform.position.y, transform.position.x);
        ContactPoint cp = collision.GetContact(0); // �浹 �� �浹�Ǵ� ������ ���� ��ȯ
        Vector3 dir = new Vector3(0, wallPosition.x - cp.point.x, wallPosition.x - cp.point.x); // x�� �������� �÷��̾� �������̶� x�� �浹 ���� ���� ��������
        gameObject.transform.GetComponent<Rigidbody>().AddForce((dir).normalized * boundForce);
    } // 23. 10. 26 ������
    //2023-10-25 ���ؿ� 
}