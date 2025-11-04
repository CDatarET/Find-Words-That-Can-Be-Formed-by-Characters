class Solution {
    public int countCharacters(String[] words, String chars) {
        HashMap<Character, Integer> map = new HashMap<Character, Integer>();
        for(int i = 0; i < chars.length(); i++){

            map.put(chars.charAt(i), map.getOrDefault(chars.charAt(i), 0) + 1);
        }
        
        int l = 0;
        for (String word : words) {
            HashMap<Character, Integer> wordMap = new HashMap<>();
            boolean canFormWord = true;
            
            for (int i = 0; i < word.length(); i++) {
                char c = word.charAt(i);
                wordMap.put(c, wordMap.getOrDefault(c, 0) + 1);
            }
            
            for (char c : wordMap.keySet()) {
                if (wordMap.get(c) > map.getOrDefault(c, 0)) {
                    canFormWord = false;
                    break;
                }
            }
            
            if (canFormWord) {
                l += word.length();
            }
        }
        
        return(l);
    }
}
