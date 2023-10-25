using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Die : MonoBehaviour
{
    private Player_Itme player;

    private void Awake()
    {
        TryGetComponent(out player);
    }

    private void OnCollisionEnter(Collision collision)//���� �� �����ϴ� �޼���
    {
        if (collision.gameObject.CompareTag("Wall"))//Wall Tag ���˽�
        { 
            //�÷��̾ isGiant�� �ƴϰų�  isGodmode�� �ƴϸ� ���� 
            if (!player.isGiant && !player.isGodmode)
            {
                Debug.Log(player.isGodmode);
                Die();
                gameObject.SetActive(false);//Player ��Ȱ��ȭ
            }
            //2023-10-25 ���ؿ�
            

        }
    }
    public void Die()
    {
        if (GameManager.FindObjectOfType<GameManager>().TryGetComponent(out GameManager gm))//�׾��� �� RŰ�� �����ÿ� 
        {
            gm.EndGame(); //���� �Ŵ����� �̵� 
        }
    }
    //2023/10/24 ���ؿ� 

}