using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovemnt : MonoBehaviour
{
	public Sprite downSprite;

	public Sprite upSprite;
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		spriteRenderer.sprite = upSprite;
	}

	// Update is called once per frame
	void Update()
	{
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