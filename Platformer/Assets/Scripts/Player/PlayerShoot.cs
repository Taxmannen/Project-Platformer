using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public GameObject snowball;
    public GameObject parent;

    Animator anim;
    PlayerStats playerStats;

	void Start () 
	{
        anim = GetComponent<Animator>();
        playerStats = GetComponent<PlayerStats>();
    }
	
	void Update () 
	{
        if (Input.GetButtonDown("Fire1") && !anim.GetCurrentAnimatorStateInfo(0).IsName("PlayerShoot") && playerStats.currentHealth > 150)
        {
            anim.Play("PlayerShoot");
            Instantiate(snowball, transform.GetChild(0).position, snowball.transform.rotation, parent.transform);
            playerStats.RemoveHealth(10);
        }
	}
}
