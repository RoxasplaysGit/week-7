using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Bullet : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 2f);
    }
}
