using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float explosionForce = 10;

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce((collision.transform.position - transform.position).normalized * explosionForce, ForceMode.Impulse);
    }
}
