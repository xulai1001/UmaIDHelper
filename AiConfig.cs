using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmaIDHelper
{
    public class TestAiScoreConfig
    {
        public string engine = "testAiConfig";
        public int umaId;
        public int umaStars = 5;
        public int totalGames = 50000;
        public int eventStrength = 20;
        public List<int> cards;
        public List<int> zhongmaBlue;
        public List<int> zhongmaBonus;
        public List<bool> allowedDebuffs;
        public List<int> cardHistory;
    }
    /*
    public class AiConfig
    {
        public bool noColor = false;
        public int radicalFactor = 5;
        public int threadNum = 12;
        public int searchN = 12288;
        public bool debugPrint = false;
        public string role = "default";
        public bool extraCardData = true;
        public bool useWebsocket = true;
        public TestAiScoreConfig testAiScore;
    }
    */
}
