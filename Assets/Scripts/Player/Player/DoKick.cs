using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoKick : MonoBehaviour {

	

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            Debug.Log("0");
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            Vector3 dir = (transform.position - collision.gameObject.transform.position).normalized;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(-dir *200);
            StartCoroutine(Init(collision));
        }
    }

    IEnumerator Init(Collision bomb)
    {
        yield return new WaitForSeconds(2f);
        bomb.gameObject.GetComponent<Rigidbody>().isKinematic = true;

    }
}
