using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Magic;

public class SpellFactory : MonoBehaviour
{
    [SerializeField] private GameObject Spell1;
    [SerializeField] private GameObject Spell2;
    [SerializeField] private GameObject Spell3;
    [SerializeField] private GameObject DefaultSpawn;

    public void Cast(GameObject Spell)
    {
        GameObject spell = Instantiate(Spell, this.DefaultSpawn.transform.position, Quaternion.identity);
        Magic.ISpell spellController = spell.GetComponent<Magic.ISpell>();
        spellController.Cast(spell);
        Destroy(spell, 5.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Cast(this.Spell1);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Cast(this.Spell2);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Cast(this.Spell3);
        }
    }
}
