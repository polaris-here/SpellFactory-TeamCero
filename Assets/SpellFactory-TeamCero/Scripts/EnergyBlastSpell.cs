using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public class EnergyBlastSpell : MonoBehaviour, ISpell
    {
            private Vector3 Force = new Vector3(10.0f, 0f, 0f);
            void ISpell.Cast(GameObject spell)
            {
                spell.GetComponent<Rigidbody>().AddForce(this.Force);
                Rigidbody rb = spell.GetComponent<Rigidbody>();
                rb.useGravity = false;
                rb.AddForce(this.Force, ForceMode.Impulse);
            }
    }
}