using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    // [JaeYun] WallBreak: ���� ���������� �÷��̾�� ����� �� ���
    private void OnCollisionEnter(Collision collision)
    {
        //�÷��̾� tag�� ���� ������Ʈ�� �ε����� �� && is���̾�Ʈ�� �Ծ��� �� ��� ������ �߰� ���ּ���... mh
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;// isŰ�׸�ƽ üũ�� �����Ѵ�... mh
        }
    }
}
