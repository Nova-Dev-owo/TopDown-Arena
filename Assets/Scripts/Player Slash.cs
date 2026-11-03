using System.Collections;
using UnityEngine;

public class PlayerSlash : DamageBase
{
    public GameObject Trigger;

    
    void Start()
    {
        Trigger.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(DisableSwordCourutine());
        
        }
    }

    private IEnumerator DisableSwordCourutine()
    {
        Trigger.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Trigger.SetActive(false);
    }
}
