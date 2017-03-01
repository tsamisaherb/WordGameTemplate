using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterFrequencies : MonoBehaviour {

	protected int A;
	protected int B;
	protected int C;
	protected int D;
	protected int E;
	protected int F;
	protected int G;
	protected int H;
	protected int I;
	protected int J;
	protected int K;
	protected int L;
	protected int M;
	protected int N;
	protected int O;
	protected int P;
	protected int Q;
	protected int R;
	protected int S;
	protected int T;
	protected int U;
	protected int V;
	protected int W;
	protected int X;
	protected int Y;
	protected int Z;

	public int [] LetterArray()
	{
		int[] array = new int[26];
		array[0] = A;
		array[1] = B;
		array[2] = C;
		array[3] = D;
		array[4] = E;
		array[5] = F;
		array[6] = G;
		array[7] = H;
		array[8] = I;
		array[9] = J;
		array[10] = K;
		array[11] = L;
		array[12] = M;
		array[13] = N;
		array[14] = O;
		array[15] = P;
		array[16] = Q;
		array[17] = R;
		array[18] = S;
		array[19] = T;
		array[20] = U;
		array[21] = V;
		array[22] = W;
		array[23] = X;
		array[24] = Y;
		array[25] = Z;
		return array;
	}

	public int TotalCharacters()
	{
		int total = 0;
		int[] array = LetterArray();
		for(int i=0; i<array.Length; i++)
		{
			total+=array[i];
		}
		return total;
	}
}
