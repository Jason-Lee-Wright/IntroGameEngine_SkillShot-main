using UnityEngine;

public class TeliportManager : MonoBehaviour
{
    public Vector3 Location;

    private GameObject Victim;

    private Rigidbody Rb;

    private void OnTriggerEnter(Collider other)
    {
            Victim = other.gameObject;
            Rb = other.GetComponent<Rigidbody>();

            TeliportMe(Victim);
    }

    void TeliportMe(GameObject Subject)
    {
        Subject.transform.position = Location;
        Rb.linearVelocity = Vector3.zero;
    }
}
