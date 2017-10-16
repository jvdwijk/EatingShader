using UnityEngine;

public class ConsumeFood : MonoBehaviour
{
	private Material _material;
	private float _size;

	private void Start()
	{
		_material = gameObject.GetComponent<Renderer>().material;
	}
	
    void OnTriggerStay (Collider other)
    {
	    if (other.CompareTag("Player") || !Input.GetKeyDown(KeyCode.Space)) return;
	    _size = _size + 0.1f;
	    print(_material.GetFloat("_Amount"));
	    _material.SetFloat("_Amount", _size);
	    
    }
  }