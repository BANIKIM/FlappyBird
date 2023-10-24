using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // private SpriteRenderer spriteRenderer;

    private BoxCollider boxCollider;
    private Rigidbody rigid;
    private Material playerMaterial;
    private GameManager gameManager;
    private float originalPlayer;

    private void Start()
    {
     
        boxCollider = GetComponent<BoxCollider>();
        rigid = GetComponent<Rigidbody>();
        gameManager = GetComponent<GameManager>();
        playerMaterial = GetComponent<MeshRenderer>().material;
        //map_Move = GetComponent<Map_Move>();
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
               

                playerMaterial.color = new Color(255, 255, 0, 255);
                boxCollider.enabled = false;
                //rigid.AddForce(Vector3.right * 25, ForceMode.Impulse);



                StartCoroutine(RestoreColor(2f));
                Debug.Log("����");

            }
            if (isGiant)
            {

                transform.localScale = new Vector3(originalPlayer * 3f, originalPlayer * 3f, originalPlayer * 3f);

                StartCoroutine(RestoreColor(1f));
                Debug.Log("����");

            }

            // ������ ��Ȱ��ȭ
            other.gameObject.SetActive(false);
        }

    }

    private IEnumerator RestoreColor(float delay)
    {
        yield return new WaitForSeconds(delay); // ����

        // �÷��̾� ������ ����
        playerMaterial.color = new Color(255, 0, 0, 255); // ���� ���� 1�� �����Ͽ� ���� ���� ����

        // �ٸ� ���� �۾� ����
        boxCollider.enabled = true;
        Debug.Log("���ƿԳ�?");
        // �ٸ� �۾� ���� ����
        transform.localScale = new Vector3(originalPlayer, originalPlayer, originalPlayer);

    }
}
