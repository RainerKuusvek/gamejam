using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour {
    public float acceleration;
    SphereCollider thisspherecollider;
    private void Start()
    {
        thisspherecollider = GetComponent<SphereCollider>();
    }
    private void OnTriggerStay(Collider other)
    {
        Vector2 delta = transform.position - other.transform.position;
        float distance = delta.magnitude;
        float localRadius = thisspherecollider.radius * transform.lossyScale.x;
        float acl = Mathf.Clamp((1 - distance / localRadius) *acceleration, 0, acceleration);
        other.attachedRigidbody.AddForce(delta.normalized*acl);
    }

}
