class Solution:
    def countCharacters(self, words: List[str], chars: str) -> int:
        c = Counter(chars)
        ret = 0
        for word in words:
            t = Counter(word)
            inv = False
            for x in t:
                if t[x] > c.get(x, 0):
                    inv = True
                    break
                
            if not inv:
                ret = ret + len(word)
                inv = False
        
        return ret
