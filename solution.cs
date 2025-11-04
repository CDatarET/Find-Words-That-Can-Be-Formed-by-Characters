public class Solution {
    public int CountCharacters(string[] words, string chars) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in chars) {
            if (map.ContainsKey(c)) {
                map[c]++;
            } else {
                map[c] = 1;
            }
        }
        
        int result = 0;
        foreach (string word in words) {
            Dictionary<char, int> wordMap = new Dictionary<char, int>();
            bool canFormWord = true;
            
            foreach (char c in word) {
                if (wordMap.ContainsKey(c)) {
                    wordMap[c]++;
                } else {
                    wordMap[c] = 1;
                }
            }

            foreach (KeyValuePair<char, int> kvp in wordMap) {
                if (!map.ContainsKey(kvp.Key) || map[kvp.Key] < kvp.Value) {
                    canFormWord = false;
                    break;
                }
            }
            
            if (canFormWord) {
                result += word.Length;
            }
        }
        
        return result;
    }
}
