using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovemnt : MonoBehaviour
{
	public Sprite downSprite;

	public Sprite upSprite;
	public float jumpHeight;
	private SpriteRenderer spriteRenderer;
	private Rigidbody2D rB;
	// Use this for initialization
	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = upSprite;

		rB = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()   
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			
			rB.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
		}
		if (Input.GetKey(KeyCode.Space))
		{
			spriteRenderer.sprite = downSprite;

		}
		else
		{
			spriteRenderer.sprite = upSprite;   
		}
	}
}