using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
        public class ErekiBallSpell : MonoBehaviour, ISpell
        {
            private Vector3 Force = new Vector3(500.0f, 0f, 0f);
            void ISpell.Cast(GameObject spell)
            {
                this.transform.Rotate(new Vector3(0,90,0), Space.Self);
                Rigidbody rb = spell.GetComponent<Rigidbody>();
                rb.useGravity = false;
                rb.AddForce(this.Force);
            }
        }
}