using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   

    private CapsuleCollider capsuleCollider;
    private Rigidbody rigid;
    private Animator animator;
  
   
    private float originalPlayer;

    private void Start()
    {
      
        capsuleCollider  = GetComponent<CapsuleCollider>();
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        originalPlayer = transform.localScale.x;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            bool isGodmode = other.gameObject.name.Contains("Godmode");
            bool isGiant = other.gameObject.name.Contains("Giant");

            if (isGodmode)
            {

                Debug.Log("�浹");


                //Setbool�� walk�� true;

                rigid.isKinematic = true;
                capsuleCollider.enabled = false;
                //rigid.AddForce(Vector3.right * 25, ForceMode.Impulse);



                StartCoroutine(RestoreColor(2f));
                Debug.Log("����");

            }
            if (isGiant)
            {

                transform.localScale = new Vector3(originalPlayer * 3f, originalPlayer * 3f, originalPlayer * 3f);

                StartCoroutine(RestoreColor(2f));
                Debug.Log("����");

            }

            // ������ ��Ȱ��ȭ
            other.gameObject.SetActive(false);
        }

    }

    private IEnumerator RestoreColor(float delay)
    {
        yield return new WaitForSeconds(delay); // ����

        //Setbool��  walk�� false;

        //SetTrigger idle�� true;

        rigid.isKinematic = false;
        // �ٸ� ���� �۾� ����
        capsuleCollider.enabled = true;
        Debug.Log("���ƿԳ�?");
        // �ٸ� �۾� ���� ����
        transform.localScale = new Vector3(originalPlayer, originalPlayer, originalPlayer);

    }
}
