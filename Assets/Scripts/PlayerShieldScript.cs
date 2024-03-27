using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldScript : MonoBehaviour
{
    private HealthScript healthScript;

    // Start is called before the first frame update
    void Awake()
    {
        healthScript = GetComponent<HealthScript>();
    }

    public void ActivateShield(bool shieldActivate)
    {
        healthScript.shieldActivate = shieldActivate;
    }
}
