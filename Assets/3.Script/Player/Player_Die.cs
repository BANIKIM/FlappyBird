using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Die : MonoBehaviour
{
    private Item_Active player;
   
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
             //   Die();
              //  gameObject.SetActive(false);//Player ��Ȱ��ȭ
            }
            //2023-10-25 ���ؿ�
            

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            if (!player.isGiant && !player.isGodmode)
            {
            //    Die();
              //  gameObject.SetActive(false);//Player ��Ȱ��ȭ
            }
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