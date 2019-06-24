using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawC : MonoBehaviour
{
    private Vector3 vo;
    public PlayerM pm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)

    {
        var otherObj = col.collider;
        var cgo = otherObj.gameObject;
        var player = col.otherCollider.gameObject;

        if (otherObj.tag == "Main")
        {
            Animator anim = cgo.GetComponent<Animator>();
            pm.SetDead(true);
            //    anim.SetBool("Dead", true);
            cgo.GetComponent<Transform>().position = pm.GetVo();
             pm.SetDead(false);
        }


    }
}
