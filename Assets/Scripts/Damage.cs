using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int _Damage = 1;
    public string Tag;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == Tag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeHit(_Damage);
        }
    }
}
