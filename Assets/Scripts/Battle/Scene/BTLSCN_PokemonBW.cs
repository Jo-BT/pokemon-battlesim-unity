using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTLSCN_PokemonBW : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer shadowRenderer;
    public string pokemonUniqueID;

    private MaterialPropertyBlock _propBlock;
    void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
    }
}
