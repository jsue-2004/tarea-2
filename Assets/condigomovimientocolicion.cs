using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condigomovimiento : MonoBehaviour
{
    Transform _transformcomponent;
    SpriteRenderer _spriteRenderercomponent;
    Rigidbody2D _rigidbody2Dcomponent;
    public int direccionx = 1;
    public int direcciony = 1;
    public int velocity = 1;
    // Start is called before the first frame update
    void Start()
    {
        _transformcomponent = GetComponent<Transform>();
        _spriteRenderercomponent = GetComponent<SpriteRenderer>();
        _rigidbody2Dcomponent = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         _rigidbody2Dcomponent.velocity = new Vector2(velocity * direccionx,  velocity * direcciony);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "paredx")
        {
            _spriteRenderercomponent.flipY = !_spriteRenderercomponent.flipY;
            _spriteRenderercomponent.flipX = !_spriteRenderercomponent.flipX;
            direcciony = direcciony * -1;

        }
        if (collision.gameObject.tag == "paredy")
        {
            direccionx = direccionx * -1;
            _spriteRenderercomponent.flipX = !_spriteRenderercomponent.flipX;
            _spriteRenderercomponent.flipY = !_spriteRenderercomponent.flipY;
        }
    }

}