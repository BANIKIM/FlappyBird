using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] private float Jump_P = 10f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //rigidbody.AddForce(1f, 0f, 0f);

        if (Input.GetButton("Jump"))//�����̽�Ű �Է½�
        {
            Debug.Log("����");
            rigidbody.AddForce(0f, Jump_P, 0f);//Jump_P��ŭ ���� �ش�

        }
    }
}
