using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color (1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color (1, 1, 1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log(hasPackage);  
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("doing!");
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("What was that omg!");

        if (other.tag == "Package"&& !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,destroyDelay);
        }

        if (other.tag == "Customer"&& hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }

        

        



    }
  
    

    
    
        
    }


