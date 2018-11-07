using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour {
    [Tooltip("The amount of health added on player collision")]
    public int healthAmount;

    PlayerStats playerStats;
    ParticleSystem ps;

    void Start()
    {
        playerStats = transform.parent.GetComponent<PlayerStats>();
        ps = GetComponent<ParticleSystem>();
    }

    void Update ()
    {
        transform.position = new Vector3(transform.position.x, 12.5f, transform.position.z);	
	}

    void OnParticleTrigger()
    {
        if (ps != null)
        {
            List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();

            //The amout of entered particles
            int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
            for (int i = 0; i < numEnter; i++)
            {
                ParticleSystem.Particle particle = enter[i];
                enter[i] = particle;
                playerStats.AddHealth(healthAmount);
            }
            ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        }
    }
}
