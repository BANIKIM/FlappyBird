using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Active : MonoBehaviour
{
    private CapsuleCollider capsuleCollider;
    private Rigidbody rigid;
    // �÷��̾� �ӵ� �ҷ����� 
    private Player_Move player_move;
    private Animator animator;

    [SerializeField] private AudioSource audioSource;
    public AudioClip giant;
    public AudioClip godmode;



    public bool isGodmode;
    public bool isGiant;
    private float originalPlayer;

    private void Start()
    {

        capsuleCollider = GetComponent<CapsuleCollider>();
        rigid = GetComponent<Rigidbody>();
        player_move = GetComponent < Player_Move>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
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
                //animator.SetBool("walk", true);

                //�÷��̾� �ӵ� ���� 
                player_move.Speed = 30f;
                audioSource.PlayOneShot(godmode);

                //rigid.isKinematic = true;
                //capsuleCollider.enabled = false;


                StartCoroutine(OffiaGodmode(2f));
                Debug.Log("����");

            }
            if (isGiant)
            {

                transform.localScale = new Vector3(originalPlayer * 3f, originalPlayer * 3f, originalPlayer * 3f);
                audioSource.PlayOneShot(giant);
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
        //animator.SetBool("walk", false);
      
        rigid.isKinematic = false;
       
        //���ǵ� ���� 
        player_move.Speed = 7f;
        audioSource.Stop();

        isGodmode = false;
    }

    private IEnumerator OffisGiant(float delay)
    {
        yield return new WaitForSeconds(delay); // ����

        rigid.isKinematic = false;

        //������ ����
        transform.localScale = new Vector3(originalPlayer, originalPlayer, originalPlayer);
        //is Giant, isGodmode false;
        isGiant = false;
       
    }
    //2023-10-26 ���ؿ� 

}