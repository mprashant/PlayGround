public static void Main()
	{
   /*
Given an array of positive integers that represent a bar graph:
Input: [1,2,5,4,2,4] (Array)
	 _
	| |_   _
	| | | | |
   _| | |_| |
 _| | | | | |
| |	| | | | |
Output: 7 (Int) (Number of strokes required)
How many horizontal paint strokes will be required to paint the complete bar graph. You can only paint one level horizontally at a time.
If the number of strokes exceed 1,000,000,000 then return -1.
*/
   /*
      1,2,5,4,2,4
      
      1. Find min and max(wall)
      2. Find the wall previuse element is greater than current
      3.  as this is wall if prevouse element array[i-1] is less than or equal to wall 
      then add to memory nstrokes. and set min and strokes to zero,
      4. calculate strokes wall - min.
      5. Repeate calculation again
   */
		Console.WriteLine(FindStrokes(new int[]{1,2,5,4,2,4}));
		Console.WriteLine(FindStrokes(new int[]{7,3,2}));
		Console.WriteLine(FindStrokes(new int[]{7,3,2,10}));
		Console.WriteLine(FindStrokes(new int[]{7,3,2,10,2,1}));


	}
//1,2,5,4,2,4
  static int FindStrokes(int[] array){
    Console.WriteLine("[{0}]",string.Join(",",array));
    int strokes = 0;
    int wall = array[0];
    int min = array[0];
    int nstrokes = 0;
    for(int i = 1; i< array.Length; i++){
      //step 1.
      min = Math.Min(array[i],min);
      wall = Math.Max(array[i],wall);

      //step 2.
      if( array[i] < array[i-1] ){
        if(array[i-1] >= wall){
          //step 3.
          //This is wall now. Add this to previous count
          nstrokes += strokes;
          //assign strokes to zero and current element to min.
          //Start new Calculation.
          strokes =0;
          min = array[i];
       }
      }
      //step 4
        strokes = wall - min;
    }
    return strokes + nstrokes;

  }
