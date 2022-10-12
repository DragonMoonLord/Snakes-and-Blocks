using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public TextMesh Text;
    public Player Player;
    public int _Health;
    public Text _Text;
    public int _Score;
    public GameObject Particle;

    private AudioSource Audio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            _Health++;
        }
    }

    void Update()
    {
        Text.text = _Health.ToString();
        _Text.text = _Score.ToString();
    }

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    public void TakeHit(int damage)
    { 
        _Health -= damage;
        _Score += 1;
        Audio.Play();

        if (_Health == 0 & gameObject.tag == "Cube")
        {
            Instantiate(Particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (_Health <= 0 & gameObject.tag == "Player")
        {
            Player.Die();
        }
    }
}
