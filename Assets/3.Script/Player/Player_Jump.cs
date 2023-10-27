using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    Rigidbody rigidbody;  
    [SerializeField] private float Jump_P = 10f;

    //Jump animation Add 
    private Animator animator;
    private bool isJump = false;

    //Jump Audio Add
    [SerializeField]private AudioSource audio;
    public AudioClip Jump_S;

    [SerializeField] private GameObject jumpEffect;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        rigidbody.AddForce(Jump_P, 0f, 0f);

        if (Input.GetButtonDown("Jump"))//�����̽�Ű �Է½�
        {
           
            rigidbody.AddForce(0f, Jump_P, 0f);//Jump_P��ŭ ���� �ش�

            //isJump true _ Sujin
            audio.PlayOneShot(Jump_S);//�ѹ��� 
            isJump = true;            
            animator.SetBool("isJump", true);

            Instantiate(jumpEffect, transform.position, jumpEffect.transform.rotation);
        }
        else 
        {
            isJump = false;
            animator.SetBool("isJump", false);
        }
    }
}
