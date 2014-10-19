using UnityEngine;
using System.Collections;

public class AnimationControll : MonoBehaviour 
{
    double count=0;
    

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void change(UnityEngine.KeyCode key, string name, double sec)
    {
        

        if (count <= 0)
        {
            animator.SetBool(name, false);
            if (Input.GetKeyDown(key))
            {
                animator.SetBool(name, true);
                count = sec*300;
            }
        }

        count--;
    }


    // Update is called once per frame
    void Update()
    {

        change(KeyCode.A, "Wait01", 6.34);
        change(KeyCode.S, "Wait02", 8.16);
        change(KeyCode.D, "Wait03", 5.10);
        change(KeyCode.F, "Wait04", 5.10);
        change(KeyCode.G, "Win00", 4.00);
        change(KeyCode.H, "Jump00", 1.50);
        change(KeyCode.J, "Jump01", 2.00);
        change(KeyCode.K, "Damage01", 3.34);
    }
}
