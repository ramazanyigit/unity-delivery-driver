using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0, 0, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 255);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)  {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, 0f);
            Debug.Log("you picked up a package.");
        }   

        if (other.tag == "Customer" && hasPackage)  {
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
            Debug.Log("you delivered a package.");
        }   
    }
}
