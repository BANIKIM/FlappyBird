using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    // [JaeYun] WallBreak: ���� ���������� �÷��̾�� ����� �� ���
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))//�߰� ���ּ��� ���� �÷��̾ ���̾�Ʈ �������� �Ծ��� �� isŰ��ƽ�� false�� �ٲ��ּ���
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
