using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//������ �������� �����̴� �ڵ�
public class Map_Move : MonoBehaviour
{
    private float position_X;//�����Ǽ���
    private float Speed = 5f; //�����̴� ���ǵ�
    private void FixedUpdate()
    {
        position_X = transform.position.x + (Speed * Time.fixedDeltaTime)*-1;
        transform.position = new Vector3(position_X, transform.position.y, 0f);
    }
}
