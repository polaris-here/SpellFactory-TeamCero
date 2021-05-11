using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public class EnergyBlastSpell : MonoBehaviour, ISpell
    {
            private Vector3 Force = new Vector3(750.0f, 0f, 0f);
            void ISpell.Cast(GameObject spell)
            {
                spell.GetComponent<Rigidbody>().AddForce(this.Force);
            }
    }
}