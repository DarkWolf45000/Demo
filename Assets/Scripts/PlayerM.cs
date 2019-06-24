using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed=5f;
    private Transform pt;
    private int cantj = 0;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        pt = this.gameObject.GetComponent<Transform>();
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 va = pt.position;
        if (Input.GetKey(KeyCode.D))
        {
            this.lookRight(this.gameObject);
            Vector3 movement = new Vector3(speed, 0f, 0f);
            pt.position += movement * Time.deltaTime * speed;
            anim.SetBool("Movement",true);

        }

        if (Input.GetKey(KeyCode.A))
        {
            this.lookLeft(this.gameObject);
            Vector3 movement = new Vector3(-1 * speed, 0f, 0f);
            pt.position += movement * Time.deltaTime * speed;
            anim.SetBool("Movement", true);

        }

        if (Input.GetKeyDown(KeyCode.W) && cantj < 1)
        {
            cantj += 1;
            Vector2 v2 = new Vector2(0f, 5f);
            rb.AddForce(v2, ForceMode2D.Impulse);
            anim.SetBool("Salto", true);
        }

        if (va.Equals(pt.position))
        {
            anim.SetBool("Movement", false);
        }
    }

    private void lookRight(GameObject player)
    {
        for (int i = 0; i < player.transform.childCount; i++)
        {
            Transform son = player.transform.GetChild(i);
            SpriteRenderer sr = son.GetComponent<SpriteRenderer>();
            sr.flipX = true;
            
        }


    }

    private void lookLeft(GameObject player)
    {
        for (int i = 0; i < player.transform.childCount; i++)
        {
            Transform son = player.transform.GetChild(i);
            SpriteRenderer sr = son.GetComponent<SpriteRenderer>();
            sr.flipX = false;
            
        }

    }

    private void OnCollisionEnter2D(Collision2D col)

    {
        var otherObj = col.collider;
        var cgo = otherObj.gameObject;
        var player = col.otherCollider.gameObject;

        if (otherObj.tag == "Ground")
        {
            cantj = 0;
            anim.SetBool("Salto", false);
        }

    }

}
