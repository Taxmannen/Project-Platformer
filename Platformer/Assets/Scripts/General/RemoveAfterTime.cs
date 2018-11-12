using UnityEngine;

public class RemoveAfterTime : MonoBehaviour {
    public float timeToDestroy;

    float timer;

	void Update ()
    {
        timer += Time.deltaTime;
        if (timer >= timeToDestroy) Destroy(gameObject);
	}
}
