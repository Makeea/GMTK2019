﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachEngine : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        this.transform.parent = null;
        this.GetComponent<Rigidbody>().AddRelativeForce(0, -20, 300, ForceMode.Acceleration);
        Destroy(transform.gameObject);
    }



}
