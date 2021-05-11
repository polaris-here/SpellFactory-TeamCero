using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public class SparkSpell : MonoBehaviour, ISpell
    {
        private Vector3 Force = new Vector3(10f, 10f, 0f);

        void ISpell.Cast(GameObject spell)
        {
            Rigidbody rb = spell.GetComponent<Rigidbody>();
            rb.useGravity = true;
            rb.AddForce(this.Force, ForceMode.Impulse);
        }
    }
}
