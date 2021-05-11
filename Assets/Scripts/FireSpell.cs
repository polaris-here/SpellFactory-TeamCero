using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public class FireSpell : MonoBehaviour, ISpell
    {
        private Vector3 Force = new Vector3(0f, 0, 10000f);

        void ISpell.Cast(GameObject spell)
        {
            Rigidbody rb = spell.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.AddForce(new Vector3(10, 10, 0), ForceMode.Impulse);
        }
    }
}
