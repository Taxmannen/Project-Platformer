using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject snowball;
    public GameObject parent;

    Animator anim;

	void Start () 
	{
        anim = GetComponent<Animator>();	
	}
	
	void Update () 
	{
        if (Input.GetButtonDown("Fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("PlayerShoot"))
        {
            anim.Play("PlayerShoot");
            Instantiate(snowball, transform.GetChild(0).position, snowball.transform.rotation, parent.transform);
        }
	}
}
