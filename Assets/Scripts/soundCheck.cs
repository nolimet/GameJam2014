using UnityEngine;
using System.Collections;

public class soundCheck : MonoBehaviour {
	private float counter = 0;
	public static bool spawner;
	private float[] freqData;
	private int nSamples = 1024;
	/*private float fmax;

	void GetSpectrum(){
		audio.GetSpectrumData (freqData, 0, FFTWindow.BlackmanHarris);
	
	}
	void BandVol(float fLow, float fHigh){
		fLow = Mathf.Clamp (fLow, 20, fmax);
		fHigh = Mathf.Clamp (fHigh, fLow, fmax);
		float n1 = Mathf.Floor (fLow * nSamples / fmax);
		float n2 = Mathf.Floor (fHigh * nSamples / fmax);
		float sum = 0;

		for (float i = fLow; i < fHigh; i++) {
			sum += freqData[i];		
		}
		return sum / (fLow - fHigh);
	}*/
	void Update() {
		//print (spawner);
		freqData = audio.GetSpectrumData(nSamples, 0, FFTWindow.Hamming);

		int i = 1;
		spawner = false;
		counter += 1;
		while (i < 1023) {
			//Debug.DrawLine(new Vector3(i - 1, freqData[i] + 10, 0), new Vector3(i, freqData[i + 1] + 10, 0), Color.red);
			//Debug.DrawLine(new Vector3(i - 1, Mathf.Log(freqData[i - 1]) + 10, 2), new Vector3(i, Mathf.Log(freqData[i]) + 10, 2), Color.cyan);
			//Debug.DrawLine(new Vector3(Mathf.Log(i - 1), freqData[i - 1] - 10, 1), new Vector3(Mathf.Log(i), freqData[i] - 10, 1), Color.green);
			Debug.DrawLine(new Vector3(Mathf.Log(i - 1), Mathf.Log(freqData[i - 1]), 3), new Vector3(Mathf.Log(i), Mathf.Log(freqData[i]), 3), Color.yellow);
			i++;
				if (freqData[i] >= 0.07){
					spawner = true;
				} 

		}
	}
}
