using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkybox : MonoBehaviour
{
    // Start is called before the first frame update
    private Material safeKeeping;

    public IEnumerator sky(Material transitionMaterial, float duration, float cap) {
        Material orig = new Material(RenderSettings.skybox);
        orig.Lerp(orig, transitionMaterial, cap);

        float elapsedTime = 0.0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            RenderSettings.skybox.Lerp(
                RenderSettings.skybox, orig,
                Mathf.Clamp01(elapsedTime / duration)
            );
            DynamicGI.UpdateEnvironment();
            yield return new WaitForEndOfFrame();
        }
    }

    void Start()
    {
        safeKeeping = new Material(RenderSettings.skybox);
    }

    void OnDisable() {
        RenderSettings.skybox = safeKeeping;
        DynamicGI.UpdateEnvironment();
    }

    void OnDestroy() {
        RenderSettings.skybox = safeKeeping;
        DynamicGI.UpdateEnvironment();
    }
}
