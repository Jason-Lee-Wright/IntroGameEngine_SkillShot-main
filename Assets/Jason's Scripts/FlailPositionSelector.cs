using UnityEngine;

public class FlailPositionSelector : MonoBehaviour
{
    public float Pos_;

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();

        animator.SetFloat("Pos", Pos_);
    }
}
