using UnityEngine;
using System.Collections;

public class soundCheck : MonoBehaviour {
	private float counter = 0;
	public static bool spawner;
	public static bool spawner2;
	public static bool spawner3;
	public static bool spawner4;
	private float[] freqData;
	private int nSamples = 1024;
	private float freqLow;
	private float freqMid;
	private float freqMidTwo;
	private float freqHigh;

	void Update() {

		/*om de frequenties van de spectrum wave van de audio gebruik je GetspectrumData*/
		freqData = AudioListener.GetSpectrumData (nSamples, 0, FFTWindow.Hamming);

		float low = freqData [3] + freqData [2] + freqData [4];
		float mid = freqData [11] + freqData [12] + freqData [13];
		float midTwo = freqData [22] + freqData [23] + freqData [24];
		float high = freqData [44] + freqData [45] + freqData [46] + freqData [47] + freqData [48] + freqData [49];
		//print (low);
		//print ("high: " + high);
		spawner = false;
		spawner2 = false;
		spawner3 = false;
		spawner4 = false;
		freqLow = 0.004f;
		freqMid = 0.009f;
		freqMidTwo = 0.01f;
		freqHigh = 0.01f;

		counter += Time.deltaTime;
		//print (counter + ". mid: " + mid);

		if (counter >= 12.6) {
			freqMid = 0.007f;		
		}
		if (counter >= 14.6) {
			freqMid = 0.005f;
			freqLow = 0.1f;
		}

		if (low >= freqLow) {
			spawner = true;
		}
		if (mid >= freqMid) {
			spawner2 = true;
		}
		if (midTwo >= freqMidTwo) {
			spawner3 = true;
		}
		if (high >= freqHigh) {
			spawner4 = true;
		}
		/*freqData = audio.GetSpectrumData(nSamples, 0, FFTWindow.Hamming);

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

		}*/
	}
}
