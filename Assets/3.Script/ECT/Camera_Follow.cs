using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target; // ī�޶� ����ٴ� ���
    public Vector3 offset; // ī�޶�� ��� ������ �Ÿ�
    public float smoothSpeed = 0.125f; // ī�޶��� �ε巯�� �������� ���� �ӵ�

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
