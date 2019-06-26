using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)

    {
        var playerCol = col.collider;
        var playerGO = playerCol.gameObject;
        var swordGO = col.otherCollider.gameObject;


        if (playerGO.tag == "Main")
        {
            Debug.Log("Collisding with" + col.collider.gameObject.name);
            this.activar(swordGO, playerGO, "WeaponHolder");
        }
       

    }

    private void activar(GameObject cgo, GameObject player, string tag)
    {
        GameObject.Destroy(cgo);
        for (int i = 0; i < player.transform.childCount; i++)
        {
            Transform son = player.transform.GetChild(i);
            if (son.tag == tag)
            {
                son.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }

}
