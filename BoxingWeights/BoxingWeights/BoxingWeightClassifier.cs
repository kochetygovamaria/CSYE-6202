using System;

namespace BoxingWeights
{
	public class BoxingWeightClassifier
	{
		public string ClassifyBoxingWeight(int weightInPounds)
		{
            string result = "Heavyweight";
              
            if (weightInPounds <= 105)
               result="Strawweight and "+ result;
            if (weightInPounds > 105 && weightInPounds <= 108)
                result = "JuniorFlyweight and "  +  result;
            if (weightInPounds > 108 && weightInPounds <= 112)
                result= "Flyweight and " + result;
            if (weightInPounds > 112 && weightInPounds <= 115)
                result= "JuniorBantamweight";
            if (weightInPounds > 115 && weightInPounds <= 118)
                result= "Bantamweight and " + result;
            if (weightInPounds > 118 && weightInPounds <= 122)
                result= "JuniorFeatherweight and " + result;
            if (weightInPounds > 122 && weightInPounds <= 126)
                result= "Featherweight and " + result;
            if (weightInPounds > 126 && weightInPounds <= 130)
                result= "JuniorLightweight and " + result;
            if (weightInPounds > 130 && weightInPounds <= 135)
                result= "Lightweight and " + result;
            if (weightInPounds > 135 && weightInPounds <= 140)
                result= "JuniorWelterweight and " + result;
            if (weightInPounds > 140 && weightInPounds <= 147)
                result= "Welterweight and " + result;
            if (weightInPounds > 147 && weightInPounds <= 154)
                result= "JuniorMiddleweight and " + result;
            if (weightInPounds > 154 && weightInPounds <= 160)
                result= "Middleweight and " + result;
            if (weightInPounds > 160 && weightInPounds <= 168)
                result= "SuperMiddleweight and " + result;
            if (weightInPounds > 168 && weightInPounds <= 175)
                result= "LightHeavyweight and " + result;
            if (weightInPounds > 175 && weightInPounds <= 200)
                result= "Cruiserweight and " + result;

            return result;
            
		}
        
	}
   
    
}
