using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomReactionStep : ReactionStep
{
    [SerializeField]
    [Range(0, 100)]
    private int activationChance = 100;

    protected override void React()
    {
        if (Random.Range(0,100) < activationChance)
        {
            node.animator.SetTrigger(DialogParameters.randomSuccess);
        }
        else
        {
            node.animator.SetTrigger(DialogParameters.randomFailure);
        }
    }
}
