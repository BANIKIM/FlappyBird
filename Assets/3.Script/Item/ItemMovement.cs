using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �̵� �ӵ�, ���ϴ� ������ ����

    private void Update()
    {
       
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
