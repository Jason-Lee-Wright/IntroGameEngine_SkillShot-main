using UnityEngine;

public class TeliportManager : MonoBehaviour
{
    public Vector3 Location;

    private GameObject Victim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "")
        {
            Victim = other.gameObject;

            TeliportMe(Victim);
        }
    }

    void TeliportMe(GameObject Subject)
    {
        Subject.transform.position = Location;
    }
}
