using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public Transform parent;

    private void Start()
    {
        foreach (Transform current in parent) ChangeState(current.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") ChangeState(other.gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy") ChangeState(other.gameObject);
    }

    void ChangeState(GameObject g)
    {
        SpriteRenderer sr = g.GetComponent<SpriteRenderer>();
        Animator anim     = g.GetComponent<Animator>();
        EnemyStats es     = g.GetComponent<EnemyStats>();
        EnemyMovement em  = g.GetComponent<EnemyMovement>();

        if (sr != null)   sr.enabled   = !sr.enabled;
        if (anim != null) anim.enabled = !anim.enabled;
        if (es != null)   es.enabled   = !es.enabled;
        if (em != null)   em.enabled   = !em.enabled;
    }
}
