using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmaIDHelper
{
    public class UmaDataEntry
    {
        public int gameId;
        public string? name;

        public string explain
        {
            get
            {
                return $"{gameId} - {name}";
            }
        }
    }

    public class CardDataEntry
    {
        public int cardId;
        public string? cardName;
        public string? fullName;
        public int cardType;
        public int breakLevel = 4;

        public static string[] cardTypePrefix = { "速", "耐", "力", "根", "智", "友", "团" };

        public CardDataEntry() { }
        public CardDataEntry(CardDataEntry e)
        {
            cardId = e.cardId; 
            cardName = e.cardName;
            fullName = e.fullName;
            cardType = e.cardType;
            breakLevel = e.breakLevel;
        }

        public string explain
        {
            get
            {
                return $"{cardId} - [{cardTypePrefix[cardType]}]{fullName}";
            }
        }
        public string explainWithBreak
        {
            get
            {
                return $"{cardId} - [{cardTypePrefix[cardType]}]{fullName} +{breakLevel}";
            }
        }

        public int cardIdWithBreak
        {
            get
            {
                return cardId * 10 + breakLevel;
            }
        }
    }
    public class DB
    {
        public static Dictionary<int, UmaDataEntry> UmaData;
        public static Dictionary<int, CardDataEntry> CardData;
        public static Dictionary<int, Dictionary<int, string>> TranslationData;
        public static List<int> cardHistory;

        public static void load()
        {
            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            TranslationData = JsonConvert.DeserializeObject<Dictionary<int, Dictionary<int, string>>>(
                File.ReadAllText("db/text_data.json"), settings);
            UmaData = JsonConvert.DeserializeObject<Dictionary<int, UmaDataEntry>>(
                File.ReadAllText("db/umaDB.json"), settings);
            CardData = JsonConvert.DeserializeObject<Dictionary<int, CardDataEntry>>(
                File.ReadAllText("db/cardDB.json"), settings);
            foreach (int key in UmaData.Keys)
                if (TranslationData[4].ContainsKey(key))
                    UmaData[key].name = TranslationData[4][key];
            cardHistory = new List<int>();
            if (File.Exists("testConfig.json"))
            {
                TestAiScoreConfig conf = JsonConvert.DeserializeObject<TestAiScoreConfig>(
                    File.ReadAllText("testConfig.json"), settings);
                if (conf.cardHistory != null)
                    cardHistory = conf.cardHistory;
            }
        }

        public static List<UmaDataEntry> matchUma(string query)
        {
            return UmaData.Values
                    .Where(x => x.name != null && x.explain.Intersect(query).Count() > 0)
                    .OrderByDescending(x => x.name.Intersect(query).Count())
                    .ToList();
        }

        public static List<CardDataEntry> matchCard(string query)
        {
            return CardData.Values
                    .Where(x => x.fullName != null && x.fullName.Intersect(query).Count() > 0)
                    .OrderByDescending(x => x.fullName.Intersect(query).Count())
                    .ToList();
        }

        public static CardDataEntry getCard(int idWithBreak)
        {
            CardDataEntry ret = new CardDataEntry(CardData[idWithBreak / 10]);
            ret.breakLevel = idWithBreak % 10;
            return ret;
        }

        public static void updateCardHistory(int idWithBreak)
        {
            cardHistory.RemoveAll(x => x == idWithBreak);
            cardHistory = cardHistory.Prepend(idWithBreak).ToList();
        }
    }

}
