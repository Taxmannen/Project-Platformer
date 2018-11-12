using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public Transform parent;

    private void Start()
    {
        foreach (Transform current in parent) ChangeState(current.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy" && other.isTrigger) ChangeState(other.gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy" && other.isTrigger) ChangeState(other.gameObject);
    }

    void ChangeState(GameObject g)
    {
        SpriteRenderer sr = g.GetComponent<SpriteRenderer>();
        BoxCollider2D col = g.GetComponent<BoxCollider2D>();
        Animator anim     = g.GetComponent<Animator>();
        Rigidbody2D rb    = g.GetComponent<Rigidbody2D>();
        EnemyStats es     = g.GetComponent<EnemyStats>();
        EnemyMovement em  = g.GetComponent<EnemyMovement>();
        EnemyDamage ed    = g.GetComponent<EnemyDamage>();


        if (col != null)
        {
            col.enabled = !col.enabled;
            if (col.enabled) rb.isKinematic = false;
            else             rb.isKinematic = true;
        }

        if (sr   != null) sr.enabled   = !sr.enabled;
        if (anim != null) anim.enabled = !anim.enabled;
        if (es   != null) es.enabled   = !es.enabled;
        if (em   != null) em.enabled   = !em.enabled;
        if (ed   != null) ed.enabled   = !ed.enabled;
    }
}
