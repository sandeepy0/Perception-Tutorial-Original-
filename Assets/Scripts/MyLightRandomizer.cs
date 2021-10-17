using System;
using UnityEngine;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers;

[Serializable]
[AddRandomizerMenu("Perception/My Light Randomizer")]
public class MyLightRandomizer : Randomizer
{
    public FloatParameter lightIntensityParameter;
    public ColorRgbParameter lightColorParameter;



    protected override void OnIterationStart()
    {
        var tags = tagManager.Query<MyLightRandomizerTag>();

        foreach (var tag in tags)
        {
            var light = tag.GetComponent<Light>();            
            light.color = lightColorParameter.Sample();           
            tag.SetIntensity(lightIntensityParameter.Sample());

      
        }
    }
}
