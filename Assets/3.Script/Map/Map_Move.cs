using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//������ �������� �����̴� �ڵ�
public class Map_Move : MonoBehaviour
{
    private float position_X;//�����Ǽ���
    public float Speed = -5f; // ���������� �̵��Ϸ��� �� ���� ����� �����ϼ���
    private void FixedUpdate()
    {
        position_X = transform.position.x + (Speed * Time.fixedDeltaTime);
        transform.position = new Vector3(position_X, transform.position.y, 0f);


        Destroy(gameObject, 5f);
    }
}
