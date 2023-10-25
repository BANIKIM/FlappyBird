using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Itme : MonoBehaviour
{
    private CapsuleCollider capsuleCollider;
    private Rigidbody rigid;
    // �÷��̾� �ӵ� �ҷ����� 
    private Player_Move map_Move;


    public  bool isGodmode;
    public bool isGiant;
    private float originalPlayer;

    private void Start()
    {

        capsuleCollider = GetComponent<CapsuleCollider>();
        rigid = GetComponent<Rigidbody>();
        map_Move = GetComponent < Player_Move>();

        originalPlayer = transform.localScale.x;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            isGodmode = other.gameObject.name.Contains("Godmode");
            isGiant = other.gameObject.name.Contains("Giant");

            if (isGodmode)
            {

                Debug.Log("�浹");

                //Setbool�� walk�� true;

                //�÷��̾� �ӵ� ���� 
                map_Move.Speed += 40.0f;

                //rigid.isKinematic = true;
                //capsuleCollider.enabled = false;

   
                StartCoroutine(OffiaGodmode(2f));
                Debug.Log("����");

            }
            if (isGiant)
            {

                transform.localScale = new Vector3(originalPlayer * 3f, originalPlayer * 3f, originalPlayer * 3f);

                StartCoroutine(OffisGiant(4f));

                Debug.Log("����");

            }

            // ������ ��Ȱ��ȭ
            other.gameObject.SetActive(false);
        }

    }

    private IEnumerator OffiaGodmode(float delay)
    {
        yield return new WaitForSeconds(delay); // ����

        //Setbool��  walk�� false;

        //SetTrigger idle�� true;

        rigid.isKinematic = false;
       
        //���ǵ� ���� 
        map_Move.Speed -= 40.0f;
        //������ ����
        transform.localScale = new Vector3(originalPlayer, originalPlayer, originalPlayer);
        //is Giant, isGodmode false;
       
        isGodmode = false;
    }

    private IEnumerator OffisGiant(float delay)
    {
        yield return new WaitForSeconds(delay); // ����

        //Setbool��  walk�� false;

        //SetTrigger idle�� true;

        rigid.isKinematic = false;

        //���ǵ� ���� 
        
        //������ ����
        transform.localScale = new Vector3(originalPlayer, originalPlayer, originalPlayer);
        //is Giant, isGodmode false;
        isGiant = false;
       
    }
    //2023-10-25 ���ؿ� 

}