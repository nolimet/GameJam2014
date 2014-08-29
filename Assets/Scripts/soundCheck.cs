using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class soundCheck : MonoBehaviour {
	private float counter;
	private float counterFilter;
	private float counterLast = 0f;
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

	void FixedUpdate() {
		spawner = false;
		spawner2 = false;
		spawner3 = false;
		spawner4 = false;

		counterFilter +=  1f ;
		counter = Mathf.Floor (counterFilter);
		//print (counter);

		if (counter == 40f){
			spawner3 = true;
		}
		else if (counter == 70f){
			spawner3 = true;
		}
		else if (counter == 102f){
			spawner3 = true;
		}
		else if (counter == 162f){
			spawner3 = true;
		}
		else if (counter == 192f){
			spawner3 = true;
		}
		else if (counter == 213f){
			spawner3 = true;
		}
		else if (counter == 280f){
			spawner3 = true;
		}
		else if (counter == 310f){
			spawner3 = true;
		}
		else if (counter == 337f){
			spawner3 = true;
		}
		else if (counter == 380f){
			spawner3 = true;
		}
		else if (counter == 415f){
			spawner3 = true;
		}
		else if (counter == 445f){
			spawner3 = true;
		}
		else if (counter == 480f){
			spawner3 = true;
		}
		else if (counter == 502f){
			spawner3 = true;
		}
		else if (counter == 542f){
			spawner3 = true;
		}
		else if (counter == 552f){
			spawner3 = true;
		}
		else if (counter == 558f){
			spawner3 = true;
		}
		else if (counter == 562f){
			spawner3 = true;
		}
		
			else if (counter == 610f){
				spawner4 = true;
			}
			else if (counter == 622f){
				spawner4 = true;
			}
			else if (counter == 642f){
				spawner4 = true;
			}
			else if (counter == 652f){
				spawner4 = true;
			}
			else if (counter == 678f){
				spawner4 = true;
			}
			else if (counter == 692f){
				spawner4 = true;
			}
			else if (counter == 710f){
				spawner4 = true;
			}
			else if (counter == 722f){
				spawner4 = true;
			}
			else if (counter == 742f){
				spawner4 = true;
			}
			else if (counter == 752f){
				spawner4 = true;
			}
			else if (counter == 778f){
				spawner4 = true;
			}
			else if (counter == 792f){
				spawner4 = true;
			}
			else if (counter == 810f){
				spawner4 = true;
			}
			else if (counter == 822f){
				spawner4 = true;
			}
			else if (counter == 842f){
				spawner4 = true;
			}
			else if (counter == 852f){
				spawner4 = true;
			}
			else if (counter == 878f){
				spawner4 = true;
			}
			else if (counter == 892f){
				spawner4 = true;
			}
			else if (counter == 910f){
				spawner4 = true;
			}
			else if (counter == 922f){
				spawner4 = true;
			}
			else if (counter == 942f){
				spawner4 = true;
			}
			else if (counter == 952f){
				spawner4 = true;
			}
			else if (counter == 978f){
				spawner4 = true;
			}
			else if (counter == 992f){
				spawner4 = true;
			}
		
		print (counter);

		/*om de frequenties van de spectrum wave van de audio gebruik je GetspectrumData*/
		/*freqData = AudioListener.GetSpectrumData (nSamples, 0, FFTWindow.Hamming);

		float low = freqData [3] + freqData [2] + freqData [4] * 10000;
		float mid = freqData [11] + freqData [12] + freqData [13] * 10000;
		float midTwo = freqData [22] + freqData [23] + freqData [24] * 10000;
		float high = freqData [44] + freqData [45] + freqData [46] + freqData [47] + freqData [48] + freqData [49] * 10000;
		//print (low);
		//print ("high: " + high);
		spawner = false;
		spawner2 = false;
		spawner3 = false;
		spawner4 = false;

		counter += Time.deltaTime;
		//print (audio.time);
		print ("low: " + low + "- mid: " + mid + "- midTwo: " + midTwo + "- high: " + high);
		if (counter >= 0) {
			freqLow = 0.004f;
			freqMid = 0.009f;
			freqMidTwo = 0.01f;
			freqHigh = 0.09f;	
		}
		if (counter >= 12.6) {
			freqMid = 0.0024f;		
		}
		if (counter >= 14.6) {
			freqMid = 0.005f;
			freqLow = 0.09f;
		}

		if (low >= freqLow) {
			//spawner = true;
		}
		if (mid == 13.28075) {
			spawner2 = true;
		}
		if (midTwo >= freqMidTwo) {
			//spawner3 = true;
		}
		if (high >= freqHigh) {
			//spawner4 = true;
		}*/
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
