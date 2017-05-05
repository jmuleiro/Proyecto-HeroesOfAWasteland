using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {

    private PlayerBehaviour player;
    private KnockBackScript knock;
    private killPlayer dmgplayer;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();

    }
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (!dmgplayer.invincible)
            {
                if (col.name == "Player")
                {
                    player.Damage(1);
                    StartCoroutine(knock.Knockback(0.02f, 350, player.transform.position));
                    dmgplayer.invincible = true;
                    Invoke("dmgplayer.resetInvulnerability", 2);
                    
                }

            }
        }
    }
    }
}
