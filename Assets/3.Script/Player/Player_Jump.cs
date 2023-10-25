using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    Rigidbody rigidbody;  
    [SerializeField] private float Jump_P = 10f;
    public float Sleep = 10f;

    //Jump animation Add 
    private Animator animator;
    private bool isJump = false;

    //Jump Audio Add
    [SerializeField]private AudioSource audio;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(Jump_P, 0f, 0f);

        if (Input.GetButton("Jump"))//�����̽�Ű �Է½�
        {
           
            rigidbody.AddForce(0f, Jump_P, 0f);//Jump_P��ŭ ���� �ش�

            //isJump true _ Sujin
            audio.Play();
            isJump = true;            
            animator.SetBool("isJump", true);

        }
        else 
        {
            isJump = false;
            animator.SetBool("isJump", false);
        }
    }
}
