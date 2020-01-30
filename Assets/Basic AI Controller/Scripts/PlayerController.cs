using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 7.0f;
    float rotationSpeed = 100.0f;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = (Input.GetAxis("Vertical") * speed) * Time.deltaTime;
        float rotation = (Input.GetAxis("Horizontal") * rotationSpeed) * Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKey(KeyCode.W))
        {
            m_Animator.SetBool("isWalking", true);
        } else {
            m_Animator.SetBool("isWalking", false);
        }

        if (Input.GetMouseButtonDown(0)) 
        {
            m_Animator.SetBool("isAttacking", true);
        } else {
            m_Animator.SetBool("isAttacking", false);
        }
    }

    public void ReceiveDamage(float damage)
    {
        Debug.Log("PLAYER_CONTROLLER: Player hit with " + damage + " damage!");
    }
}
