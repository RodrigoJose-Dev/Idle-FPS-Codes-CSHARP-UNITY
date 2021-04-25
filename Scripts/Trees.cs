using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{

    public static Trees instance;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Shoot.instance.canDamage = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Shoot.instance.canDamage = true;
        }
    }
}
