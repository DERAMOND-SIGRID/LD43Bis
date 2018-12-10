using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNonPlayable : Character {

    [SerializeField]
    private bool weakVsWarrior;
    public bool GetWeakVsWarrior() { return weakVsWarrior; }

    [SerializeField]
    private bool weakVsArcher;
    public bool GetWeakVsArcher() { return weakVsArcher; }

    [SerializeField]
    private bool weakVsPicklock;
    public bool GetWeakVsPicklock() { return weakVsPicklock; }

    private bool isFightAllowed;
    public bool GetIsFightAllowed() { return isFightAllowed; }
    public void SetIsFightAllowed(bool isHe) { isFightAllowed = isHe; }

}
