using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour {

    public int value = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered!");
        Destroy(gameObject);
    }
}
